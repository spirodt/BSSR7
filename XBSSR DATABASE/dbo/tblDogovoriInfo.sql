CREATE TABLE [dbo].[tblDogovoriInfo] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [tblDogovorId] INT             NOT NULL,
    [tblArtikalID] INT             NOT NULL,
    [Cena]         DECIMAL (18, 2) CONSTRAINT [DF_tblDogovoriInfo_Cena] DEFAULT ((0)) NOT NULL,
    [Kolicina]     DECIMAL (18, 2) CONSTRAINT [DF_tblDogovoriInfo_Kolicina] DEFAULT ((1)) NOT NULL,
    [Zabeleska]    NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_tblDogovoriInfo] PRIMARY KEY CLUSTERED ([Id] ASC)
);

