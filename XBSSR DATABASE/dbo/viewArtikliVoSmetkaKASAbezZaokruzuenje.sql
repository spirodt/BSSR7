CREATE view [dbo].[viewArtikliVoSmetkaKASAbezZaokruzuenje] as  
SELECT     ArtikliNalog.Artikal AS ArtikalID,
		   ArtikliNalog.Sifra,
		   ArtikliNalog.Sifra2,
		   ArtikliNalog.Naziv,
		   ArtikliNalog.Kolicina,
		   ArtikliNalog.Rabat,
		   ArtikliNalog.ProdaznaCena,   
           (ArtikliNalog.ProdaznaCena - ArtikliNalog.ProdaznaCena / 100 * ArtikliNalog.Rabat) AS CenaSoRabatIddv,
           ((ArtikliNalog.ProdaznaCena - ArtikliNalog.ProdaznaCena / 100 * ArtikliNalog.Rabat) / (1 + DDV.Procent / 100)) AS CenaBezDDV,
			DDV.Procent AS DDVProcent, 
	       (( (ArtikliNalog.ProdaznaCena - ArtikliNalog.ProdaznaCena / 100 * ArtikliNalog.Rabat) - (ArtikliNalog.ProdaznaCena - ArtikliNalog.ProdaznaCena / 100 * ArtikliNalog.Rabat) / (1 + DDV.Procent / 100)) * ArtikliNalog.Kolicina) AS PresmetanDDV,   
           ((ArtikliNalog.ProdaznaCena - (ArtikliNalog.ProdaznaCena / 100 * ArtikliNalog.Rabat)) * ArtikliNalog.Kolicina) AS Iznos,   
           ((ArtikliNalog.ProdaznaCena - ArtikliNalog.ProdaznaCena / 100 * ArtikliNalog.Rabat) / (1 + DDV.Procent / 100) * ArtikliNalog.Kolicina) AS IznosBezDDV,
		   ArtikliNalog.NalogID,
		   ArtikliNalog.Tip,   
           Nal.Zabeleska,
		   Nal.SmetkaID,
		   DDV.ID AS Danok,
		   ArtikliNalog.MkProizvod  
FROM         (  
SELECT     NS.tblNalogID AS NalogID, SUM(NS.Kolicina) AS Kolicina, A.ID AS Artikal, ISNULL(NS.Rabat1, 0) AS Rabat, A.Sifra, A.AltSifra AS Sifra2, A.Naziv, A.ProdaznaCena,   
                                              A.ProdaznaCena * SUM(NS.Kolicina) AS Iznos, 0 AS Tip, A.tblDDVStavkaID AS DDVID, DomasenProizvod as MkProizvod  
                       FROM          dbo.tblNalogStavki AS NS LEFT OUTER JOIN  
                                              dbo.tblArtikal AS A ON A.ID = NS.tblArtikalID  
                       WHERE      (NS.tblArtikalID IS NOT NULL)  
                       GROUP BY NS.tblNalogID, A.ID, A.Sifra, A.Naziv, A.ProdaznaCena, A.tblDDVStavkaID, NS.Rabat1, A.AltSifra, A.DomasenProizvod   
                       UNION ALL  
                       SELECT     NS.tblNalogID AS NalogID, SUM(NS.Kolicina) AS Kolicina, N.ID AS Artikal, ISNULL(NS.Rabat1, 0) AS Rabat, N.Sifra, '' AS Sifra2, N.Naziv, N.Cena, N.Cena * SUM(NS.Kolicina) AS Iznos,   
                                             1 AS Tip, N.tblDDVStavkaID AS DDVID, 'true' as MkProizvod  
                       FROM         dbo.tblNalogStavki AS NS LEFT OUTER JOIN  
                                             dbo.tblNormativ AS N ON N.ID = NS.tblNomativID  
                       WHERE     (NS.tblNomativID IS NOT NULL)  
                       GROUP BY NS.tblNalogID, N.ID, N.Sifra, N.Naziv, N.Cena, N.tblDDVStavkaID, NS.Rabat1) AS ArtikliNalog LEFT OUTER JOIN  
                      dbo.tblNalog AS Nal ON Nal.ID = ArtikliNalog.NalogID AND Nal.ID = ArtikliNalog.NalogID LEFT OUTER JOIN  
                      dbo.tblDDVStavka AS DDV ON DDV.ID = ArtikliNalog.DDVID

