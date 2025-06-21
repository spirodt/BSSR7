CREATE view [dbo].[ListaNaDolznici] as 

SELECT
    p.Sifra,
	p.Naziv,
    doc.*
FROM tblPartneri p
CROSS APPLY 
(
    Select BrojNaDokument, 
	ROUND(IznosSoDDV,0) as IznosSoDDV,
	ROUND(isnull(dbo.PlatenoZaDokument(p.ID,doc.ID,doc.broj),0),0) as Plateno,
	(ROUND(IznosSoDDV,0) - ROUND(isnull(dbo.PlatenoZaDokument(p.ID,doc.ID,doc.broj),0),0)) as Saldo
	from viewDokumenti doc
	Where p.ID = doc.tblPartnerID
) doc