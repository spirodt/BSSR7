CREATE PROCEDURE getDataversionChanges  
(  
 @tableName NVARCHAR(max)  
)   
AS  
BEGIN  
  
 EXEC('SELECT DISTINCT dataversion,ID FROM ' + @tableName)  
  
END