CREATE TABLE [dbo].[tblPriem] (
    [ID]                      INT             IDENTITY (1, 1) NOT NULL,
    [PriemBroj]               INT             NOT NULL,
    [PriemDatum]              DATETIME        NOT NULL,
    [tblPartnerID]            INT             NOT NULL,
    [tblUserID]               INT             NOT NULL,
    [ObjektID]                INT             NOT NULL,
    [IspratnicaFakturaBroj]   NVARCHAR (50)   NULL,
    [IspratnicaFakturaDatum]  DATETIME        NULL,
    [ValutaDenovi]            INT             NULL,
    [KalkulacijaBroj]         INT             NULL,
    [Zabeleska]               NVARCHAR (50)   NULL,
    [VkupenIznos]             DECIMAL (18, 2) NULL,
    [DatumNaDospeanost]       DATETIME        NULL,
    [DatumNaKreiranjeNaPriem] DATETIME        NULL,
    [KodNaDokument]           NVARCHAR (70)   NULL,
    [DataVersion]             ROWVERSION      NOT NULL,
    CONSTRAINT [PK_Priem] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblPriem_tblPartneri] FOREIGN KEY ([tblPartnerID]) REFERENCES [dbo].[tblPartneri] ([ID])
);






GO
CREATE NONCLUSTERED INDEX [FK_tblPriem_tblPartneri]
    ON [dbo].[tblPriem]([tblPartnerID] ASC);

