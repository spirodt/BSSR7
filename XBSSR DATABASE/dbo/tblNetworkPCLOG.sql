CREATE TABLE [dbo].[tblNetworkPCLOG] (
    [ID]             INT           IDENTITY (1, 1) NOT NULL,
    [Akcija]         NVARCHAR (50) NULL,
    [tblNetworkPCID] INT           NULL,
    [Datum]          DATETIME      NULL,
    [StartTime]      DATETIME      NULL,
    [EndTime]        DATETIME      NULL,
    [DataVersion]    ROWVERSION    NOT NULL,
    CONSTRAINT [PK_tblNetworkPCLOG] PRIMARY KEY CLUSTERED ([ID] ASC)
);



