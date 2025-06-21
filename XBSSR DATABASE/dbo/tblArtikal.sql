CREATE TABLE [dbo].[tblArtikal] (
    [ID]                        INT             IDENTITY (1, 1) NOT NULL,
    [Sifra]                     NVARCHAR (20)   NULL,
    [Naziv]                     NVARCHAR (150)  NOT NULL,
    [tblDDVStavkaID]            INT             NOT NULL,
    [PodgrupaID]                INT             NOT NULL,
    [tblEdinecniMerkiID]        INT             NOT NULL,
    [AltNaziv]                  NVARCHAR (150)  NULL,
    [AltSifra]                  NVARCHAR (50)   NULL,
    [KlucniZborovi]             NVARCHAR (300)  NULL,
    [NabavnaCena]               DECIMAL (18, 2) CONSTRAINT [DF_tblArtikal_NabavnaCena] DEFAULT ((0)) NULL,
    [ProdaznaCena]              DECIMAL (18, 2) CONSTRAINT [DF_tblArtikal_ProdaznaCena] DEFAULT ((0)) NOT NULL,
    [FirmaID]                   INT             NOT NULL,
    [Status]                    INT             NULL,
    [EDMIzlez]                  INT             NULL,
    [KolicinaT]                 DECIMAL (12, 4) NULL,
    [MinimalnaKolicinaNaZaliha] DECIMAL (9, 2)  NULL,
    [RedenBroj]                 INT             CONSTRAINT [DF_tblArtikal_RedenBroj] DEFAULT ((0)) NULL,
    [Barkod1]                   NVARCHAR (50)   NULL,
    [Barkod2]                   NVARCHAR (50)   NULL,
    [AltNaziv2]                 NVARCHAR (150)  NULL,
    [Image]                     NVARCHAR (250)  NULL,
    [SePecatiVoKujna]           BIT             NULL,
    [SePacatiNaSank]            BIT             NULL,
    [DenoviZaGarancija]         INT             NULL,
    [DomasenProizvod]           BIT             NULL,
    [CenaNaGolemo]              DECIMAL (18, 2) NULL,
    [DataVersion]               ROWVERSION      NOT NULL,
    CONSTRAINT [PK_tblArtikal] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblArtikal_tblDDVStavka] FOREIGN KEY ([tblDDVStavkaID]) REFERENCES [dbo].[tblDDVStavka] ([ID]),
    CONSTRAINT [FK_tblArtikal_tblEdinecniMerki] FOREIGN KEY ([tblEdinecniMerkiID]) REFERENCES [dbo].[tblEdinecniMerki] ([ID]),
    CONSTRAINT [FK_tblArtikal_tblFirma] FOREIGN KEY ([FirmaID]) REFERENCES [dbo].[tblFirma] ([ID]),
    CONSTRAINT [FK_tblArtikal_tblPodgrupaID] FOREIGN KEY ([PodgrupaID]) REFERENCES [dbo].[tblPodgrupaID] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE
);






GO
CREATE NONCLUSTERED INDEX [NonClusteredIndex-20230513-102338]
    ON [dbo].[tblArtikal]([FirmaID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblArtikal_tblPodgrupaID]
    ON [dbo].[tblArtikal]([PodgrupaID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblArtikal_tblFirma]
    ON [dbo].[tblArtikal]([FirmaID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblArtikal_tblEdinecniMerkiID]
    ON [dbo].[tblArtikal]([tblEdinecniMerkiID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblArtikal_tblDDVStavkaID]
    ON [dbo].[tblArtikal]([tblDDVStavkaID] ASC);

