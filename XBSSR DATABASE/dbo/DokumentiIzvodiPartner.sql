
CREATE   FUNCTION DokumentiIzvodiPartner 
(	
	 @Site int = 0,
     @DatumOd date = '2024-01-01',
     @DatumDo date = '2024-01-31'
)
RETURNS TABLE 
AS
RETURN 
(
	select  P.Sifra,P.Naziv, CAST(plDodc.Datum as date) Datum,doc.DatumPeriod, plDodc.DocNaziv, plDodc.IznosNaDokument, plDodc.PlatenoZaDokument, 
	plDodc.PreostanatoZaPlacanje 
	from  
	[dbo].[viewDokumentiZaPlakjanaOdPartnerPoDokument] plDodc
	left join tblPartneri p on p.ID = tblPartnerID
	left join tblDokumenti doc on doc.ID = plDodc.ID
	where (PreostanatoZaPlacanje > 0  OR @Site = 1)
	AND CAST(doc.DatumPeriod as date) BETWEEN @DatumOd and @DatumDo 
	Group by P.Sifra,P.Naziv, plDodc.DocNaziv, plDodc.Datum,doc.DatumPeriod, IznosNaDokument, PlatenoZaDokument, PreostanatoZaPlacanje
   --select * from dbo.DokumentiIzvodiPartner(0,'2024-01-01','2024-01-31')
)