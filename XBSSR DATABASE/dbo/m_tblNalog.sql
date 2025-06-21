CREATE TYPE [dbo].[m_tblNalog] AS TABLE (
    [ID]           INT            NULL,
    [Broj]         INT            NOT NULL,
    [Zabeleska]    NVARCHAR (350) NULL,
    [DatumPocetok] DATETIME       NOT NULL,
    [DatumKraj]    DATETIME       NULL,
    [FirmaID]      INT            NOT NULL,
    [Smena_ID]     INT            NOT NULL,
    [Zavrsen]      BIT            NULL,
    [TipNaNalog]   INT            NOT NULL,
    [SmetkaID]     INT            NOT NULL,
    [DataVersion]  NVARCHAR (MAX) NULL);

