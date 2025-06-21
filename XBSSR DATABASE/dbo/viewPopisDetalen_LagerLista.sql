CREATE view [dbo].[viewPopisDetalen_LagerLista] as  
select A.*, dbo.ProsecnaNabavnaCena(a.tblArtikalID) as prosecnaNabavnaCena, art.ProdaznaCena  from   
(select tblArtikalID, AltSifraArtikal, Naziv, 
SUM(KolicinaVlez) as KolicinaVlez,
SUM(KolicinaIzlez) as KolicinaIzlez,
SUM(PreostanataKolicinaNaZaliha) as PreostanataKolicina,
Kratenka
from viewZaliha  
Group by tblArtikalID, AltSifraArtikal, Naziv, Kratenka) as A  
left outer join tblArtikal art on art.ID = a.tblArtikalID