CREATE TABLE [dbo].[tblDDVStavka] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Naziv]       NVARCHAR (20)  NOT NULL,
    [Procent]     DECIMAL (4, 2) NOT NULL,
    [FirmaID]     INT            NOT NULL,
    [Grupa]       INT            NOT NULL,
    [DataVersion] ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tblDDVStavka] PRIMARY KEY CLUSTERED ([ID] ASC)
);






GO


