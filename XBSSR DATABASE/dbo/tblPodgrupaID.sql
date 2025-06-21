CREATE TABLE [dbo].[tblPodgrupaID] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [GrupaID]     INT            NOT NULL,
    [Naziv]       NVARCHAR (50)  NOT NULL,
    [FirmaID]     INT            NOT NULL,
    [Status]      INT            NULL,
    [Image]       NVARCHAR (250) NULL,
    [DataVersion] ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tblPodgrupaID] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblPodgrupaID_tblGrupaNaArtikli] FOREIGN KEY ([GrupaID]) REFERENCES [dbo].[tblGrupaNaArtikli] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE
);








GO
CREATE NONCLUSTERED INDEX [FK_tblPodgrupaID_tblGrupaNaArtikli]
    ON [dbo].[tblPodgrupaID]([GrupaID] ASC);

