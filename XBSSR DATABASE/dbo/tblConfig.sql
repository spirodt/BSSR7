CREATE TABLE [dbo].[tblConfig] (
    [ID]                   INT           IDENTITY (1, 1) NOT NULL,
    [Opis]                 NVARCHAR (50) NOT NULL,
    [Ime]                  NVARCHAR (50) NOT NULL,
    [Vrednost]             INT           CONSTRAINT [DF_tblConfig_Vrednost] DEFAULT ((0)) NULL,
    [NivoNaAdministracija] INT           CONSTRAINT [DF_tblConfig_NivoNaAdministracija] DEFAULT ((0)) NULL,
    [Range]                VARCHAR (10)  CONSTRAINT [DF_tblConfig_Range] DEFAULT ('0-1') NULL,
    [ImeNaModul]           VARCHAR (50)  NULL,
    [FirmaID]              INT           NOT NULL,
    [DataVersion]          ROWVERSION    NOT NULL,
    CONSTRAINT [PK_tblConfig] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [IX_tblConfig] UNIQUE NONCLUSTERED ([Ime] ASC)
);



