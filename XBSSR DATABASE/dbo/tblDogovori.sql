CREATE TABLE [dbo].[tblDogovori] (
    [ID]            INT            IDENTITY (1, 1) NOT NULL,
    [Naziv]         NVARCHAR (250) NOT NULL,
    [Zabeleska]     NVARCHAR (250) NULL,
    [DatumOd]       DATE           CONSTRAINT [DF_tblDogovori_DatumOd] DEFAULT (getdate()) NULL,
    [DatumDo]       DATE           CONSTRAINT [DF_tblDogovori_DatumDo] DEFAULT (getdate()) NULL,
    [tblPartnerId]  INT            NOT NULL,
    [BrojNaDogovor] NVARCHAR (50)  NULL,
    [BrojNaTender]  NVARCHAR (50)  NULL,
    CONSTRAINT [PK_tblDogovori] PRIMARY KEY CLUSTERED ([ID] ASC)
);

