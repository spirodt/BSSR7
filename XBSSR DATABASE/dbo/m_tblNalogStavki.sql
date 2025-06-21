CREATE TYPE [dbo].[m_tblNalogStavki] AS TABLE (
    [ID]           INT             NULL,
    [tblNalogID]   INT             NOT NULL,
    [tblNomativID] INT             NULL,
    [tblArtikalID] INT             NULL,
    [Kolicina]     DECIMAL (9, 2)  NULL,
    [Rabat1]       DECIMAL (18, 4) NULL,
    [DataVersion]  NVARCHAR (MAX)  NULL);

