CREATE TYPE [dbo].[m_tblSmetkaStavki] AS TABLE (
    [ID]          INT             NULL,
    [tblSmetkaID] INT             NOT NULL,
    [tblNalogID]  INT             NOT NULL,
    [Status]      INT             NULL,
    [Kolicina]    INT             NOT NULL,
    [Cena]        DECIMAL (18, 2) NOT NULL,
    [DataVersion] NVARCHAR (MAX)  NULL);

