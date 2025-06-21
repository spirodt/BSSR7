CREATE view [dbo].[SaldoNaPartneriSoAnalitka] as     
--select * from SaldoNaPartneriSoAnalitka    
SELECT    
 p.Id,    
    p.Sifra,    
 p.Naziv,  
    doc.*,  
 CASE   
    WHEN p.TipNaDostava = 0 THEN N'Хартиена форма'  
    WHEN p.TipNaDostava = 1 THEN N'Електронска форма (маил)'  
    WHEN p.TipNaDostava = 2 THEN N'Хартиена и Електронска форма'  
    WHEN p.TipNaDostava = 3 THEN N'Нема достава'  
    END as TipNaDostava  
FROM tblPartneri p    
CROSS APPLY     
(    
 Select
	CAST(doc.DatumNaValuta as Date) DatumNaValuta,
	doc.BrojNaDokument,
	ROUND(IznosSoDDV,0) as IznosSoDDV,    
	ROUND(isnull(dbo.PlatenoZaDokument(p.ID,doc.ID,doc.broj),0),0) as Plateno,    
	ROUND(isnull(dbo.PlatenoZaDokument(p.ID,doc.ID,doc.broj),0),0) - (ROUND(IznosSoDDV,0)) as Saldo,
    doc.Notes as Zabeleski
 from viewDokumenti doc    
 Where p.ID = doc.tblPartnerID    
 Group by doc.DatumNaValuta,doc.BrojNaDokument,doc.IznosSoDDV,doc.ID,doc.Broj,doc.Notes
) doc
GO


