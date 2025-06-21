CREATE PROCEDURE [dbo].[GetAllDataForSmetkiFrom] (      
 @Start DATETIME,
 @End DATETIME        
)      
AS       
BEGIN      
   SELECT  * INTO #tblSmetkaTMP  FROM  dbo.tblSmetka WHERE DatumPocetok BETWEEN @Start AND @End
  
  SELECT * INTO #tmpNalog FROM dbo.tblNalog WHERE SmetkaID IN (SELECT ID FROM #tblSmetkaTMP)  
  
  SELECT * FROM #tblSmetkaTMP  
  
  SELECT * FROM #tmpNalog  
  
  SELECT * FROM dbo.tblNalogStavki WHERE tblNalogID IN ( SELECT ID FROM #tmpNalog )  
  
  SELECT * FROM dbo.tblSmetkaStavki WHERE tblSmetkaID IN (SELECT ID FROM #tblSmetkaTMP)  
  
  SELECT * FROM dbo.tblFiskalniSmetki WHERE tblSmetkaID IN (SELECT ID FROM #tblSmetkaTMP)  
      
END