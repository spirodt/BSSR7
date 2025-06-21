CREATE TABLE [dbo].[tblSmetkaStavkiIzmeneta] (
    [ID]                  INT             IDENTITY (1, 1) NOT NULL,
    [tblSmetkaID]         INT             NOT NULL,
    [tblNalogID]          INT             NOT NULL,
    [Status]              INT             NULL,
    [Kolicina]            INT             NOT NULL,
    [Cena]                DECIMAL (18, 2) NOT NULL,
    [DatumNaIzmena]       DATETIME        NULL,
    [tblSmetkaIzmenetaID] INT             NULL,
    [DataVersion]         ROWVERSION      NOT NULL,
    CONSTRAINT [PK_tblSmetkaStavkiIzmeneta] PRIMARY KEY CLUSTERED ([ID] ASC)
);



