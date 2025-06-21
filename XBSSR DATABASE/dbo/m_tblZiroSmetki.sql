CREATE TYPE [dbo].[m_tblZiroSmetki] AS TABLE (
    [ID]           INT            NULL,
    [ZiroSmetka]   NVARCHAR (15)  NOT NULL,
    [tblPartnerID] INT            NOT NULL,
    [tblBankaID]   INT            NOT NULL,
    [FirmaID]      INT            NOT NULL,
    [Status]       NCHAR (10)     NULL,
    [DataVersion]  NVARCHAR (MAX) NULL);

