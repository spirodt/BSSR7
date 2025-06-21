CREATE TABLE [dbo].[tblNaracki] (
    [ID]             INT            IDENTITY (1, 1) NOT NULL,
    [NarackaBroj]    INT            NOT NULL,
    [Opis]           NVARCHAR (MAX) NOT NULL,
    [DatumNaNaracka] DATETIME       NOT NULL,
    [Ime]            NVARCHAR (50)  NOT NULL,
    [Kontakt]        NVARCHAR (50)  NULL,
    [OdObjekt]       NVARCHAR (50)  NULL,
    [Zavrsena]       BIT            NOT NULL,
    [KodNaDokument]  NVARCHAR (70)  NULL,
    [DataVersion]    ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tblNaracki] PRIMARY KEY CLUSTERED ([ID] ASC)
);



