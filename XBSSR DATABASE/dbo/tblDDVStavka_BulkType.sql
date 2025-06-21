CREATE TYPE [dbo].[tblDDVStavka_BulkType] AS TABLE (
    [ID]                         INT            NOT NULL,
    [Naziv]                      NVARCHAR (20)  NULL,
    [Procent]                    DECIMAL (4, 2) NULL,
    [FirmaID]                    INT            NULL,
    [Grupa]                      INT            NULL,
    [sync_update_peer_timestamp] BIGINT         NULL,
    [sync_update_peer_key]       INT            NULL,
    [sync_create_peer_timestamp] BIGINT         NULL,
    [sync_create_peer_key]       INT            NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC));

