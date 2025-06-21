CREATE TABLE [dbo].[tblGrupaNaArtikli] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Naziv]       NVARCHAR (50)  NOT NULL,
    [Sifra]       NVARCHAR (20)  NULL,
    [Status]      INT            NULL,
    [FirmaID]     INT            NOT NULL,
    [Image]       NVARCHAR (250) NULL,
    [DataVersion] ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tblGrupaNaArtikli] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblGrupaNaArtikli_tblFirma] FOREIGN KEY ([FirmaID]) REFERENCES [dbo].[tblFirma] ([ID])
);










GO



GO
CREATE NONCLUSTERED INDEX [FK_tblGrupaNaArtikli_tblFirma]
    ON [dbo].[tblGrupaNaArtikli]([FirmaID] ASC);

