CREATE TABLE [dbo].[tblFaktura] (
    [ID]                INT            IDENTITY (1, 1) NOT NULL,
    [Broj]              INT            NOT NULL,
    [Datum]             DATE           NOT NULL,
    [tblPartnerID]      INT            NOT NULL,
    [tblZiroSmetkaID]   INT            NULL,
    [tblBankaID]        INT            NULL,
    [tblUserID]         INT            NOT NULL,
    [Valuta]            DATE           NOT NULL,
    [Zabeleska]         NVARCHAR (MAX) NULL,
    [ListaNaIspratnici] NVARCHAR (150) NULL,
    [KodNaDokument]     NVARCHAR (70)  NULL,
    [DataVersion]       ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tblFaktura] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblFaktura_tblBanki] FOREIGN KEY ([tblBankaID]) REFERENCES [dbo].[tblBanki] ([ID]),
    CONSTRAINT [FK_tblFaktura_tblPartneri] FOREIGN KEY ([tblPartnerID]) REFERENCES [dbo].[tblPartneri] ([ID]),
    CONSTRAINT [FK_tblFaktura_tblUsers] FOREIGN KEY ([tblUserID]) REFERENCES [dbo].[tblUsers] ([ID]),
    CONSTRAINT [FK_tblFaktura_tblZiroSmetki] FOREIGN KEY ([tblZiroSmetkaID]) REFERENCES [dbo].[tblZiroSmetki] ([ID]) ON DELETE CASCADE
);






GO
CREATE NONCLUSTERED INDEX [FK_tblFaktura_tblZiroSmetki]
    ON [dbo].[tblFaktura]([tblZiroSmetkaID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblFaktura_tblUsers]
    ON [dbo].[tblFaktura]([tblUserID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblFaktura_tblPartneri]
    ON [dbo].[tblFaktura]([tblPartnerID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblFaktura_tblBanki]
    ON [dbo].[tblFaktura]([tblBankaID] ASC);

