CREATE VIEW [dbo].[viewFakturiStavki]
AS
SELECT     FS.ID, FS.tblFakturaID, F.Broj, FS.tblArtikalID, F.Datum,a.Sifra as Sifra,A.AltSifra as AltSifa ,  A.Naziv AS Artikal, A.ProdaznaCena, D.Procent AS DDV, A.EDM, FS.Kolicina, CAST(ISNULL(FS.Iznos - FS.Iznos / (D.Procent / 100 + 1), 0)   
                      AS decimal(18, 2)) AS DDVIznos,
					   CAST(ISNULL(FS.Iznos / (D.Procent / 100 + 1), 0) AS decimal(18, 2)) AS IznosBezDDV
					  , FS.Iznos, FS.Rabat3, FS.Rabat2, FS.Rabat1,
					   CAST((Iznos / Kolicina) as decimal(18,2)) as ProdaznaCenaSoDDVIRabat,
					   CAST((CAST(ISNULL(FS.Iznos / (D.Procent / 100 + 1), 0) AS decimal(18, 2)) / Kolicina) as decimal(18,2)) as ProdaznaCenaBezDDVIRabat
					   ,a.Barkod  
FROM         dbo.tblFakturaStavki AS FS LEFT OUTER JOIN  
                      dbo.viewSveUEdno AS A ON A.ID = FS.tblArtikalID AND A.Normativ = FS.Normativ LEFT OUTER JOIN  
                      dbo.tblFaktura AS F ON F.ID = FS.tblFakturaID LEFT OUTER JOIN  
                      dbo.tblDDVStavka AS D ON D.ID = A.DDV




GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'viewFakturiStavki';


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
         Begin Table = "FS"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 168
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "F"
            Begin Extent = 
               Top = 6
               Left = 450
               Bottom = 126
               Right = 615
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "D"
            Begin Extent = 
               Top = 6
               Left = 653
               Bottom = 126
               Right = 813
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "A"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 126
               Right = 396
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'viewFakturiStavki';

