-- exec [PobaruvaDolguvaPartner] '2023-01-27 18:34:14.003', '2023-05-27 18:34:14.003', 96
CREATE  PROCEDURE [dbo].[PobaruvaDolguvaPartner] (  
      @DatumPocetok datetime,  
   @DatumKraj datetime,  
   @PartnerID int  
)  
AS  
BEGIN  
  Declare @Sifra nvarchar(5)   
  Declare @Naziv nvarchar(100)  
  set @DatumKraj =  DATEADD(month, 1, @DatumKraj)
 Select b.* from (Select A.tblPartnerID as ID, p.Sifra, p.Naziv, A.TipNaDokument,A.Broj, A.DatumNaKnizenje as DatumNaDokument,DATEADD(month, 1, A.DatumNaKnizenje)  as DatumNaValuta, ROUND(SUM(A.IznosSoDDV),0) as Platil, ROUND(SUM(A.Pobaruva),0) as Dolzi  
  from (     
   SELECT 4 as TipNaDokument,
   (select d.BrojNaDokument from tblDokumenti d where d.ID = tblDokumentID) as Broj,
   DatumNaKnizenje, 
   DATEADD(month, 1, DatumNaKnizenje)  as DatumNaValuta,
   SUM(IznosDDV) as IznosDDV,
   0 as IznosSoDDV,
   SUM(IznosBezDDV ) as IznosBezDDV,
   tblPartnerID , SUM(IznosSoDDV) as Pobaruva FROM viewKnzienjaM   
   WHERE (tipNaKnizenje = 2 OR tipNaKnizenje = 1) and DokumentBroj is not null and tblPartnerID is not null and  (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) and tblPartnerID = @PartnerID  
   Group by DatumNaKnizenje,tblPartnerID,  DokumentBroj , tblDokumentID

   UNION ALL   
   SELECT 3 as TipNaDokument,CAST(PriemBroj as Nvarchar(20)) as Broj,DatumNaKnizenje,
   DATEADD(month, 1, DatumNaKnizenje)  as DatumNaValuta,
   SUM(IznosDDV) as IznosDDV, 0 as IznosSoDDV, SUM(IznosBezDDV )  as IznosBezDDV , tblPartnerID , SUM(IznosSoDDV ) as Pobaruva FROM viewKnzienjaM   
   WHERE (tipNaKnizenje = 3) and tblPartnerID is not null and  (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) and tblPartnerID = @PartnerID and PriemBroj is not null  
   Group by DatumNaKnizenje,tblPartnerID,  PriemBroj 
   UNION ALL   
   SELECT 3 as TipNaDokument,CAST(DokumentBroj as Nvarchar(20)),DatumNaKnizenje,
   DATEADD(month, 1, DatumNaKnizenje)  as DatumNaValuta,SUM(IznosDDV) as IznosDDV, 0 as IznosSoDDV,SUM(IznosBezDDV )  as IznosBezDDV, tblPartnerID, SUM(IznosSoDDV ) as Pobaruva FROM viewKnzienjaM   
   WHERE (tipNaKnizenje = 3) and DokumentBroj is not null and tblPartnerID is not null and (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj)  and tblPartnerID = @PartnerID  
   Group by DatumNaKnizenje,tblPartnerID,DokumentBroj )as A  
   left outer join tblPartneri p on p.ID = A.tblPartnerID  
   Group BY A.tblPartnerID, P.Sifra, P.Naziv,A.TipNaDokument, A.Broj, A.DatumNaKnizenje   
   UNION ALL  
   SELECT ID ,Sifra ,Naziv,5,'Isplateno',GETDATE(),GETDATE(),isnull(dbo.IznosNaPlacanjaOdPartner(@PartnerID,@DatumPocetok, @DatumKraj,1),0),0   
   from tblPartneri where ID = @PartnerID  
   UNION ALL  
   SELECT ID ,Sifra ,Naziv,5,'Plateno',GETDATE(),GETDATE(),isnull(dbo.IznosNaPlacanjaOdPartner(@PartnerID,@DatumPocetok, @DatumKraj,0),0) ,0
   from tblPartneri where ID = @PartnerID) as b  
   where not (b.Dolzi = 0 and b.Platil = 0)  
  
END