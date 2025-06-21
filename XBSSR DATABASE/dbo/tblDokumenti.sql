CREATE TABLE [dbo].[tblDokumenti] (
    [ID]               INT            IDENTITY (1, 1) NOT NULL,
    [Broj]             INT            NOT NULL,
    [TipNaDokument]    INT            NOT NULL,
    [Datum]            DATE           NOT NULL,
    [OdObjektID]       INT            NOT NULL,
    [DoObjektID]       INT            NULL,
    [tblUserID]        INT            NOT NULL,
    [Zabeleska]        NVARCHAR (MAX) NULL,
    [tblPartnerID]     INT            NULL,
    [FirmaID]          INT            NOT NULL,
    [KodNaDokument]    NVARCHAR (70)  NULL,
    [BrojNaDokument]   NVARCHAR (50)  NULL,
    [DataVersion]      ROWVERSION     NOT NULL,
    [DateModified]     DATETIME       CONSTRAINT [DF_tblDokumenti_DateModified] DEFAULT (getdate()) NULL,
    [UniqueIdPlacanje] NVARCHAR (20)  NULL,
    [DatumNaValuta]    DATETIME       NULL,
    [DatumPeriod]      DATETIME       NULL,
    [Notes]            NVARCHAR (400) NULL,
    [tblDogovoriID]    INT            NULL,
    CONSTRAINT [PK_tblDokumenti] PRIMARY KEY CLUSTERED ([ID] ASC)
);










GO
CREATE NONCLUSTERED INDEX [FK_tblDokumenti_tblTipNaDokument]
    ON [dbo].[tblDokumenti]([TipNaDokument] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblArtikal_tblPartnerID]
    ON [dbo].[tblDokumenti]([tblPartnerID] ASC);

