CREATE TABLE [dbo].[tblKnizenjeM] (
    [ID]                  INT             IDENTITY (1, 1) NOT NULL,
    [tblNormativID]       INT             NULL,
    [tblArtikalID]        INT             NULL,
    [tipNaArtikal]        INT             NOT NULL,
    [ProdaznaCena]        DECIMAL (18, 2) NOT NULL,
    [Kolicina]            DECIMAL (12, 4) NOT NULL,
    [Sifra]               NVARCHAR (20)   NULL,
    [tblEdinecnaMerka]    INT             NOT NULL,
    [tblDDVID]            INT             NOT NULL,
    [tipNaKnizenje]       INT             NOT NULL,
    [NabavnaCena]         DECIMAL (18, 2) NOT NULL,
    [EdinecnaCena]        DECIMAL (18, 2) NULL,
    [IznosSoDDV]          DECIMAL (18, 2) NOT NULL,
    [IznosBezDDV]         DECIMAL (18, 2) NOT NULL,
    [IznosDDV]            DECIMAL (18, 2) NOT NULL,
    [DatumNaKnizenje]     DATETIME        NOT NULL,
    [tblUserID]           INT             NOT NULL,
    [tblObjektiID]        INT             NOT NULL,
    [DatumNaPocetok]      DATETIME        NOT NULL,
    [DatumNaKraj]         DATETIME        NOT NULL,
    [tblSmetkaID]         INT             NULL,
    [tblFakturaID]        INT             NULL,
    [tblPriemID]          INT             NULL,
    [OtpecatenaFiskalna]  INT             NULL,
    [tblValutaID]         INT             NULL,
    [Rabat]               DECIMAL (18, 2) NULL,
    [IznosNaRabat]        DECIMAL (18, 2) NULL,
    [ProdaznaCenaSoRabat] DECIMAL (18, 2) NULL,
    [tblObjektiIDOD]      INT             NULL,
    [tblObjektiIDDO]      INT             NULL,
    [tblDokumentID]       INT             NULL,
    [KodNaDokument]       NVARCHAR (70)   NULL,
    [DataVersion]         ROWVERSION      NOT NULL,
    CONSTRAINT [PK_tblKnizenjeM] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblKnizenjeM_tblDokumenti] FOREIGN KEY ([tblDokumentID]) REFERENCES [dbo].[tblDokumenti] ([ID]),
    CONSTRAINT [FK_tblKnizenjeM_tblFaktura] FOREIGN KEY ([tblFakturaID]) REFERENCES [dbo].[tblFaktura] ([ID]),
    CONSTRAINT [FK_tblKnizenjeM_tblPriem] FOREIGN KEY ([tblPriemID]) REFERENCES [dbo].[tblPriem] ([ID]),
    CONSTRAINT [FK_tblKnizenjeM_tblSmetka] FOREIGN KEY ([tblSmetkaID]) REFERENCES [dbo].[tblSmetka] ([ID])
);








GO
CREATE NONCLUSTERED INDEX [FK_tblKnizenjeM_tblSmetka]
    ON [dbo].[tblKnizenjeM]([tblSmetkaID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblKnizenjeM_tblPriem]
    ON [dbo].[tblKnizenjeM]([tblPriemID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblKnizenjeM_tblFaktura]
    ON [dbo].[tblKnizenjeM]([tblFakturaID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblKnizenjeM_tblDokumenti]
    ON [dbo].[tblKnizenjeM]([tblDokumentID] ASC);

