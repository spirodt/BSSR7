CREATE TABLE [dbo].[tblNalogStavki] (
    [ID]           INT             IDENTITY (1, 1) NOT NULL,
    [tblNalogID]   INT             NOT NULL,
    [tblNomativID] INT             NULL,
    [tblArtikalID] INT             NULL,
    [Kolicina]     DECIMAL (9, 2)  NULL,
    [Rabat1]       DECIMAL (18, 4) CONSTRAINT [DF_tblNalogStavki_Rabat1] DEFAULT ((0)) NULL,
    [DataVersion]  ROWVERSION      NOT NULL,
    CONSTRAINT [PK_tblNalogStavki] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblNalogStavki_tblArtikal] FOREIGN KEY ([tblArtikalID]) REFERENCES [dbo].[tblArtikal] ([ID]),
    CONSTRAINT [FK_tblNalogStavki_tblNalog] FOREIGN KEY ([tblNalogID]) REFERENCES [dbo].[tblNalog] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_tblNalogStavki_tblNormativ] FOREIGN KEY ([tblNomativID]) REFERENCES [dbo].[tblNormativ] ([ID])
);






GO
CREATE NONCLUSTERED INDEX [FK_tblNalogStavki_tblNormativ]
    ON [dbo].[tblNalogStavki]([tblNomativID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblNalogStavki_tblNalog]
    ON [dbo].[tblNalogStavki]([tblNalogID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblNalogStavki_tblArtikal]
    ON [dbo].[tblNalogStavki]([tblArtikalID] ASC);

