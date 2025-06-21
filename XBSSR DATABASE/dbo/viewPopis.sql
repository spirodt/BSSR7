CREATE view  [dbo].[viewPopis] as
select A.*, dbo.ProsecnaNabavnaCena(a.tblArtikalID) as prosecnaNabavnaCena, art.ProdaznaCena  from 
(select tblArtikalID, AltSifraArtikal, Naziv, SUM(PreostanataKolicinaNaZaliha) as PreostanataKolicina from viewZaliha
Group by tblArtikalID, AltSifraArtikal, Naziv) as A
left outer join tblArtikal art on art.ID = a.tblArtikalID
