CREATE VIEW [dbo].[viewArtikliVoSmetkaIzmeneta]
AS
SELECT     SmetkaID, Naziv, Kolicina, Iznos, ProdaznaCena, Sifra, Artikal, Tip
FROM         (SELECT     NA.SmetkaID, SUM(NS.Kolicina) AS Kolicina, A.ID AS Artikal, A.Sifra, A.Naziv, A.ProdaznaCena, A.ProdaznaCena * SUM(NS.Kolicina) AS Iznos, 0 AS Tip
                       FROM          dbo.tblNalogStavkiIzmeneta AS NS LEFT OUTER JOIN
                                              dbo.tblArtikal AS A ON A.ID = NS.tblArtikalID LEFT OUTER JOIN
                                              dbo.tblNalogIzmeneta AS NA ON NA.ID = NS.tblNalogIzmenetaID
                       WHERE      (NS.tblArtikalID IS NOT NULL)
                       GROUP BY A.ID, A.Sifra, A.Naziv, A.ProdaznaCena, NA.SmetkaID
                       UNION
                       SELECT     NA.SmetkaID, SUM(NS.Kolicina) AS Kolicina, N.ID AS Artikal, N.Sifra, N.Naziv, N.Cena, N.Cena * SUM(NS.Kolicina) AS Iznos, 1 AS Tip
                       FROM         dbo.tblNalogStavkiIzmeneta AS NS LEFT OUTER JOIN
                                             dbo.tblNormativ AS N ON N.ID = NS.tblNomativID LEFT OUTER JOIN
                                             dbo.tblNalogIzmeneta AS NA ON NA.ID = NS.tblNalogIzmenetaID
                       WHERE     (NS.tblNomativID IS NOT NULL)
                       GROUP BY N.ID, N.Sifra, N.Naziv, N.Cena, NA.SmetkaID) AS ArtikliNalog