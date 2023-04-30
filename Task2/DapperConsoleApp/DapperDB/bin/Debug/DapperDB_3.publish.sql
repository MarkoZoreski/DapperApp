﻿/*
Deployment script for DapperDB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DapperDB"
:setvar DefaultFilePrefix "DapperDB"
:setvar DefaultDataPath "C:\Users\Marko\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\mssqllocaldb\"
:setvar DefaultLogPath "C:\Users\Marko\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\mssqllocaldb\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'The following operation was generated from a refactoring log file 61954b6d-9f92-41a8-ba43-7ca7f343e80e';

PRINT N'Rename [dbo].[Order].[ShipAdress] to ShipAddress';


GO
EXECUTE sp_rename @objname = N'[dbo].[Order].[ShipAdress]', @newname = N'ShipAddress', @objtype = N'COLUMN';


GO
-- Refactoring step to update target server with deployed transaction logs
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '61954b6d-9f92-41a8-ba43-7ca7f343e80e')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('61954b6d-9f92-41a8-ba43-7ca7f343e80e')

GO

GO
PRINT N'Update complete.';


GO