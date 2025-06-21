CREATE TYPE [dbo].[m_tblBanki] AS TABLE (
    [ID]          INT            NULL,
    [Sifra]       NVARCHAR (20)  NULL,
    [Naziv]       NVARCHAR (100) NOT NULL,
    [Status]      INT            NULL,
    [FirmaID]     INT            NOT NULL,
    [DataVersion] NVARCHAR (MAX) NULL);

