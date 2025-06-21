CREATE TABLE [dbo].[tblPartneri] (
    [ID]                       INT            IDENTITY (1, 1) NOT NULL,
    [Sifra]                    NVARCHAR (20)  NULL,
    [Naziv]                    NVARCHAR (350) NOT NULL,
    [Adresa]                   NVARCHAR (250) NULL,
    [Telefoni]                 NVARCHAR (270) NULL,
    [Email]                    NVARCHAR (250) NULL,
    [EDB]                      NVARCHAR (18)  NULL,
    [Mesto]                    NVARCHAR (150) NULL,
    [Tip]                      INT            NOT NULL,
    [Status]                   INT            NULL,
    [FirmaID]                  INT            NOT NULL,
    [tblPresmetkovnaEdinicaID] INT            NULL,
    [DataVersion]              ROWVERSION     NOT NULL,
    [Notes]                    NVARCHAR (MAX) NULL,
    [DefaultKolicina]          INT            NULL,
    [BrojNaStan]               INT            NULL,
    [TipNaDostava]             INT            NULL,
    [DateModified]             DATETIME       NULL,
    [AltSifra]                 NVARCHAR (50)  NULL,
    CONSTRAINT [PK_tblPartneri] PRIMARY KEY CLUSTERED ([ID] ASC)
);







