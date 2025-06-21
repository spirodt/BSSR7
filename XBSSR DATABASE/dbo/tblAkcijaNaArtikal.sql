CREATE TABLE [dbo].[tblAkcijaNaArtikal] (
    [ID]           INT             IDENTITY (1, 1) NOT NULL,
    [DatumPocetok] DATE            NOT NULL,
    [DatumKraj]    DATE            NOT NULL,
    [tblArtikalID] INT             NOT NULL,
    [AkciskaCena]  DECIMAL (18, 2) NOT NULL,
    [Rabat]        DECIMAL (18, 4) NULL,
    [DataVersion]  ROWVERSION      NOT NULL,
    CONSTRAINT [PK_tblAkcijaNaArtikal] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblAkcijaNaArtikal_tblAkcijaNaArtikal] FOREIGN KEY ([tblArtikalID]) REFERENCES [dbo].[tblArtikal] ([ID])
);






GO
CREATE NONCLUSTERED INDEX [FK_tblAkcijaNaArtikal_tblAkcijaNaArtikal]
    ON [dbo].[tblAkcijaNaArtikal]([tblArtikalID] ASC);

