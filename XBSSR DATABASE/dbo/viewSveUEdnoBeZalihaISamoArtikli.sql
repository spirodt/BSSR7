

CREATE VIEW [dbo].[viewSveUEdnoBeZalihaISamoArtikli] AS
SELECT Cela.*,ISNULL(dbo.MomentalZalihaZaArtikal(Cela.ID),0) AS MomentalZaliha FROM (SELECT     tblArtikal.ID, tblArtikal.Sifra, ISNULL(tblArtikal.AltSifra, '') AS AltSifra, GR.Naziv AS GrupaNaziv, PoD.Naziv AS PodGrupaNaziv, ISNULL(tblArtikal.Status, 0) 
AS Status, tblArtikal.Naziv,   
                      tblArtikal.KlucniZborovi, tblArtikal.ProdaznaCena, 'false' AS Normativ, tblArtikal.FirmaID, tblPodgrupaID.ID AS PodgrupaID, tblDDVStavka.ID AS DDV, tblDDVStavka.Procent AS DDVStapka,   
                      tblEdinecniMerki.Kratenka AS EDM, (ISNULL(tblArtikal.Sifra, '') + ' ' + ISNULL(tblArtikal.AltSifra, '') + ' ' + ISNULL(tblArtikal.AltNaziv, '') + ' ' + ISNULL(tblArtikal.AltNaziv2, '') + ' ' + ISNULL(tblArtikal.KlucniZborovi,   
                      '')) AS SearchString, tblArtikal.Barkod1 AS Barkod  
FROM         tblArtikal LEFT OUTER JOIN  
                      tblPodgrupaID ON tblPodgrupaID.ID = tblArtikal.PodgrupaID LEFT OUTER JOIN  
                      tblDDVStavka ON tblDDVStavka.ID = tblArtikal.tblDDVStavkaID LEFT OUTER JOIN  
                      tblEdinecniMerki ON tblEdinecniMerki.ID = tblArtikal.tblEdinecniMerkiID LEFT OUTER JOIN  
                      tblPodgrupaID PoD ON PoD.ID = tblArtikal.PodgrupaID LEFT OUTER JOIN  
                      tblGrupaNaArtikli GR ON GR.ID = PoD.GrupaID  
WHERE     (tblArtikal.Status IS NULL OR  
                      tblArtikal.Status <> 1)) as Cela 


