CREATE TABLE [dbo].[tblValuti] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [Opis]        NVARCHAR (50) NOT NULL,
    [Kratenka]    VARCHAR (3)   NOT NULL,
    [DataVersion] ROWVERSION    NOT NULL,
    CONSTRAINT [PK_tblValuti] PRIMARY KEY CLUSTERED ([ID] ASC)
);



