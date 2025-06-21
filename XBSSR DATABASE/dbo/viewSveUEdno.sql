

CREATE VIEW [dbo].[viewSveUEdno] AS
SELECT Cela.* FROM (SELECT     tblArtikal.ID, tblArtikal.Sifra, ISNULL(tblArtikal.AltSifra, '') AS AltSifra, GR.Naziv AS GrupaNaziv, PoD.Naziv AS PodGrupaNaziv, ISNULL(tblArtikal.Status, 0) AS Status, tblArtikal.Naziv, 
                      tblArtikal.KlucniZborovi, tblArtikal.ProdaznaCena, 'false' AS Normativ, tblArtikal.FirmaID, tblPodgrupaID.ID AS PodgrupaID, tblDDVStavka.ID AS DDV, tblDDVStavka.Procent AS DDVStapka, 
                      tblEdinecniMerki.Kratenka AS EDM, (ISNULL(tblArtikal.Sifra, '') + ' ' + ISNULL(tblArtikal.AltSifra, '') + ' ' + ISNULL(tblArtikal.AltNaziv, '') + ' ' + ISNULL(tblArtikal.AltNaziv2, '') + ' ' + ISNULL(tblArtikal.KlucniZborovi, 
                      '')) AS SearchString, tblArtikal.Barkod1 AS Barkod,dbo.getMomentalnaZalihaNaArtikal(tblArtikal.ID) AS MomentalZaliha
FROM         tblArtikal LEFT OUTER JOIN
                      tblPodgrupaID ON tblPodgrupaID.ID = tblArtikal.PodgrupaID LEFT OUTER JOIN
                      tblDDVStavka ON tblDDVStavka.ID = tblArtikal.tblDDVStavkaID LEFT OUTER JOIN
                      tblEdinecniMerki ON tblEdinecniMerki.ID = tblArtikal.tblEdinecniMerkiID LEFT OUTER JOIN
                      tblPodgrupaID PoD ON PoD.ID = tblArtikal.PodgrupaID LEFT OUTER JOIN
                      tblGrupaNaArtikli GR ON GR.ID = PoD.GrupaID
WHERE     (tblArtikal.Status IS NULL OR
                      tblArtikal.Status <> 1)
UNION ALL
SELECT     tblNormativ.ID, tblNormativ.Sifra, 'N/A' AS AltSifra, GR.Naziv AS GrupaNaziv, PoD.Naziv AS PodGrupaNaziv, ISNULL(tblNormativ.Status, 2) AS Status, tblNormativ.Naziv, tblNormativ.KlucniZborovi, 
                      tblNormativ.Cena, 'true' AS Normativ, tblNormativ.FirmaID, tblPodgrupaID.ID AS PodgrupaID, tblDDVStavka.ID AS DDV, tblDDVStavka.Procent AS DDVStapka, 'KOM' AS EDM, (ISNULL(tblNormativ.Sifra, 
                      '') + ' ' + ISNULL(tblNormativ.AltNaziv, '') + ' ' + ISNULL(tblNormativ.AltNaziv2, '') + ' ' + ISNULL(tblNormativ.KlucniZborovi, '')) AS SearchString, '' AS Barkod, dbo.getMomentalnaZalihaNaArtikal(dbo.tblNormativ.ID) AS MomentalZaliha
FROM         tblNormativ LEFT OUTER JOIN
                      tblPodgrupaID ON tblPodgrupaID.ID = tblNormativ.PodgrupaID LEFT OUTER JOIN
                      tblDDVStavka ON tblDDVStavka.ID = tblNormativ.tblDDVStavkaID LEFT OUTER JOIN
                      tblPodgrupaID PoD ON PoD.ID = tblNormativ.PodgrupaID LEFT OUTER JOIN
                      tblGrupaNaArtikli GR ON GR.ID = PoD.GrupaID
WHERE     (tblNormativ.Status IS NULL OR
                      tblNormativ.Status <> 1)) AS Cela


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'viewSveUEdno';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'viewSveUEdno';

