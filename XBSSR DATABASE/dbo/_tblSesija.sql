CREATE TABLE [dbo].[_tblSesija] (
    [ID]       BIGINT           IDENTITY (1, 1) NOT NULL,
    [Sesija]   UNIQUEIDENTIFIER CONSTRAINT [DF__tblSesija_Sesija] DEFAULT (newid()) ROWGUIDCOL NOT NULL,
    [Pocnata]  DATETIME         CONSTRAINT [DF__tblSesija_Pocnata] DEFAULT (getdate()) NOT NULL,
    [FirmaID]  INT              CONSTRAINT [DF__tblSesija_FirmaID] DEFAULT ((1)) NOT NULL,
    [UserID]   INT              NOT NULL,
    [Zavrsena] DATETIME         NULL,
    CONSTRAINT [PK__tblSesija] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [IX__tblSesija] UNIQUE NONCLUSTERED ([Sesija] ASC)
);

