CREATE TABLE [dbo].[tblUsers] (
    [ID]                   INT           IDENTITY (1, 1) NOT NULL,
    [UserName]             NVARCHAR (25) NOT NULL,
    [Password]             NVARCHAR (25) NOT NULL,
    [FullName]             NVARCHAR (50) NOT NULL,
    [NivoNaAdministracija] INT           NOT NULL,
    [Status]               INT           CONSTRAINT [DF_tblUsers_Status] DEFAULT ((0)) NULL,
    [FirmaID]              INT           NOT NULL,
    [tblObjektId]          INT           NULL,
    [DataVersion]          ROWVERSION    NOT NULL,
    CONSTRAINT [PK_tblUsers] PRIMARY KEY CLUSTERED ([ID] ASC)
);






GO


