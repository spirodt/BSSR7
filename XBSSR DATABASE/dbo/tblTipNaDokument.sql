CREATE TABLE [dbo].[tblTipNaDokument] (
    [ID]             INT            IDENTITY (1, 1) NOT NULL,
    [Naziv]          NVARCHAR (50)  NOT NULL,
    [Status]         INT            NULL,
    [SeKnizi]        BIT            NOT NULL,
    [ReportFileName] NVARCHAR (70)  NULL,
    [TipNaKnizenje]  INT            NOT NULL,
    [FirmaID]        INT            NOT NULL,
    [Naslov]         NVARCHAR (200) NULL,
    [Interen]        INT            NOT NULL,
    [DataVersion]    ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tblTipNaDokument] PRIMARY KEY CLUSTERED ([ID] ASC)
);



