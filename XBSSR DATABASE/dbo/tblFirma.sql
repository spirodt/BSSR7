CREATE TABLE [dbo].[tblFirma] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [ImeNaFirma]    NVARCHAR (50) NOT NULL,
    [DanocenBroj]   NVARCHAR (50) NULL,
    [BankaDeponent] NVARCHAR (50) NULL,
    [Grad]          NVARCHAR (50) NULL,
    [Adresa]        NVARCHAR (50) NULL,
    [PostenskiBroj] NVARCHAR (50) NULL,
    [Telefon]       NVARCHAR (50) NULL,
    [Faks]          NVARCHAR (50) NULL,
    [EMail]         NVARCHAR (50) NULL,
    [MaticenBroj]   NVARCHAR (50) NULL,
    [Status]        INT           NULL,
    [Image1]        IMAGE         NULL,
    [Image2]        IMAGE         NULL,
    [Image3]        IMAGE         NULL,
    [ZiroSmetka]    NVARCHAR (20) NULL,
    [txIDFirma]     NVARCHAR (40) NULL,
    [DataVersion]   ROWVERSION    NOT NULL,
    CONSTRAINT [PK_tblFirma] PRIMARY KEY CLUSTERED ([ID] ASC)
);



