CREATE view viewIzvodi as
select i.ID, i.BrojNaIzvod, i.DatumNaIzvod, i.Smetka,i.Zabeleska, doc.BrojNaDokument ,
p.Sifra as SifraPartner, P.Naziv as NazivPartner,
 SUM(s.Dolzi) as Dolzi, Sum(s.Pobaruva) as Pobaruva
 from tblIzvodi  i   
left outer join tblIzvodiStavki s on s.tblIzvodiID = i.ID  
left outer join tblPartneri p on p.ID = s.PartnerID 
left outer join viewDokumenti doc on (doc.ID = FakturaID OR doc.ID  = DokumentID ) AND doc.tblPartnerID = s.PartnerID
group by  i.ID, i.BrojNaIzvod, i.DatumNaIzvod, i.Smetka,i.Zabeleska,doc.BrojNaDokument, s.PartnerID, p.Naziv, p.Sifra  
