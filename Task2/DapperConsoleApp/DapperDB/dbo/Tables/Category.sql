﻿CREATE TABLE [dbo].[Category]
(
	[CategoryID] INT NOT NULL PRIMARY KEY Identity, 
    [CategoryName] NCHAR(50) NOT NULL, 
    [Description] NCHAR(50) NULL, 
    [Picture] NCHAR(50) NULL
)
