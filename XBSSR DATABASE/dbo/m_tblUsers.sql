CREATE TYPE [dbo].[m_tblUsers] AS TABLE (
    [ID]                   INT            NULL,
    [UserName]             NVARCHAR (25)  NOT NULL,
    [Password]             NVARCHAR (25)  NOT NULL,
    [FullName]             NVARCHAR (50)  NOT NULL,
    [NivoNaAdministracija] INT            NOT NULL,
    [Status]               INT            NULL,
    [FirmaID]              INT            NOT NULL,
    [tblObjektId]          INT            NULL,
    [DataVersion]          NVARCHAR (MAX) NULL);

