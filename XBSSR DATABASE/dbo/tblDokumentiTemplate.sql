CREATE TABLE [dbo].[tblDokumentiTemplate] (
    [ID]              INT             IDENTITY (1, 1) NOT NULL,
    [TipNaDokumentID] INT             NULL,
    [tblArtikalID]    INT             NULL,
    [tblNormativID]   INT             NULL,
    [Cena]            DECIMAL (18, 2) NULL,
    [Kolicina]        DECIMAL (18, 2) NULL,
    [Iznos]           DECIMAL (18, 2) NULL,
    [Rabat1]          DECIMAL (18, 2) NULL,
    CONSTRAINT [PK_tblDokumentiTemplate] PRIMARY KEY CLUSTERED ([ID] ASC)
);

