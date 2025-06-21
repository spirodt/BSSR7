
CREATE VIEW [dbo].[viewArtikli]
AS
SELECT Cela.* from (SELECT     A.ID, A.Sifra, A.Naziv AS NazivArtikal, A.NabavnaCena, A.ProdaznaCena, PG.Naziv AS PodGrupaArtikal, g.Naziv AS GrupaArtikal, DDV.Naziv, DDV.Procent, A.AltSifra, A.AltNaziv, A.FirmaID, 
                      EM.Kratenka AS EDM, A.Image, A.MinimalnaKolicinaNaZaliha, A.KolicinaT, A.Status, A.EDMIzlez, A.RedenBroj, A.Barkod1, A.Barkod2, A.AltNaziv2, A.SePecatiVoKujna, A.SePacatiNaSank, 
                      A.DenoviZaGarancija,0 as MomentalZaliha
FROM         dbo.tblArtikal AS A LEFT OUTER JOIN
                      dbo.tblDDVStavka AS DDV ON DDV.ID = A.tblDDVStavkaID LEFT OUTER JOIN
                      dbo.tblPodgrupaID AS PG ON PG.ID = A.PodgrupaID LEFT OUTER JOIN
                      dbo.tblGrupaNaArtikli AS g ON g.ID = PG.GrupaID LEFT OUTER JOIN
                      dbo.tblEdinecniMerki AS EM ON EM.ID = A.tblEdinecniMerkiID)as Cela

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'viewArtikli';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N't = 720
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'viewArtikli';


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
         Begin Table = "A"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 252
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 12
         End
         Begin Table = "DDV"
            Begin Extent = 
               Top = 6
               Left = 252
               Bottom = 126
               Right = 412
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PG"
            Begin Extent = 
               Top = 6
               Left = 450
               Bottom = 165
               Right = 610
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "g"
            Begin Extent = 
               Top = 6
               Left = 648
               Bottom = 126
               Right = 808
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "EM"
            Begin Extent = 
               Top = 6
               Left = 846
               Bottom = 126
               Right = 1006
            End
            DisplayFlags = 280
            TopColumn = 0
         End
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
         Outpu', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'viewArtikli';

