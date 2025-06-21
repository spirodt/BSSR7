CREATE TYPE [dbo].[m_tblFaktura] AS TABLE (
    [ID]                INT            NULL,
    [Broj]              INT            NOT NULL,
    [Datum]             DATE           NOT NULL,
    [tblPartnerID]      INT            NOT NULL,
    [tblZiroSmetkaID]   INT            NULL,
    [tblBankaID]        INT            NULL,
    [tblUserID]         INT            NOT NULL,
    [Valuta]            DATE           NOT NULL,
    [Zabeleska]         NVARCHAR (MAX) NULL,
    [ListaNaIspratnici] NVARCHAR (150) NULL,
    [KodNaDokument]     NVARCHAR (70)  NULL,
    [DataVersion]       NVARCHAR (MAX) NULL);

