CREATE TABLE [dbo].[tblPriemStavki] (
    [ID]                INT             IDENTITY (1, 1) NOT NULL,
    [tblPriemID]        INT             NOT NULL,
    [tblArtikalID]      INT             NOT NULL,
    [Kolicina]          DECIMAL (18, 2) NOT NULL,
    [NabavnaCenaBezDDV] DECIMAL (18, 2) NOT NULL,
    [NabavnaCenaSoDDV]  DECIMAL (18, 2) NOT NULL,
    [Rabat1]            DECIMAL (18, 2) CONSTRAINT [DF_tblPriemStavki_Rabat1] DEFAULT ((0)) NULL,
    [Rabat2]            DECIMAL (18, 2) CONSTRAINT [DF_tblPriemStavki_Rabat2] DEFAULT ((0)) NULL,
    [Rabat3]            DECIMAL (18, 2) CONSTRAINT [DF_tblPriemStavki_Rabat3] DEFAULT ((0)) NULL,
    [DataVersion]       ROWVERSION      NOT NULL,
    CONSTRAINT [PK_tblPriemStavki] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblPriemStavki_tblArtikal] FOREIGN KEY ([tblArtikalID]) REFERENCES [dbo].[tblArtikal] ([ID]),
    CONSTRAINT [FK_tblPriemStavki_tblPriem] FOREIGN KEY ([tblPriemID]) REFERENCES [dbo].[tblPriem] ([ID]) ON DELETE CASCADE
);






GO
CREATE NONCLUSTERED INDEX [FK_tblPriemStavki_tblPriem]
    ON [dbo].[tblPriemStavki]([tblPriemID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblPriemStavki_tblArtikal]
    ON [dbo].[tblPriemStavki]([tblArtikalID] ASC);

