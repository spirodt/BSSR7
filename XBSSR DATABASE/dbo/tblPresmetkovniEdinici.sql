CREATE TABLE [dbo].[tblPresmetkovniEdinici] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Sifra]       NVARCHAR (20)  NOT NULL,
    [Naziv]       NVARCHAR (50)  NOT NULL,
    [FirmaID]     INT            NOT NULL,
    [Zabeleska]   NVARCHAR (100) NULL,
    [Status]      INT            NULL,
    [DataVersion] ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tblPresmetkovniEdinici_1] PRIMARY KEY CLUSTERED ([ID] ASC)
);





