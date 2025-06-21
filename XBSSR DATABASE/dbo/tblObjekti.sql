CREATE TABLE [dbo].[tblObjekti] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [Naziv]       NVARCHAR (50) NOT NULL,
    [Sifra]       NVARCHAR (20) NULL,
    [FirmaID]     INT           NOT NULL,
    [Status]      INT           NULL,
    [DataVersion] ROWVERSION    NOT NULL,
    CONSTRAINT [PK_tblObjekti] PRIMARY KEY CLUSTERED ([ID] ASC)
);








GO


