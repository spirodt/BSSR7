CREATE TABLE [dbo].[tblZiroSmetki] (
    [ID]           INT           IDENTITY (1, 1) NOT NULL,
    [ZiroSmetka]   NVARCHAR (15) NOT NULL,
    [tblPartnerID] INT           NOT NULL,
    [tblBankaID]   INT           NOT NULL,
    [FirmaID]      INT           NOT NULL,
    [Status]       NCHAR (10)    NULL,
    [DataVersion]  ROWVERSION    NOT NULL,
    CONSTRAINT [PK_tblZiroSmetki] PRIMARY KEY CLUSTERED ([ID] ASC)
);



