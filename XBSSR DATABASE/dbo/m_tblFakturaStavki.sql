CREATE TYPE [dbo].[m_tblFakturaStavki] AS TABLE (
    [ID]           INT             NULL,
    [tblFakturaID] INT             NOT NULL,
    [tblArtikalID] INT             NOT NULL,
    [Normativ]     BIT             NOT NULL,
    [Kolicina]     DECIMAL (18, 2) NOT NULL,
    [Iznos]        DECIMAL (18, 2) NOT NULL,
    [Rabat1]       DECIMAL (18, 2) NULL,
    [Rabat2]       DECIMAL (18, 2) NULL,
    [Rabat3]       DECIMAL (18, 2) NULL,
    [DataVersion]  NVARCHAR (MAX)  NULL);

