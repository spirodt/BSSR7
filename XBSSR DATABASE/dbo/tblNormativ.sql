CREATE TABLE [dbo].[tblNormativ] (
    [ID]              INT            IDENTITY (1, 1) NOT NULL,
    [Naziv]           NVARCHAR (50)  NOT NULL,
    [Status]          INT            NULL,
    [FirmaID]         INT            NOT NULL,
    [Sifra]           NVARCHAR (20)  NULL,
    [PodgrupaID]      INT            NOT NULL,
    [KlucniZborovi]   NVARCHAR (300) NULL,
    [Cena]            DECIMAL (9, 3) NOT NULL,
    [tblDDVStavkaID]  INT            NOT NULL,
    [RedenBroj]       INT            NULL,
    [AltNaziv]        NVARCHAR (150) NULL,
    [AltNaziv2]       NVARCHAR (150) NULL,
    [Image]           NVARCHAR (250) NULL,
    [SePecatiVoKujna] BIT            NULL,
    [SePacatiNaSank]  BIT            NULL,
    [DataVersion]     ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tblNormativ] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblNormativ_tblFirma] FOREIGN KEY ([FirmaID]) REFERENCES [dbo].[tblFirma] ([ID])
);










GO
CREATE NONCLUSTERED INDEX [FK_tblNormativ_tblFirma]
    ON [dbo].[tblNormativ]([FirmaID] ASC);

