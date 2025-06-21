
CREATE view [dbo].[viewDospeaniFakturi] As
select A.TipNaDokument, A.ID, A.tblPartnerID, A.Broj,A.BrojNaFakturaSporedPartner,A.Valuta, A.Datum,A.DocNaziv,A.SifraPartner, a.NazivPartner, 
 ISNULL(A.IznosNaDokument,0) as IznosNaDokument,
(ISNULL(A.IznosNaDokument,0) - ISNULL(A.PlatenoZaDokument,0)) as PreostanatoZaPlacanje,
ISNULL(A.PlatenoZaDokument,0) as  PlatenoZaDokument

from 
(
	 select 2 as TipNaDokument, f.ID,f.tblPartnerID, f.Broj,f.BrojNaFakturaSporedPartner, f.Valuta, f.Datum, SUM(f.Iznos) as IznosNaDokument, dbo.PlatenoZaDokument( f.tblPartnerID, f.ID, f.Broj) as PlatenoZaDokument,
	 p.Sifra as SifraPartner, p.Naziv as NazivPartner, 
	 ( 'Фактура број : ' +  CAST(f.Broj as nvarchar(20))) as DocNaziv
	from viewFakturi f
	left outer join tblPartneri p on p.ID = f.tblPartnerID
	where f.ID in (select tblFakturaID from tblKnizenjeM)
	group by  f.ID,f.tblPartnerID, f.Broj,f.BrojNaFakturaSporedPartner, f.Datum,f.Valuta,p.Sifra, p.Naziv
 ) as A
 
--select * from viewDospeaniFakturi
