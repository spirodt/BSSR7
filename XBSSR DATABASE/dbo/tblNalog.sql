CREATE TABLE [dbo].[tblNalog] (
    [ID]           INT            IDENTITY (1, 1) NOT NULL,
    [Broj]         INT            NOT NULL,
    [Zabeleska]    NVARCHAR (350) CONSTRAINT [DF_tblNalog_Zabeleska] DEFAULT (getdate()) NULL,
    [DatumPocetok] DATETIME       CONSTRAINT [DF_tblNalog_DatumPocetok] DEFAULT (getdate()) NOT NULL,
    [DatumKraj]    DATETIME       NULL,
    [FirmaID]      INT            NOT NULL,
    [Smena_ID]     INT            NOT NULL,
    [Zavrsen]      BIT            NULL,
    [TipNaNalog]   INT            NOT NULL,
    [SmetkaID]     INT            NOT NULL,
    [DataVersion]  ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tblNalog] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblNalog_tblFirma] FOREIGN KEY ([FirmaID]) REFERENCES [dbo].[tblFirma] ([ID])
);






GO
CREATE NONCLUSTERED INDEX [FK_tblNalog_tblFirma]
    ON [dbo].[tblNalog]([FirmaID] ASC);

