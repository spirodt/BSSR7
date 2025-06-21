CREATE VIEW [dbo].[IzmenetiSmetki]
AS
SELECT     SI.ID, SI.Broj, SI.DatumPocetok, SI.DatumKraj, SI.tblSmetkaIzmenetaID, SI.tblUserID, SI.Smena_ID, SI.Zatvorena, SI.FirmaID, SI.ObjektID, SI.Zabeleska, SI.Izmeneta, SI.DatumNaIzmena, 
                      U.FullName AS FullName,
                          (SELECT DISTINCT Status
                            FROM          dbo.tblSmetkaStavkiIzmeneta
                            WHERE      (tblSmetkaID = SI.ID)
                            GROUP BY Status, DatumNaIzmena) AS TipNaIzmena
FROM         dbo.tblSmetkaIzmeneta AS SI LEFT OUTER JOIN
                      dbo.tblUsers AS U ON U.ID = SI.tblUserID