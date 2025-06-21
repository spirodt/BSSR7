CREATE TYPE [dbo].[m_tblPrevodi] AS TABLE (
    [ID]          INT            NULL,
    [KlucenZbor]  NVARCHAR (150) NULL,
    [MK]          NVARCHAR (250) NULL,
    [AL]          NVARCHAR (250) NULL,
    [EN]          NVARCHAR (250) NULL,
    [SR]          NVARCHAR (250) NULL,
    [DataVersion] NVARCHAR (MAX) NULL);

