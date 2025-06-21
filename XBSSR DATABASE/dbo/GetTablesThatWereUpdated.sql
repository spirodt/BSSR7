CREATE PROCEDURE GetTablesThatWereUpdated    
(    
 @dateTimeFrom DATETIME,    
 @TablesIn NVARCHAR(max)    
)    
AS     
BEGIN    
 SELECT    
 DISTINCT    
 tbl.name,    
 ius.last_user_update    
 FROM    
 sys.dm_db_index_usage_stats ius INNER JOIN    
 sys.tables tbl ON (tbl.OBJECT_ID = ius.OBJECT_ID)    
 WHERE ius.database_id = DB_ID() AND  tbl.name in (SELECT value FROM STRING_SPLIT( @TablesIn , ',' )  )    
 AND tbl.name LIKE 'tbl%' and ius.last_user_update IS NOT NULL    
 AND ius.last_user_update BETWEEN  @dateTimeFrom AND GETDATE()    
 ORDER BY ius.last_user_update DESC    
END