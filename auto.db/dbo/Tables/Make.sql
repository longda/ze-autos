﻿CREATE TABLE [dbo].[Make] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (128) CONSTRAINT [DF_Make_Name] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_Make] PRIMARY KEY CLUSTERED ([Id] ASC)
);

