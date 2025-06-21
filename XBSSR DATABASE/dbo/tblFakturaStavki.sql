CREATE TABLE [dbo].[tblFakturaStavki] (
    [ID]           INT             IDENTITY (1, 1) NOT NULL,
    [tblFakturaID] INT             NOT NULL,
    [tblArtikalID] INT             NOT NULL,
    [Normativ]     BIT             NOT NULL,
    [Kolicina]     DECIMAL (18, 2) NOT NULL,
    [Iznos]        DECIMAL (18, 2) NOT NULL,
    [Rabat1]       DECIMAL (18, 2) NULL,
    [Rabat2]       DECIMAL (18, 2) NULL,
    [Rabat3]       DECIMAL (18, 2) NULL,
    [DataVersion]  ROWVERSION      NOT NULL,
    CONSTRAINT [PK_tblFakturaStavki] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblFakturaStavki_tblFaktura] FOREIGN KEY ([tblFakturaID]) REFERENCES [dbo].[tblFaktura] ([ID]) ON DELETE CASCADE
);






GO
CREATE NONCLUSTERED INDEX [FK_tblFakturaStavki_tblFaktura]
    ON [dbo].[tblFakturaStavki]([tblFakturaID] ASC);

