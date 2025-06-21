CREATE TABLE [dbo].[tblNetworkPC] (
    [ID]             INT           IDENTITY (1, 1) NOT NULL,
    [PCName]         NVARCHAR (50) NULL,
    [HostName]       NVARCHAR (50) NULL,
    [IPAddres]       NVARCHAR (25) NULL,
    [Number]         INT           NULL,
    [Status]         INT           NULL,
    [FirmaID]        INT           NULL,
    [StartTime]      DATETIME      NULL,
    [EndTime]        DATETIME      NULL,
    [PoslednaSmetka] INT           NULL,
    [tblArtikalID]   INT           NULL,
    [R_UserName]     NVARCHAR (50) NULL,
    [R_PassWord]     NVARCHAR (50) NULL,
    [ClientPassword] NVARCHAR (50) NULL,
    [Grupa]          NVARCHAR (50) NULL,
    [DataVersion]    ROWVERSION    NOT NULL,
    CONSTRAINT [PK_tblNetworkPC] PRIMARY KEY CLUSTERED ([ID] ASC)
);








GO
