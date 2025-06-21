CREATE TABLE [dbo].[tblIzvodiStavki] (
    [ID]             INT             IDENTITY (1, 1) NOT NULL,
    [tblIzvodiID]    INT             NOT NULL,
    [PartnerID]      INT             NOT NULL,
    [Dolzi]          DECIMAL (18, 2) NOT NULL,
    [Pobaruva]       DECIMAL (18, 2) NOT NULL,
    [DokumentID]     INT             NULL,
    [FakturaID]      INT             NULL,
    [PriemID]        INT             NULL,
    [TipNaDokument]  INT             NULL,
    [BrojNaDokument] NVARCHAR (150)  NOT NULL,
    [DataVersion]    ROWVERSION      NOT NULL,
    CONSTRAINT [PK_tblIzvodiStavki] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblIzvodiStavki_tblIzvodi] FOREIGN KEY ([tblIzvodiID]) REFERENCES [dbo].[tblIzvodi] ([ID]),
    CONSTRAINT [FK_tblIzvodiStavki_tblPartneri] FOREIGN KEY ([PartnerID]) REFERENCES [dbo].[tblPartneri] ([ID])
);






GO
CREATE NONCLUSTERED INDEX [FK_tblIzvodiStavki_tblPartneri]
    ON [dbo].[tblIzvodiStavki]([PartnerID] ASC);


GO
CREATE NONCLUSTERED INDEX [FK_tblIzvodiStavki_tblIzvodi]
    ON [dbo].[tblIzvodiStavki]([tblIzvodiID] ASC);

