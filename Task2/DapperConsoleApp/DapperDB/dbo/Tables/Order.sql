CREATE TABLE [dbo].[Order]
(
	[OrderID] INT NOT NULL PRIMARY KEY identity, 
    [CustomerID] INT NOT NULL, 
    [EmployeeID] INT NOT NULL, 
    [OrderDate] DATETIME NOT NULL, 
    [RequiredDate] DATETIME NOT NULL, 
    [ShippedDate] DATETIME NOT NULL, 
    [ShipVia] NCHAR(50) NOT NULL, 
    [Freight] FLOAT NOT NULL, 
    [ShipName] NCHAR(50) NULL, 
    [ShipAddress] NCHAR(50) NULL, 
    [ShipCity] NCHAR(50) NULL, 
    [ShipRegion] NCHAR(50) NULL, 
    [ShipPostalCode] NCHAR(50) NULL, 
    [ShipCountry] NCHAR(50) NULL
)
