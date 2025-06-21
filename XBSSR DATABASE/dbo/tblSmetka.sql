CREATE TABLE [dbo].[tblSmetka] (
    [ID]              INT             IDENTITY (1, 1) NOT NULL,
    [Broj]            INT             NOT NULL,
    [DatumPocetok]    DATETIME        CONSTRAINT [DF_tblSmetka_DatumPocetok] DEFAULT (getdate()) NOT NULL,
    [DatumKraj]       DATETIME        NULL,
    [tblUserID]       INT             NOT NULL,
    [Smena_ID]        INT             NOT NULL,
    [Zatvorena]       BIT             CONSTRAINT [DF_tblSmetka_Zatvorena] DEFAULT ((0)) NULL,
    [FirmaID]         INT             NOT NULL,
    [ObjektID]        INT             NOT NULL,
    [Zabeleska]       NVARCHAR (MAX)  NULL,
    [ImaPopust]       INT             NULL,
    [ProcentNaPopust] DECIMAL (18, 2) NULL,
    [Izmeneta]        INT             NULL,
    [tblPartnerID]    INT             NULL,
    [KodNaDokument]   NVARCHAR (70)   NULL,
    [DataVersion]     ROWVERSION      NOT NULL,
    CONSTRAINT [PK_tblSmetka] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblSmetka_tblFirma] FOREIGN KEY ([FirmaID]) REFERENCES [dbo].[tblFirma] ([ID]),
    CONSTRAINT [FK_tblSmetka_tblObjekti] FOREIGN KEY ([ObjektID]) REFERENCES [dbo].[tblObjekti] ([ID]),
    CONSTRAINT [FK_tblSmetka_tblPartneri] FOREIGN KEY ([tblPartnerID]) REFERENCES [dbo].[tblPartneri] ([ID]),
    CONSTRAINT [FK_tblSmetka_tblUsers] FOREIGN KEY ([tblUserID]) REFERENCES [dbo].[tblUsers] ([ID])
);










GO



GO
CREATE NONCLUSTERED INDEX [FK_tblSmetka_tblUsers]
    ON [dbo].[tblSmetka]([tblUserID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblSmetka_tblPartneri]
    ON [dbo].[tblSmetka]([tblPartnerID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblSmetka_tblObjekti]
    ON [dbo].[tblSmetka]([ObjektID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblSmetka_tblFirma]
    ON [dbo].[tblSmetka]([FirmaID] ASC);

