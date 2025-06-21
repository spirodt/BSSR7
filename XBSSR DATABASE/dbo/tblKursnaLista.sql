CREATE TABLE [dbo].[tblKursnaLista] (
    [ID]          INT             IDENTITY (1, 1) NOT NULL,
    [tblValutaID] INT             NULL,
    [Kurs]        DECIMAL (12, 4) NULL,
    [DataVersion] ROWVERSION      NOT NULL,
    CONSTRAINT [PK_tblKursnaLista] PRIMARY KEY CLUSTERED ([ID] ASC)
);



