CREATE PROCEDURE [dbo].[usp_generate_inserts_from_select]
    @table_name NVARCHAR(256),
    @where_clause NVARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @sql NVARCHAR(MAX) = N'';

    SELECT @sql += N'INSERT INTO ' + QUOTENAME(@table_name) + N' ('
        + STUFF((
            SELECT N', ' + QUOTENAME(c.name)
            FROM sys.columns AS c
            WHERE c.[object_id] = t.[object_id]
            ORDER BY c.column_id
            FOR XML PATH(N''), TYPE).value(N'.[1]', N'nvarchar(max)'), 1, 2, N'') + N')'
        + N' SELECT ' + STUFF((
            SELECT N', ' + QUOTENAME(c.name)
            FROM sys.columns AS c
            WHERE c.[object_id] = t.[object_id]
            ORDER BY c.column_id
            FOR XML PATH(N''), TYPE).value(N'.[1]', N'nvarchar(max)'), 1, 2, N'')
        + N' FROM ' + QUOTENAME(SCHEMA_NAME(t.[schema_id])) + '.' + QUOTENAME(t.name) + ';'
    FROM sys.tables AS t
    WHERE t.name = @table_name;

    IF @where_clause IS NOT NULL
        SET @sql += NCHAR(13) + NCHAR(10) + N'WHERE ' + @where_clause;

    PRINT @sql;
END;