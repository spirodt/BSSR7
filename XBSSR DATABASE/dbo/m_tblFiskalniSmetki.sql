CREATE TYPE [dbo].[m_tblFiskalniSmetki] AS TABLE (
    [ID]            INT             NULL,
    [Broj]          INT             NOT NULL,
    [Datum]         DATETIME        NOT NULL,
    [Iznos]         DECIMAL (18, 2) NOT NULL,
    [Stornirana]    BIT             NULL,
    [tblSmetkaID]   INT             NOT NULL,
    [FirmaID]       INT             NOT NULL,
    [KodNaDokument] NVARCHAR (70)   NULL,
    [DataVersion]   NVARCHAR (MAX)  NULL);

