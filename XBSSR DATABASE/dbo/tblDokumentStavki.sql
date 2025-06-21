CREATE TABLE [dbo].[tblDokumentStavki] (
    [ID]            INT             IDENTITY (1, 1) NOT NULL,
    [tblDokumentID] INT             NOT NULL,
    [tblArtikalID]  INT             NULL,
    [tblNormativID] INT             NULL,
    [Cena]          DECIMAL (18, 4) NOT NULL,
    [Kolicina]      DECIMAL (18, 2) NOT NULL,
    [Iznos]         DECIMAL (18, 2) NOT NULL,
    [Rabat1]        DECIMAL (18, 2) NULL,
    [DataVersion]   ROWVERSION      NOT NULL,
    CONSTRAINT [PK_tblDokumentStavki] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblDokumentStavki_tblDokumenti] FOREIGN KEY ([tblDokumentID]) REFERENCES [dbo].[tblDokumenti] ([ID]) ON DELETE CASCADE
);








GO
CREATE NONCLUSTERED INDEX [FK_tblDokumentStavki_tblDokumenti]
    ON [dbo].[tblDokumentStavki]([tblDokumentID] ASC);

