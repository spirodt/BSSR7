CREATE VIEW [dbo].[viewPriemi]
AS
SELECT     p.ID, p.PriemBroj, p.PriemDatum, p.tblPartnerID, P.KodNaDokument, p.tblUserID, p.ObjektID, p.ValutaDenovi, p.KalkulacijaBroj, p.Zabeleska, par.Naziv AS Dobavuvac, o.Naziv AS Objekt, u.FullName AS UserFullName, par.Sifra as SifraPartner,
                      ISNULL
                          ((SELECT     SUM(DDV) AS DDVIznos
                              FROM         dbo.viewPriemStavki
                              WHERE     (tblPriemID = p.ID)), 0) AS DDVIznos, ISNULL
                          ((SELECT     SUM(DDV) AS DDVIznos
                              FROM         dbo.viewPriemStavki AS viewPriemStavki_4
                              WHERE     (tblPriemID = p.ID) AND (DDVStapka = 18)), 0) AS DDVIznos18, ISNULL
                          ((SELECT     SUM(DDV) AS DDVIznos
                              FROM         dbo.viewPriemStavki AS viewPriemStavki_3
                              WHERE     (tblPriemID = p.ID) AND (DDVStapka = 5)), 0) AS DDVIznos5, ISNULL
                          ((SELECT     SUM(IznosBezDDV) AS IznosBezDDV
                              FROM         dbo.viewPriemStavki AS viewPriemStavki_2
                              WHERE     (tblPriemID = p.ID)), 0) AS IznosBezDDV, ISNULL
                          ((SELECT     SUM(IznosSoDDV) AS IznosSoDDV
                              FROM         dbo.viewPriemStavki AS viewPriemStavki_1
                              WHERE     (tblPriemID = p.ID)), 0) AS IznosSoDDV, ISNULL
                          ((SELECT     ROUND(SUM(IznosSoDDV), 0) AS IznosSoDDV
                              FROM         dbo.viewPriemStavki AS viewPriemStavki_1
                              WHERE     (tblPriemID = p.ID)), 0) AS IznosSoDDVZaokruzeno, ISNULL
                          ((SELECT     ROUND(SUM(ProdaznaVrednostSoDDV), 0) AS ProdaznaVrednostSoDDV
                              FROM         dbo.viewPriemStavki AS viewPriemStavki_9
                              WHERE     (tblPriemID = p.ID)), 0) AS ProdaznaVrednostSoDDV, p.IspratnicaFakturaBroj, p.IspratnicaFakturaDatum, p.VkupenIznos, p.DatumNaDospeanost, p.DatumNaKreiranjeNaPriem
FROM         dbo.tblPriem AS p LEFT OUTER JOIN
                      dbo.tblPartneri AS par ON par.ID = p.tblPartnerID LEFT OUTER JOIN
                      dbo.tblObjekti AS o ON o.ID = p.ObjektID LEFT OUTER JOIN
                      dbo.tblUsers AS u ON u.ID = p.tblUserID



GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'viewPriemi';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'viewPriemi';


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
         Begin Table = "p"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 243
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "par"
            Begin Extent = 
               Top = 6
               Left = 281
               Bottom = 125
               Right = 441
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "o"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 245
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "u"
            Begin Extent = 
               Top = 126
               Left = 236
               Bottom = 245
               Right = 425
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
      Begin ColumnWidths = 16
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
         ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'viewPriemi';

