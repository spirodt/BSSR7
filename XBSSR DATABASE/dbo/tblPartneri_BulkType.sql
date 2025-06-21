CREATE TYPE [dbo].[tblPartneri_BulkType] AS TABLE (
    [ID]                         INT            NOT NULL,
    [Sifra]                      NVARCHAR (5)   NULL,
    [Naziv]                      NVARCHAR (150) NULL,
    [Adresa]                     NVARCHAR (50)  NULL,
    [Telefoni]                   NVARCHAR (70)  NULL,
    [Email]                      NVARCHAR (50)  NULL,
    [EDB]                        NVARCHAR (18)  NULL,
    [Mesto]                      NVARCHAR (25)  NULL,
    [Tip]                        INT            NULL,
    [Status]                     INT            NULL,
    [FirmaID]                    INT            NULL,
    [sync_update_peer_timestamp] BIGINT         NULL,
    [sync_update_peer_key]       INT            NULL,
    [sync_create_peer_timestamp] BIGINT         NULL,
    [sync_create_peer_key]       INT            NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC));

