CREATE TABLE [dbo].[tblNormativStavki] (
    [ID]            INT             IDENTITY (1, 1) NOT NULL,
    [tblNormativID] INT             NOT NULL,
    [tblArtikalID]  INT             NOT NULL,
    [Status]        INT             NULL,
    [Kolicina]      DECIMAL (12, 4) NOT NULL,
    [DataVersion]   ROWVERSION      NOT NULL,
    CONSTRAINT [PK_tblNormativStavki] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblNormativStavki_tblArtikal] FOREIGN KEY ([tblArtikalID]) REFERENCES [dbo].[tblArtikal] ([ID]),
    CONSTRAINT [FK_tblNormativStavki_tblNormativ] FOREIGN KEY ([tblNormativID]) REFERENCES [dbo].[tblNormativ] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE
);






GO
CREATE NONCLUSTERED INDEX [FK_tblNormativStavki_tblNormativ]
    ON [dbo].[tblNormativStavki]([tblNormativID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblNormativStavki_tblArtikal]
    ON [dbo].[tblNormativStavki]([tblArtikalID] ASC);

