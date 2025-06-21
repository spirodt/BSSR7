CREATE TABLE [dbo].[tblDokumentiDetailsInfo] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [tblDokumentId]   INT             NOT NULL,
    [WaterMeter]      NVARCHAR (50)   NULL,
    [WaterMeterOld]   DECIMAL (18, 2) NULL,
    [WaterMeterNew]   DECIMAL (18, 2) NULL,
    [DateTimeCreated] DATETIME        CONSTRAINT [DF_tblDokumentiDetailsInfo_DateTimeCreated] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_tblDokumentiDetailsInfo] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__tblDokume__tblDo__408F9238] FOREIGN KEY ([tblDokumentId]) REFERENCES [dbo].[tblDokumenti] ([ID]) ON DELETE CASCADE
);




GO
CREATE NONCLUSTERED INDEX [FK__tblDokume__tblDo__408F9238]
    ON [dbo].[tblDokumentiDetailsInfo]([tblDokumentId] ASC);

