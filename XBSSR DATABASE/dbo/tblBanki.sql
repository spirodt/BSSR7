CREATE TABLE [dbo].[tblBanki] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Sifra]       NVARCHAR (20)  NULL,
    [Naziv]       NVARCHAR (100) NOT NULL,
    [Status]      INT            NULL,
    [FirmaID]     INT            NOT NULL,
    [DataVersion] ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tblBanki] PRIMARY KEY CLUSTERED ([ID] ASC)
);





