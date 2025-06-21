CREATE TYPE [dbo].[tblFiskalniSmetki_BulkType] AS TABLE (
    [ID]                         INT             NOT NULL,
    [Broj]                       INT             NULL,
    [Datum]                      DATETIME        NULL,
    [Iznos]                      DECIMAL (18, 2) NULL,
    [Stornirana]                 BIT             NULL,
    [tblSmetkaID]                INT             NULL,
    [FirmaID]                    INT             NULL,
    [sync_update_peer_timestamp] BIGINT          NULL,
    [sync_update_peer_key]       INT             NULL,
    [sync_create_peer_timestamp] BIGINT          NULL,
    [sync_create_peer_key]       INT             NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC));

