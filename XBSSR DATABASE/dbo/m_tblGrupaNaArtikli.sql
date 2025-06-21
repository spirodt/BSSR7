CREATE TYPE [dbo].[m_tblGrupaNaArtikli] AS TABLE (
    [ID]          INT            NULL,
    [Naziv]       NVARCHAR (50)  NOT NULL,
    [Sifra]       NVARCHAR (20)  NULL,
    [Status]      INT            NULL,
    [FirmaID]     INT            NOT NULL,
    [Image]       NVARCHAR (250) NULL,
    [DataVersion] NVARCHAR (MAX) NULL);

