CREATE VIEW [dbo].[viewPriemStavki]
AS
SELECT     PS.ID, p.PriemBroj, PS.tblArtikalID, PS.tblPriemID, A.Naziv AS Artikal,a.AltSifra, E.Kratenka AS EDM, PS.Kolicina, D.Procent AS DDVStapka, PS.NabavnaCenaBezDDV, 
                      PS.NabavnaCenaSoDDV, 
                      ISNULL(PS.NabavnaCenaSoDDV - dbo.prCenaSoRabat(PS.NabavnaCenaBezDDV, PS.Rabat1 + PS.Rabat2 + PS.Rabat3), 0) 
                      * PS.Kolicina AS DDV, ISNULL(dbo.prCenaSoRabat(PS.NabavnaCenaBezDDV, PS.Rabat1 + PS.Rabat2 + PS.Rabat3) * PS.Kolicina, 0) AS IznosBezDDV, 
                      ISNULL(PS.NabavnaCenaSoDDV * PS.Kolicina, 0) AS IznosSoDDV,
                      PS.Rabat1, PS.Rabat2, PS.Rabat3,
                      A.ProdaznaCena as ProdaznaCena,
                      iSnull(PS.Kolicina * A.ProdaznaCena,0) as ProdaznaVrednostSoDDV,
                      (iSnull(PS.Kolicina * A.ProdaznaCena,0) - ISNULL(PS.NabavnaCenaSoDDV * PS.Kolicina, 0)) as Razlika,
					  isnull(A.NabavnaCena,0) as PlanskaCena, isnull( A.NabavnaCena * Kolicina ,0) as PlanskaVrednost, A.Sifra
                      
FROM         dbo.tblPriemStavki AS PS LEFT OUTER JOIN
                      dbo.tblArtikal AS A ON A.ID = PS.tblArtikalID LEFT OUTER JOIN
                      dbo.tblPriem AS p ON p.ID = PS.tblPriemID LEFT OUTER JOIN
                      dbo.tblEdinecniMerki AS E ON E.ID = A.tblEdinecniMerkiID LEFT OUTER JOIN
                      dbo.tblDDVStavka AS D ON D.ID = A.tblDDVStavkaID


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'viewPriemStavki';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'viewPriemStavki';


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
         Begin Table = "PS"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 210
               Right = 232
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "A"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 246
               Right = 249
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "p"
            Begin Extent = 
               Top = 6
               Left = 270
               Bottom = 126
               Right = 475
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "E"
            Begin Extent = 
               Top = 126
               Left = 287
               Bottom = 246
               Right = 447
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "D"
            Begin Extent = 
               Top = 246
               Left = 38
               Bottom = 366
               Right = 198
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
      Begin ColumnWidths = 17
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'viewPriemStavki';

