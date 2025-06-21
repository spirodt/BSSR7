CREATE TYPE [dbo].[m_tblDokumenti] AS TABLE (
    [ID]             INT            NULL,
    [Broj]           INT            NOT NULL,
    [TipNaDokument]  INT            NOT NULL,
    [Datum]          DATE           NOT NULL,
    [OdObjektID]     INT            NOT NULL,
    [DoObjektID]     INT            NULL,
    [tblUserID]      INT            NOT NULL,
    [Zabeleska]      NVARCHAR (MAX) NULL,
    [tblPartnerID]   INT            NULL,
    [FirmaID]        INT            NOT NULL,
    [KodNaDokument]  NVARCHAR (70)  NULL,
    [BrojNaDokument] NVARCHAR (50)  NULL,
    [DataVersion]    NVARCHAR (MAX) NULL);

