CREATE VIEW [dbo].[viewFakturi]
AS
SELECT     F.ID, F.Broj ,dbo.BrojNaFakturaSporedPartner(F.tblPartnerID,f.ID) as BrojNaFakturaSporedPartner , F.Datum, F.Valuta,  P.Naziv AS Partner, Z.ZiroSmetka,F.KodNaDokument ,B.Naziv AS Banka,f.ListaNaIspratnici, 
ISNULL ((SELECT     SUM(DDVIznos) AS Expr1 FROM         dbo.viewFakturiStavki WHERE     (tblFakturaID = F.ID)), 0) AS FakturiranDDV, 
ISNULL ((SELECT     SUM(IznosBezDDV) AS Expr1 FROM         dbo.viewFakturiStavki AS viewFakturiStavki_2 WHERE     (tblFakturaID = F.ID)), 0) AS IznosBezDDV, 
ISNULL ((SELECT     SUM(Iznos) AS Expr1 FROM  dbo.viewFakturiStavki AS viewFakturiStavki_1 WHERE (tblFakturaID = F.ID)), 0) AS Iznos,
 F.tblPartnerID, f.Zabeleska, P.Sifra as SifraPartner,
 ISNULL ((SELECT     SUM(DDVIznos) AS Expr1 FROM  dbo.viewFakturiStavki AS viewFakturiStavki_1 WHERE (tblFakturaID = F.ID and DDV = 18)), 0) AS DDV18,
 ISNULL ((SELECT     SUM(DDVIznos) AS Expr1 FROM  dbo.viewFakturiStavki AS viewFakturiStavki_1 WHERE (tblFakturaID = F.ID and DDV = 5)), 0) AS DDV5

FROM         dbo.tblFaktura AS F LEFT OUTER JOIN
                      dbo.tblPartneri AS P ON P.ID = F.tblPartnerID LEFT OUTER JOIN
                      dbo.tblZiroSmetki AS Z ON Z.ID = F.tblZiroSmetkaID LEFT OUTER JOIN
                      dbo.tblBanki AS B ON B.ID = Z.tblBankaID










GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'viewFakturi';


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
         Begin Table = "F"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 203
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "P"
            Begin Extent = 
               Top = 6
               Left = 241
               Bottom = 126
               Right = 401
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Z"
            Begin Extent = 
               Top = 6
               Left = 439
               Bottom = 126
               Right = 599
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 6
               Left = 637
               Bottom = 126
               Right = 797
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'viewFakturi';

