CREATE TABLE [dbo].[DbVersion] (
    [ID]                  INT           IDENTITY (1, 1) NOT NULL,
    [DbVersion]           NVARCHAR (30) NOT NULL,
    [LastAlterScriptName] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_DbVersion] PRIMARY KEY CLUSTERED ([ID] ASC)
);

