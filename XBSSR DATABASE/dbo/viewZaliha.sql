CREATE VIEW [dbo].[viewZaliha]
AS
SELECT     z.ID, z.DatumNaKnizenje, z.DatumNaPocetok, z.tblArtikalID, d.Procent AS DDVStapka, e.Kratenka AS EdinecnaMerkaIzlez, z.Naziv, z.Kratenka, z.EdinecnaCena, z.IznosBezDDV, z.IznosDDV,Z.KodNaDokument,     
                      z.IznosSoDDV, z.NabavnaCena, (z.NabavnaCena * z.Kolicina) AS NabavenIznosBezDDV  , z.ProdaznaCena, z.SmetkaBroj, z.PriemBroj, z.fakturaBroj, Nor.Naziv AS NormativNaziv,z.DokumentBroj,z.tblSmetkaID,    
                          
                       ISNULL    
                          ((SELECT     ISNULL(SUM(Kolicina), 0) AS Expr1    
                              FROM         dbo.viewKnzienjaM AS viewKnzienjaM_3    
                              WHERE     (tipNaKnizenje = 1 OR    
                                                    tipNaKnizenje = 2) AND (tblArtikalID = z.tblArtikalID) AND (z.DatumNaKnizenje = DatumNaKnizenje) AND (z.ID = ID)    
                              GROUP BY DatumNaKnizenje), 0) AS KolicinaPoMerkaIzlez, ISNULL    
                          ((SELECT     ISNULL(SUM(Kolicina), 0) AS Expr1    
                              FROM         dbo.viewKnzienjaM    
                              WHERE     (tipNaKnizenje = 3) AND (tblArtikalID = z.tblArtikalID) AND (z.DatumNaKnizenje = DatumNaKnizenje) AND (z.ID = ID)    
                              GROUP BY DatumNaKnizenje), 0) AS KolicinaVlez, ISNULL    
                          ((SELECT     ISNULL(SUM(Kolicina), 0) AS Expr1    
                              FROM         dbo.viewKnzienjaM AS viewKnzienjaM_3    
                              WHERE     (tipNaKnizenje = 1 OR    
                                                    tipNaKnizenje = 2 OR tipNaKnizenje = -1) AND (tblArtikalID = z.tblArtikalID) AND (z.DatumNaKnizenje = DatumNaKnizenje) AND (z.ID = ID)    
                              GROUP BY DatumNaKnizenje), 0) * A.KolicinaT AS KolicinaIzlez, ISNULL    
                          ((SELECT     ISNULL(SUM(Kolicina), 0) AS Expr1    
                              FROM         dbo.viewKnzienjaM AS viewKnzienjaM_2    
                              WHERE     (tipNaKnizenje = 3) AND (tblArtikalID = z.tblArtikalID) AND (z.DatumNaKnizenje = DatumNaKnizenje) AND (z.ID = ID)    
                              GROUP BY DatumNaKnizenje), 0) - ISNULL    
                          ((SELECT     ISNULL(SUM(Kolicina), 0) AS Expr1    
                              FROM         dbo.viewKnzienjaM AS viewKnzienjaM_1    
                              WHERE     (tipNaKnizenje = 1 OR    
                                                    tipNaKnizenje = 2) AND (tblArtikalID = z.tblArtikalID) AND (DatumNaKnizenje = z.DatumNaKnizenje) AND (z.ID = ID)    
                              GROUP BY DatumNaKnizenje), 0) * A.KolicinaT AS KolicinaZaliha, z.VrabotenKojJaIzdalSmetkata, dbo.DaliImaFiskalna(z.tblSmetkaID) AS OtpecatenaFiskalna, z.tipNaKnizenje, z.AltSifraArtikal,z.Sifra,    
                              ISNULL    
                          ((SELECT     ISNULL(SUM(Kolicina), 0) AS Expr1    
                              FROM         dbo.viewKnzienjaM AS viewKnzienjaM_2    
                              WHERE     (tipNaKnizenje = 3) AND (tblArtikalID = z.tblArtikalID) AND (z.DatumNaKnizenje = DatumNaKnizenje) AND (z.ID = ID)    
                              GROUP BY DatumNaKnizenje), 0) - ISNULL    
                          ((SELECT     ISNULL(SUM(Kolicina), 0) AS Expr1    
                              FROM         dbo.viewKnzienjaM AS viewKnzienjaM_1    
                              WHERE     (tipNaKnizenje = 1 OR    
                                                    tipNaKnizenje = 2 OR    
                                                    tipNaKnizenje = -1) AND (tblArtikalID = z.tblArtikalID) AND (DatumNaKnizenje = z.DatumNaKnizenje) AND (z.ID = ID)    
                              GROUP BY DatumNaKnizenje), 0) /  ISNULL( A.KolicinaT /NULLIF( A.KolicinaT ,0),1) AS PreostanataKolicinaNaZaliha    
FROM         dbo.viewKnzienjaM AS z LEFT OUTER JOIN    
           dbo.tblArtikal AS A ON A.ID = z.tblArtikalID LEFT OUTER JOIN    
             dbo.tblEdinecniMerki AS e ON e.ID = A.EDMIzlez LEFT OUTER JOIN    
                      dbo.tblDDVStavka AS d ON d.ID = A.tblDDVStavkaID LEFT OUTER JOIN    
                      dbo.tblNormativ AS Nor ON Nor.ID = z.tblNormativID    


GO
