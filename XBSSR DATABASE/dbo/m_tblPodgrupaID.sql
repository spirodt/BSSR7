CREATE TYPE [dbo].[m_tblPodgrupaID] AS TABLE (
    [ID]          INT            NULL,
    [GrupaID]     INT            NOT NULL,
    [Naziv]       NVARCHAR (50)  NOT NULL,
    [FirmaID]     INT            NOT NULL,
    [Status]      INT            NULL,
    [Image]       NVARCHAR (250) NULL,
    [DataVersion] NVARCHAR (MAX) NULL);

