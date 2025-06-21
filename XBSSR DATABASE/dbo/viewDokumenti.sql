CREATE view [dbo].[viewDokumenti]     
as    
select d.ID, d.Broj,CAST(d.Broj AS Nvarchar(10)) + '\' + CAST(YEAR(d.Datum) AS nvarchar(4)) AS BrojChar,d.TipNaDokument as TipDokumentID, t.Naziv as TipNaDokument, d.Datum,d.Zabeleska, do.Naziv as ObejektDO, od.Naziv as ObjektOD,    
u.FullName as UserName, d.DoObjektID, d.OdObjektID,d.tblPartnerID, t.TipNaKnizenje as TipNaKnizenje,d.KodNaDokument,D.UniqueIdPlacanje,D.DatumNaValuta,D.DatumPeriod,    
d.BrojNaDokument,d.Notes,     
ISNULL(p.Naziv,'N/A') as NazivPartner,    
ISNULL(p.Sifra,'N/A') as SifraPartner,    
ISNULL ((SELECT  SUM(DDVIznos) AS DDVIznos FROM    dbo.viewDokumentiStavki WHERE (tblDokumentID = d.ID)), 0) AS DDVIznos,    
ISNULL ((SELECT  SUM(DDVIznos) AS DDVIznos FROM    dbo.viewDokumentiStavki AS viewDokumentStavki_4  WHERE(tblDokumentID = d.ID) AND (DDVStapka = 18)), 0) AS DDVIznos18,     
ISNULL ((SELECT  SUM(DDVIznos) AS DDVIznos FROM    dbo.viewDokumentiStavki AS viewDokumentStavki_3 WHERE     (tblDokumentID = d.ID) AND (DDVStapka = 5)), 0) AS DDVIznos5,    
ISNULL ((SELECT  SUM(IznosBezDDV) AS IznosBezDDV FROM dbo.viewDokumentiStavki AS viewDokumentStavki_2 WHERE     (tblDokumentID = d.ID)), 0) AS IznosBezDDV,    
ISNULL ((SELECT  SUM(Iznos) AS IznosSoDDV   FROM dbo.viewDokumentiStavki AS viewDokumentStavki_1 WHERE     (tblDokumentID = d.ID)), 0) AS IznosSoDDV,    
t.Interen   
 from tblDokumenti d    
left outer join tblTipNaDokument t on t.ID = d.TipNaDokument    
left outer join tblObjekti do on do.ID = d.DoObjektID    
left outer join tblObjekti od on od.ID = d.OdObjektID    
left outer join tblUsers u on u.ID = d.tblUserID    
left outer join tblPartneri p on p.ID = d.tblPartnerID
GO
