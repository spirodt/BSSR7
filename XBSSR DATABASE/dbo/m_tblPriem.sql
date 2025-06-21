CREATE TYPE [dbo].[m_tblPriem] AS TABLE (
    [ID]                      INT             NULL,
    [PriemBroj]               INT             NOT NULL,
    [PriemDatum]              DATETIME        NOT NULL,
    [tblPartnerID]            INT             NOT NULL,
    [tblUserID]               INT             NOT NULL,
    [ObjektID]                INT             NOT NULL,
    [IspratnicaFakturaBroj]   NVARCHAR (50)   NULL,
    [IspratnicaFakturaDatum]  DATETIME        NULL,
    [ValutaDenovi]            INT             NULL,
    [KalkulacijaBroj]         INT             NULL,
    [Zabeleska]               NVARCHAR (50)   NULL,
    [VkupenIznos]             DECIMAL (18, 2) NULL,
    [DatumNaDospeanost]       DATETIME        NULL,
    [DatumNaKreiranjeNaPriem] DATETIME        NULL,
    [KodNaDokument]           NVARCHAR (70)   NULL,
    [DataVersion]             NVARCHAR (MAX)  NULL);

