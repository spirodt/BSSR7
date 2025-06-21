CREATE TABLE [dbo].[tblSmetkaStavki] (
    [ID]          INT             IDENTITY (1, 1) NOT NULL,
    [tblSmetkaID] INT             NOT NULL,
    [tblNalogID]  INT             NOT NULL,
    [Status]      INT             NULL,
    [Kolicina]    INT             NOT NULL,
    [Cena]        DECIMAL (18, 2) NOT NULL,
    [DataVersion] ROWVERSION      NOT NULL,
    CONSTRAINT [PK_tblSmetkaStavki] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblSmetkaStavki_tblNalog] FOREIGN KEY ([tblNalogID]) REFERENCES [dbo].[tblNalog] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_tblSmetkaStavki_tblSmetka] FOREIGN KEY ([tblSmetkaID]) REFERENCES [dbo].[tblSmetka] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE
);






GO
CREATE NONCLUSTERED INDEX [FK_tblSmetkaStavki_tblSmetka]
    ON [dbo].[tblSmetkaStavki]([tblSmetkaID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblSmetkaStavki_tblNalog]
    ON [dbo].[tblSmetkaStavki]([tblNalogID] ASC);

