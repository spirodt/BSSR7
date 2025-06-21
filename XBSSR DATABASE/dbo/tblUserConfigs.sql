CREATE TABLE [dbo].[tblUserConfigs] (
    [ID]             INT            IDENTITY (1, 1) NOT NULL,
    [UserID]         INT            NOT NULL,
    [ObjectName]     NVARCHAR (300) NOT NULL,
    [ConfigData]     NVARCHAR (MAX) NULL,
    [DateOfCreation] DATETIME       CONSTRAINT [DF_tblUserConfigs_DateOfCreation] DEFAULT (getdate()) NOT NULL,
    [DataVersion]    ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tblUserConfigs] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblUserConfigs_tblUsers] FOREIGN KEY ([UserID]) REFERENCES [dbo].[tblUsers] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE
);






GO
CREATE NONCLUSTERED INDEX [FK_tblUserConfigs_tblUsers]
    ON [dbo].[tblUserConfigs]([UserID] ASC);

