



CREATE view [dbo].[viewIzvodiStavki] as 
select s.ID, s.tblIzvodiID,I.BrojNaIzvod, I.DatumNaIzvod , s.PartnerID, 
SUM(s.Dolzi) as Dolzi, SUM(s.Pobaruva) as Pobaruva, p.Sifra as SifraPartner, p.Naziv as NazivPartner,
(CASE 
WHEN isnull(s.DokumentID,0) <> 0 THEN isnull((select SUM(IznosSoDDV) from viewDokumenti where ID = S.DokumentID),0) 
 WHEN isnull(s.FakturaID,0) <> 0 THEN  isnull((select SUM(Iznos) from viewFakturi where ID = S.FakturaID),0) 
 WHEN isnull(s.PriemID,0) <> 0 THEN isnull((select SUM(IznosSoDDV) from viewPriemi where ID = S.PriemID),0) 
 END) as IznosDokument,
(CASE 
WHEN isnull(s.DokumentID,0) <> 0 THEN  s.DokumentID
 WHEN isnull(s.FakturaID,0) <> 0 THEN  s.FakturaID
 WHEN isnull(s.PriemID,0) <> 0 THEN s.PriemID
 END) as DokumentID,
 s.TipNaDokument, s.BrojNaDokument
from tblIzvodiStavki s
left outer join tblPartneri p on p.ID = s.PartnerID
left outer join tblIzvodi i on i.ID = s.tblIzvodiID

Group by s.ID,I.BrojNaIzvod, I.DatumNaIzvod, s.tblIzvodiID, s.PartnerID, s.TipNaDokument, s.BrojNaDokument,s.DokumentID, s.PriemID,s.FakturaID,p.Sifra, p.Naziv





