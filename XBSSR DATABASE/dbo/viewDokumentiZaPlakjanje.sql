CREATE view [dbo].[viewDokumentiZaPlakjanje] As          
select A.TipNaDokument, A.ID, A.tblPartnerID,A.SifraPartner, A.Broj, A.Datum,A.DocNaziv, ROUND(ISNULL(A.IznosNaDokument,0),0) as IznosNaDokument,            
ROUND((ISNULL(A.IznosNaDokument,0) - ISNULL(A.PlatenoZaDokument,0)),0) as PreostanatoZaPlacanje,            
ROUND(ISNULL(A.PlatenoZaDokument,0),0) as  PlatenoZaDokument            
            
from             
(       
-- FAKTURA OBICNA  
  select 9 as TipNaDokument,    
  ID,    
  tblPartnerID,    
  SifraPartner,    
  CAST(Broj as nvarchar(20)) as Broj,    
  Datum,    
  round(SUM(Iznos),0) as IznosNaDokument,     
  dbo.PlatenoZaDokument( tblPartnerID, ID, Broj) as PlatenoZaDokument,             
  ( N'Фактура број : ' +  CAST(Broj as nvarchar(20))) as DocNaziv             
 from viewFakturi            
 where ID in (select tblFakturaID from tblKnizenjeM)            
 group by  ID,tblPartnerID, Broj, Datum ,SifraPartner          
     
 UNION ALL            
--PRIEM     
 select 10 as TipNaDokument,    
 ID,    
 tblPartnerID,    
 SifraPartner,    
 CAST(PriemBroj as nvarchar(20)) as Broj,     
 PriemDatum,     
 round(SUM(IznosSoDDV),0) as IznosNaDokument,     
 dbo.PlatenoZaDokumentPriem( tblPartnerID, ID, PriemBroj) as PlatenoZaDokument,            
 ( N'Прием број : ' +  CAST(PriemBroj as nvarchar(20))) as DocNaziv            
 from viewPriemi            
 where ID in (select tblPriemID from tblKnizenjeM)            
 group by  ID,tblPartnerID, PriemBroj, PriemDatum,SifraPartner              
     
 UNION ALL             
 --DOKUMENT  NA POBARUVA  
 select 11 as TipNaDokument,    
 ID,    
 tblPartnerID,    
 SifraPartner,    
 CAST(Broj as nvarchar(20)) as Broj,    
 Datum,    
 SUM(IznosSoDDV) as IznosNaDokument,    
 dbo.PlatenoZaDokumentPriem( tblPartnerID, ID, Broj) as PlatenoZaDokument,            
 ( N'Документ број : ' +  CAST(Broj as nvarchar(20))) as DokumentNaziv            
 from viewDokumenti            
 where ID in (select tblDokumentID from tblKnizenjeM where TipNaKnizenje <> -1) and tblPartnerID is not null            
 AND TipDokumentID >= 10 AND TipDokumentID NOT IN (1,2,3)  
 group by  ID,tblPartnerID, BrojChar, Datum, Broj,SifraPartner         
     
 UNION ALL      
   --DOKUMENT   NA POBARUVA - FAKTURA 1   
 select 1 as TipNaDokument,    
 ID,    
 tblPartnerID,    
 SifraPartner,    
 BrojNaDokument as Broj,    
 Datum,    
 SUM(IznosSoDDV) as IznosNaDokument,    
 dbo.PlatenoZaDokument( tblPartnerID, ID, Broj) as PlatenoZaDokument,            
 ( N'Фактура Одржување: ' +  BrojNaDokument) as DokumentNaziv              
 from viewDokumenti      
 where ID in (select tblDokumentID from tblKnizenjeM where TipNaKnizenje = 1)      
 AND TipDokumentID < 10 AND TipDokumentID NOT IN (2,3)   
 and tblPartnerID is not null            
 group by  ID,tblPartnerID, BrojChar, Datum ,Broj,SifraPartner ,BrojNaDokument       
     
 UNION ALL      
   --DOKUMENT   NA POBARUVA - FAKTURA 2  
 select 2 as TipNaDokument, ID,tblPartnerID,SifraPartner, BrojNaDokument as Broj, Datum, SUM(IznosSoDDV) as IznosNaDokument, dbo.PlatenoZaDokument( tblPartnerID, ID, Broj) as PlatenoZaDokument,            
 ( N'Фактура HVAC: ' +  BrojNaDokument + ' ' + Notes) as DokumentNaziv            
 from viewDokumenti      
 where ID in (select tblDokumentID from tblKnizenjeM where TipNaKnizenje = 1)      
 AND TipDokumentID < 10 AND TipDokumentID NOT IN (1,3)   
 and tblPartnerID is not null            
 group by  ID,tblPartnerID, BrojChar, Datum ,Broj ,SifraPartner,BrojNaDokument,Notes     
         
   UNION ALL      
       
   --DOKUMENT   NA POBARUVA - FAKTURA 2  
 select 3 as TipNaDokument, ID,tblPartnerID,SifraPartner, BrojNaDokument as Broj, Datum, SUM(IznosSoDDV) as IznosNaDokument, dbo.PlatenoZaDokument( tblPartnerID, ID, Broj) as PlatenoZaDokument,            
 ( N'Фактура : ' +  BrojNaDokument + ' ' + Notes) as DokumentNaziv            
 from viewDokumenti      
 where   
 ID in (select tblDokumentID from tblKnizenjeM where TipNaKnizenje = 1)    AND   
 TipDokumentID < 10 AND TipDokumentID NOT IN (1,2)    
 and tblPartnerID is not null            
 group by  ID,tblPartnerID, BrojChar, Datum ,Broj ,SifraPartner,BrojNaDokument,Notes         
     
 ) as A            
 where ROUND((ISNULL(A.IznosNaDokument,0) - ISNULL(A.PlatenoZaDokument,0)),0) > 0 


