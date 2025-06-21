CREATE TYPE [dbo].[m_tblDokumentStavki] AS TABLE (
    [ID]            INT             NULL,
    [tblDokumentID] INT             NOT NULL,
    [tblArtikalID]  INT             NULL,
    [tblNormativID] INT             NULL,
    [Cena]          DECIMAL (18, 2) NOT NULL,
    [Kolicina]      DECIMAL (18, 2) NOT NULL,
    [Iznos]         DECIMAL (18, 2) NOT NULL,
    [Rabat1]        DECIMAL (18, 2) NULL,
    [DataVersion]   NVARCHAR (MAX)  NULL);

