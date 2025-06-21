CREATE TYPE [dbo].[m_tblPriemStavki] AS TABLE (
    [ID]                INT             NULL,
    [tblPriemID]        INT             NOT NULL,
    [tblArtikalID]      INT             NOT NULL,
    [Kolicina]          DECIMAL (18, 2) NOT NULL,
    [NabavnaCenaBezDDV] DECIMAL (18, 2) NOT NULL,
    [NabavnaCenaSoDDV]  DECIMAL (18, 2) NOT NULL,
    [Rabat1]            DECIMAL (18, 2) NULL,
    [Rabat2]            DECIMAL (18, 2) NULL,
    [Rabat3]            DECIMAL (18, 2) NULL,
    [DataVersion]       NVARCHAR (MAX)  NULL);

