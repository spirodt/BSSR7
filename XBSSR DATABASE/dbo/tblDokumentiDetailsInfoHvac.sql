CREATE TABLE [dbo].[tblDokumentiDetailsInfoHvac] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [tblDokumentId]   INT             NULL,
    [Name]            NVARCHAR (50)   NULL,
    [Capacity]        DECIMAL (18, 2) NULL,
    [LowRun]          DECIMAL (18, 2) NULL,
    [LowRunTotal]     DECIMAL (18, 2) NULL,
    [HighRun]         DECIMAL (18, 2) NULL,
    [HighRunTotal]    DECIMAL (18, 2) NULL,
    [Note]            NVARCHAR (50)   NULL,
    [DateTimeCreated] DATETIME        CONSTRAINT [DF_tblDokumentiDetailsInfoHvac_DateTimeCreated] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_tblDokumentiDetailsInfoHvac] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__tblDokume__tblDo__3F9B6DFF] FOREIGN KEY ([tblDokumentId]) REFERENCES [dbo].[tblDokumenti] ([ID]) ON DELETE CASCADE
);




GO
CREATE NONCLUSTERED INDEX [FK__tblDokume__tblDo__408F9238]
    ON [dbo].[tblDokumentiDetailsInfoHvac]([tblDokumentId] ASC);


GO
CREATE NONCLUSTERED INDEX [FK__tblDokume__tblDo__3F9B6DFF]
    ON [dbo].[tblDokumentiDetailsInfoHvac]([tblDokumentId] ASC);

