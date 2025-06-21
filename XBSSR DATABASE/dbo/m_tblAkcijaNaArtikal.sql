CREATE TYPE [dbo].[m_tblAkcijaNaArtikal] AS TABLE (
    [ID]           INT             NULL,
    [DatumPocetok] DATE            NOT NULL,
    [DatumKraj]    DATE            NOT NULL,
    [tblArtikalID] INT             NOT NULL,
    [AkciskaCena]  DECIMAL (18, 2) NOT NULL,
    [Rabat]        DECIMAL (18, 4) NULL,
    [DataVersion]  NVARCHAR (MAX)  NULL);

