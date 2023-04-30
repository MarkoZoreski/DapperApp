CREATE TABLE [dbo].[Product]
(
	[ProductID]         INT NOT NULL PRIMARY KEY Identity, 
    [ProductName]       NCHAR(50) NOT NULL, 
    [SupplierID]        INT NULL, 
    [CategoryID]        INT NOT NULL, 
    [QuantityPerUnit] INT NOT NULL, 
    [UnitPrice]         INT NOT NULL, 
    [UnitsInStock]          INT NOT NULL, 
    [UnitsOnOrder]          INT NOT NULL, 
    [ReorderLevel]          INT NOT NULL, 
    [Discontinued]          BIT NULL, 
    [LastUserId]            INT NULL, 
    [LastDateUpdated]           DATETIME NULL
    Constraint fk_categoryid Foreign key (CategoryID) References Category([CategoryID])
)
