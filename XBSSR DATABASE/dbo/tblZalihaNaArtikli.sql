CREATE TABLE [dbo].[tblZalihaNaArtikli] (
    [ID]           INT             IDENTITY (1, 1) NOT NULL,
    [Datum]        DATETIME        CONSTRAINT [DF_tblZalihaNaArtikli_Datum] DEFAULT (getdate()) NOT NULL,
    [tblArtikalID] INT             NOT NULL,
    [Vlez]         DECIMAL (18, 2) CONSTRAINT [DF_tblZalihaNaArtikli_Vlez] DEFAULT ((0)) NOT NULL,
    [Izlez]        DECIMAL (18, 2) CONSTRAINT [DF_tblZalihaNaArtikli_Izlez] DEFAULT ((0)) NOT NULL,
    [TIpDokument]  INT             NOT NULL,
    [IDNaDokument] INT             NOT NULL,
    [DataVersion]  ROWVERSION      NOT NULL,
    CONSTRAINT [PK_tblZalihaNaArtikli] PRIMARY KEY CLUSTERED ([ID] ASC)
);




GO



GO


