﻿CREATE   PROCEDURE  Backup_databases
                                    AS
                                    BEGIN
	
                                    DECLARE @name NVARCHAR(256) -- database name  
                                    DECLARE @path NVARCHAR(512) -- path for backup files  
                                    DECLARE @fileName NVARCHAR(512) -- filename for backup  
                                    DECLARE @fileDate NVARCHAR(40) -- used for file name
 
                                    -- specify database backup directory
                                    SET @path = 'C:\BSS_EXPORT\BackUpDB\'  
 
                                    -- specify filename format
                                    SELECT @fileDate = CONVERT(NVARCHAR(20),GETDATE(),112) 
 
                                    DECLARE db_cursor CURSOR READ_ONLY FOR  
                                    SELECT name 
                                    FROM master.sys.databases 
                                    WHERE name IN ('BSSR_DEV')  -- exclude these databases
                                    AND state = 0 -- database is online
                                    AND is_in_standby = 0 -- database is not read only for log shipping
 
                                    OPEN db_cursor   
                                    FETCH NEXT FROM db_cursor INTO @name   
 
                                    WHILE @@FETCH_STATUS = 0   
                                    BEGIN   
                                       SET @fileName = @path + @name + '_' + @fileDate + '.BAK'  
                                       BACKUP DATABASE @name TO DISK = @fileName WITH NOFORMAT, INIT, SKIP, NOREWIND, NOUNLOAD,  STATS = 10 
 
                                       FETCH NEXT FROM db_cursor INTO @name   
                                    END   
 
                                    CLOSE db_cursor   
                                    DEALLOCATE db_cursor
                                    END