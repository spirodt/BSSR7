CREATE TABLE [dbo].[tblDokumentStavkiDetailsInfo] (
    [ID]                  INT            IDENTITY (1, 1) NOT NULL,
    [tblDokumentId]       INT            NOT NULL,
    [tblDokumentStavkiId] INT            NOT NULL,
    [NotesText]           NVARCHAR (350) NULL,
    [NotesBroj]           NVARCHAR (150) NULL,
    [NotesID]             INT            NULL,
    [NotesREF]            INT            NULL,
    [DataVersion]         ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tblDokumentStavkiDetailsInfo] PRIMARY KEY CLUSTERED ([ID] ASC)
);

