CREATE TABLE [dbo].[_tblLog] (
    [ID]          BIGINT           IDENTITY (1, 1) NOT NULL,
    [Sesija]      UNIQUEIDENTIFIER NOT NULL,
    [Akcija]      NVARCHAR (MAX)   NOT NULL,
    [DatumIVreme] DATETIME         NOT NULL,
    [Status]      INT              NULL,
    CONSTRAINT [PK__tblLog] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK__tblLog__tblSesija] FOREIGN KEY ([Sesija]) REFERENCES [dbo].[_tblSesija] ([Sesija]) ON DELETE CASCADE ON UPDATE CASCADE
);

