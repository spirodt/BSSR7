CREATE TABLE [dbo].[tblSmetkaIzmeneta] (
    [ID]                  INT            IDENTITY (1, 1) NOT NULL,
    [Broj]                INT            NOT NULL,
    [DatumPocetok]        DATETIME       NOT NULL,
    [DatumKraj]           DATETIME       NULL,
    [tblUserID]           INT            NOT NULL,
    [Smena_ID]            INT            NOT NULL,
    [Zatvorena]           BIT            NULL,
    [FirmaID]             INT            NOT NULL,
    [ObjektID]            INT            NOT NULL,
    [Zabeleska]           NVARCHAR (MAX) NULL,
    [Izmeneta]            INT            NULL,
    [DatumNaIzmena]       DATETIME       CONSTRAINT [DF_tblSmetkaIzmeneta_DatumNaIzmena] DEFAULT (getdate()) NULL,
    [tblSmetkaIzmenetaID] INT            NULL,
    [tblPartnerID]        INT            NULL,
    [DataVersion]         ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tblSmetkaIzmeneta] PRIMARY KEY CLUSTERED ([ID] ASC)
);



