CREATE TABLE [dbo].[tblPrevodi] (
    [ID]         INT            IDENTITY (1, 1) NOT FOR REPLICATION NOT NULL,
    [KlucenZbor] NVARCHAR (150) NULL,
    [MK]         NVARCHAR (250) NULL,
    [AL]         NVARCHAR (250) NULL,
    [EN]         NVARCHAR (250) NULL,
    [SR]         NVARCHAR (250) NULL,
    CONSTRAINT [PK_tblPrevodi] PRIMARY KEY CLUSTERED ([ID] ASC)
);





