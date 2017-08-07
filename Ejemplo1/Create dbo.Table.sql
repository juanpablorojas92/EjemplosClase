USE [Pizzeria]
GO

/****** Objeto: Table [dbo].[Table] Fecha del script: 07/08/2017 11:29:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pizza] (
    [GuID]  VARCHAR(32)           NOT NULL,
    [Name]  NCHAR (24)     NOT NULL,
    [Price] DECIMAL (8, 4) NOT NULL,
    [Size]  DECIMAL (4, 4) NULL
);
GO

