CREATE TYPE [dbo].[m_tblSmetka] AS TABLE (
    [ID]              INT             NULL,
    [Broj]            INT             NOT NULL,
    [DatumPocetok]    DATETIME        NOT NULL,
    [DatumKraj]       DATETIME        NULL,
    [tblUserID]       INT             NOT NULL,
    [Smena_ID]        INT             NOT NULL,
    [Zatvorena]       BIT             NULL,
    [FirmaID]         INT             NOT NULL,
    [ObjektID]        INT             NOT NULL,
    [Zabeleska]       NVARCHAR (MAX)  NULL,
    [ImaPopust]       INT             NULL,
    [ProcentNaPopust] DECIMAL (18, 2) NULL,
    [Izmeneta]        INT             NULL,
    [tblPartnerID]    INT             NULL,
    [KodNaDokument]   NVARCHAR (70)   NULL,
    [DataVersion]     NVARCHAR (MAX)  NULL);

