CREATE TABLE [dbo].[tblZabeleshki] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Tip]         NVARCHAR (512) NOT NULL,
    [Zabeleshka]  NVARCHAR (512) NOT NULL,
    [DataVersion] ROWVERSION     NOT NULL
);



