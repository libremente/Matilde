﻿CREATE TABLE [dbo].[T_StatoConsensoCalcolato] (
    [Codice]      VARCHAR (20)    NOT NULL,
    [Descrizione] VARCHAR (255)   NULL,
    [Icona]       VARBINARY (MAX) NULL,
    CONSTRAINT [PK_T_StatoConsensoCalcolato] PRIMARY KEY CLUSTERED ([Codice] ASC)
);

