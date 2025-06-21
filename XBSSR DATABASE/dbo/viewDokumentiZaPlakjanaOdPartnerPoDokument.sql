CREATE view [dbo].[viewDokumentiZaPlakjanaOdPartnerPoDokument] As    
select A.TipNaDokument, A.ID, A.tblPartnerID, A.Broj, A.Datum,A.DocNaziv, ROUND(ISNULL(A.IznosNaDokument,0),0) as IznosNaDokument,      
ROUND((ISNULL(A.IznosNaDokument,0) - ISNULL(A.PlatenoZaDokument,0)),0) as PreostanatoZaPlacanje,      
ROUND(ISNULL(A.PlatenoZaDokument,0),0) as  PlatenoZaDokument      
      
from       
(      
  select 2 as TipNaDokument, ID,tblPartnerID, Broj, Datum, round(SUM(Iznos),0) as IznosNaDokument, dbo.PlatenoZaDokument( tblPartnerID, ID, Broj) as PlatenoZaDokument,       
  ( N'Фактура број : ' +  CAST(Broj as nvarchar(20))) as DocNaziv      
 from viewFakturi      
 where ID in (select tblFakturaID from tblKnizenjeM)      
 group by  ID,tblPartnerID, Broj, Datum      
 UNION ALL      
 select 3 as TipNaDokument, ID,tblPartnerID, PriemBroj, PriemDatum, round(SUM(IznosSoDDV),0) as IznosNaDokument, dbo.PlatenoZaDokumentPriem( tblPartnerID, ID, PriemBroj) as PlatenoZaDokument,      
 ( N'Прием број : ' +  CAST(PriemBroj as nvarchar(20))) as DocNaziv      
 from viewPriemi      
 where ID in (select tblPriemID from tblKnizenjeM)      
 group by  ID,tblPartnerID, PriemBroj, PriemDatum      
 UNION ALL       
 select 3 as TipNaDokument, ID,tblPartnerID, Broj, Datum, SUM(IznosSoDDV) as IznosNaDokument, dbo.PlatenoZaDokumentPriem( tblPartnerID, ID, Broj) as PlatenoZaDokument,      
 ( N'Документ број : ' +  CAST(Broj as nvarchar(20))) as DokumentNaziv      
 from viewDokumenti      
 where ID in (select tblDokumentID from tblKnizenjeM) and tblPartnerID is not null  
 and TipDokumentID = 3
 group by  ID,tblPartnerID, Broj, Datum      
 UNION ALL       
 select 2 as TipNaDokument, ID,tblPartnerID, Broj, Datum, SUM(IznosSoDDV) as IznosNaDokument, 
  dbo.PlatenoZaDokument( tblPartnerID, ID, Broj) as PlatenoZaDokument,      
 ( N'Фактура број: ' +  CAST(BrojNaDokument as nvarchar(50))) as DokumentNaziv      
 from viewDokumenti      
 where ID in (select tblDokumentID from tblKnizenjeM) and tblPartnerID is not null      
 group by  ID,tblPartnerID,broj, BrojNaDokument, Datum            
      
 ) as A