CREATE TYPE [dbo].[m_tblPartneri] AS TABLE (
    [ID]                       INT            NULL,
    [Sifra]                    NVARCHAR (20)  NULL,
    [Naziv]                    NVARCHAR (150) NOT NULL,
    [Adresa]                   NVARCHAR (50)  NULL,
    [Telefoni]                 NVARCHAR (70)  NULL,
    [Email]                    NVARCHAR (50)  NULL,
    [EDB]                      NVARCHAR (18)  NULL,
    [Mesto]                    NVARCHAR (25)  NULL,
    [Tip]                      INT            NOT NULL,
    [Status]                   INT            NULL,
    [FirmaID]                  INT            NOT NULL,
    [tblPresmetkovnaEdinicaID] INT            NULL,
    [DataVersion]              NVARCHAR (MAX) NULL);

