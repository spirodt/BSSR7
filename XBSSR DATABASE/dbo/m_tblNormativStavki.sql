CREATE TYPE [dbo].[m_tblNormativStavki] AS TABLE (
    [ID]            INT             NULL,
    [tblNormativID] INT             NOT NULL,
    [tblArtikalID]  INT             NOT NULL,
    [Status]        INT             NULL,
    [Kolicina]      DECIMAL (12, 4) NOT NULL,
    [DataVersion]   NVARCHAR (MAX)  NULL);

