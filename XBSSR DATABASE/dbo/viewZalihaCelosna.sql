CREATE VIEW [dbo].[viewZalihaCelosna]
AS
SELECT     tblArtikalID, Naziv, ProdaznaCena, Kratenka AS EdinecnaMerkaVlez, EdinecnaMerkaIzlez, SUM(IznosBezDDV) AS IznosBezDDV, SUM(IznosDDV) AS IznosDDV, SUM(IznosSoDDV) AS IznosSoDDV, 
                      SUM(KolicinaPoMerkaIzlez) AS IzdadenaKolicina, SUM(KolicinaIzlez) AS KolicinaIzlez, SUM(KolicinaVlez) AS KolicinaVlez, SUM(KolicinaZaliha) AS KolicinaZaliha, 
                      dbo.PartnerOdPriemPosledenArtikal(tblArtikalID) AS Partner, AltSifraArtikal,PreostanataKolicinaNaZaliha
FROM         dbo.viewZaliha
GROUP BY tblArtikalID, Naziv, ProdaznaCena, Kratenka, EdinecnaMerkaIzlez,AltSifraArtikal,PreostanataKolicinaNaZaliha



