CREATE TABLE [dbo].[tblEdinecniMerki] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [Naziv]       NVARCHAR (50) NOT NULL,
    [Kratenka]    NVARCHAR (3)  NOT NULL,
    [FirmaID]     INT           NOT NULL,
    [Status]      INT           NULL,
    [DataVersion] ROWVERSION    NOT NULL,
    CONSTRAINT [PK_tblEdinecniMerki] PRIMARY KEY CLUSTERED ([ID] ASC)
);






GO


