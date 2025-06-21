CREATE TABLE [dbo].[tblNalogStavkiIzmeneta] (
    [ID]                 INT             IDENTITY (1, 1) NOT NULL,
    [tblNalogIzmenetaID] INT             NOT NULL,
    [tblNomativID]       INT             NULL,
    [tblArtikalID]       INT             NULL,
    [Kolicina]           DECIMAL (9, 2)  NULL,
    [Rabat1]             DECIMAL (18, 4) NULL,
    [DataVersion]        ROWVERSION      NOT NULL,
    CONSTRAINT [PK_tblNalogStavkiIzmeneta] PRIMARY KEY CLUSTERED ([ID] ASC)
);



