CREATE TABLE [dbo].[tblClientConfiguracija] (
    [ID]      INT            IDENTITY (1, 1) NOT NULL,
    [Setting] NVARCHAR (MAX) NULL,
    [Value]   NVARCHAR (MAX) NULL,
    [Info]    NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

