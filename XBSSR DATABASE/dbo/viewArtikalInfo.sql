
CREATE     view  [dbo].[viewArtikalInfo] as 
select 
A.ID, 

A.Sifra, 
A.AltSifra, 
A.Naziv, 
A.NabavnaCena as PlanskaCena,
A.ProdaznaCena, 
edm.Kratenka,
ddv.Procent as DDVProcent,
CAST(ISNULL(A.ProdaznaCena / (ddv.Procent / 100 + 1), 0) AS decimal(18, 4)) as ProdaznaCenaBezDDV, 
A.tblDDVStavkaID,
A.tblEdinecniMerkiID
from tblArtikal A
left join tblDDVStavka ddv on ddv.ID = a.tblDDVStavkaID
left join tblEdinecniMerki edm on edm.ID = a.tblEdinecniMerkiID

--select * from viewArtikalInfo