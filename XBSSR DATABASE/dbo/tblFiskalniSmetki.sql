CREATE TABLE [dbo].[tblFiskalniSmetki] (
    [ID]            INT             IDENTITY (1, 1) NOT NULL,
    [Broj]          INT             NOT NULL,
    [Datum]         DATETIME        CONSTRAINT [DF_tblFiskalniSmetki_Datum] DEFAULT (getdate()) NOT NULL,
    [Iznos]         DECIMAL (18, 2) NOT NULL,
    [Stornirana]    BIT             NULL,
    [tblSmetkaID]   INT             NOT NULL,
    [FirmaID]       INT             NOT NULL,
    [KodNaDokument] NVARCHAR (70)   NULL,
    [DataVersion]   ROWVERSION      NOT NULL,
    CONSTRAINT [PK_tblFiskalniSmetki] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblFiskalniSmetki_tblSmetka] FOREIGN KEY ([tblSmetkaID]) REFERENCES [dbo].[tblSmetka] ([ID])
);






GO
CREATE NONCLUSTERED INDEX [FK_tblFiskalniSmetki_tblSmetka]
    ON [dbo].[tblFiskalniSmetki]([tblSmetkaID] ASC);

