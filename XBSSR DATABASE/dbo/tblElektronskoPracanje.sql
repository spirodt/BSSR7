CREATE TABLE [dbo].[tblElektronskoPracanje] (
    [ID]                            INT            IDENTITY (1, 1) NOT NULL,
    [DokumentID]                    INT            NOT NULL,
    [Naziv]                         NVARCHAR (150) NOT NULL,
    [Zabeleska]                     NVARCHAR (150) NULL,
    [DokumentValue]                 NVARCHAR (MAX) NOT NULL,
    [Status]                        INT            NULL,
    [FirmaID]                       INT            NOT NULL,
    [PratenOD]                      NVARCHAR (100) NOT NULL,
    [PratenDO]                      NVARCHAR (150) NOT NULL,
    [DatumNaPracanje]               DATETIME       NOT NULL,
    [DatumNaPoslednaIzmenaNaStatus] DATETIME       NULL,
    [PratenPrimen]                  BIT            NOT NULL,
    [DatumNaPotvrda]                DATETIME       NULL,
    [DatumNaKnizenje]               DATETIME       NULL,
    [GeneriranKodNaDokument]        NVARCHAR (MAX) NOT NULL,
    [ODObjekt]                      INT            NOT NULL,
    [DoObjekt]                      INT            NOT NULL,
    [DataVersion]                   ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tblElektronskoPracanje] PRIMARY KEY CLUSTERED ([ID] ASC)
);



