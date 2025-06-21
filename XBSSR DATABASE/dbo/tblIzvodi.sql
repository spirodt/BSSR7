CREATE TABLE [dbo].[tblIzvodi] (
    [ID]           INT            IDENTITY (1, 1) NOT NULL,
    [BrojNaIzvod]  NVARCHAR (50)  NOT NULL,
    [Zabeleska]    NVARCHAR (250) NULL,
    [Smetka]       NVARCHAR (50)  NOT NULL,
    [DatumNaIzvod] DATETIME       NULL,
    [DataVersion]  ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tblIzvodi] PRIMARY KEY CLUSTERED ([ID] ASC)
);



