CREATE PROCEDURE GetUpdatesForTableFromServer (  
 @tablename  NVARCHAR(max),  
 @idsIn NVARCHAR(max)  
)  
AS   
BEGIN  
  
 EXEC ( 'SELECT * from ' + @tablename + ' Where id IN (' + @idsIn + ')')  
  
END