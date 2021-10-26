﻿CREATE TABLE [dbo].[T_MovPazienti] (
    [ID]                    UNIQUEIDENTIFIER NOT NULL,
    [IDNum]                 INT              IDENTITY (1, 1) NOT NULL,
    [IDEpisodio]            UNIQUEIDENTIFIER NULL,
    [IDPaziente]            UNIQUEIDENTIFIER NULL,
    [CodSAC]                VARCHAR (50)     NULL,
    [Cognome]               VARCHAR (255)    NOT NULL,
    [Nome]                  VARCHAR (255)    NOT NULL,
    [Sesso]                 CHAR (1)         NULL,
    [DataNascita]           DATETIME         NULL,
    [CodiceFiscale]         VARCHAR (20)     NULL,
    [CodComuneNascita]      VARCHAR (10)     NULL,
    [ComuneNascita]         VARCHAR (255)    NULL,
    [LocalitaNascita]       VARCHAR (255)    NULL,
    [CodProvinciaNascita]   VARCHAR (10)     NULL,
    [ProvinciaNascita]      VARCHAR (50)     NULL,
    [CAPDomicilio]          VARCHAR (10)     NULL,
    [CodComuneDomicilio]    VARCHAR (10)     NULL,
    [ComuneDomicilio]       VARCHAR (255)    NULL,
    [IndirizzoDomicilio]    VARCHAR (255)    NULL,
    [LocalitaDomicilio]     VARCHAR (255)    NULL,
    [CodProvinciaDomicilio] VARCHAR (10)     NULL,
    [ProvinciaDomicilio]    VARCHAR (50)     NULL,
    [CodRegioneDomicilio]   VARCHAR (10)     NULL,
    [RegioneDomicilio]      VARCHAR (50)     NULL,
    [CAPResidenza]          VARCHAR (10)     NULL,
    [CodComuneResidenza]    VARCHAR (10)     NULL,
    [ComuneResidenza]       VARCHAR (255)    NULL,
    [IndirizzoResidenza]    VARCHAR (255)    NULL,
    [LocalitaResidenza]     VARCHAR (255)    NULL,
    [CodProvinciaResidenza] VARCHAR (10)     NULL,
    [ProvinciaResidenza]    VARCHAR (50)     NULL,
    [CodRegioneResidenza]   VARCHAR (10)     NULL,
    [RegioneResidenza]      VARCHAR (50)     NULL,
    [Foto]                  VARBINARY (MAX)  NULL,
    [CodMedicoBase]         VARCHAR (50)     NULL,
    [CodFiscMedicoBase]     VARCHAR (20)     NULL,
    [CognomeNomeMedicoBase] VARCHAR (255)    NULL,
    [DistrettoMedicoBase]   VARCHAR (255)    NULL,
    [DataSceltaMedicoBase]  DATETIME         NULL,
    [ElencoEsenzioni]       VARCHAR (MAX)    NULL,
    [DataDecesso]           DATETIME         NULL,
    CONSTRAINT [PK_T_MovPazienti] PRIMARY KEY NONCLUSTERED ([ID] ASC),
    CONSTRAINT [FK_T_MovPazienti_T_MovEpisodi] FOREIGN KEY ([IDEpisodio]) REFERENCES [dbo].[T_MovEpisodi] ([ID]),
    CONSTRAINT [FK_T_MovPazienti_T_Pazienti] FOREIGN KEY ([IDPaziente]) REFERENCES [dbo].[T_Pazienti] ([ID])
);




GO
CREATE NONCLUSTERED INDEX [IX_CodSAC]
    ON [dbo].[T_MovPazienti]([CodSAC] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CodiceFiscale]
    ON [dbo].[T_MovPazienti]([CodiceFiscale] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Paziente]
    ON [dbo].[T_MovPazienti]([IDPaziente] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Cognome]
    ON [dbo].[T_MovPazienti]([Cognome] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_DataNascita]
    ON [dbo].[T_MovPazienti]([DataNascita] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CognomeNome]
    ON [dbo].[T_MovPazienti]([Cognome] ASC, [Nome] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Episodio]
    ON [dbo].[T_MovPazienti]([IDEpisodio] ASC);


GO
CREATE UNIQUE CLUSTERED INDEX [IX_IDNum]
    ON [dbo].[T_MovPazienti]([IDNum] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_IDEpisodioCongomeNomeCodiceFiscale]
    ON [dbo].[T_MovPazienti]([IDEpisodio] ASC, [Cognome] ASC, [Nome] ASC, [CodiceFiscale] ASC);

