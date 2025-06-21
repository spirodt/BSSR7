CREATE TABLE [dbo].[changelog] (
    [change_number] INT           NOT NULL,
    [complete_dt]   DATETIME      NULL,
    [applied_by]    VARCHAR (100) NOT NULL,
    [description]   VARCHAR (500) NOT NULL,
    CONSTRAINT [Pkchangelog] PRIMARY KEY CLUSTERED ([change_number] ASC)
);

