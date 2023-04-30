CREATE TABLE [dbo].[OrderDetails]
(
	[OrderDetailsID] INT NOT NULL PRIMARY KEY identity, 
    [OrderID] INT NOT NULL ,
    [ProductID] INT NOT NULL, 
    [UnitPrice] FLOAT NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Discount] FLOAT NULL, 
    CONSTRAINT [fk_orderid] FOREIGN KEY (OrderID) REFERENCES [Order]([OrderID]),
    CONSTRAINT [fk_productid] FOREIGN KEY (ProductID) REFERENCES [Product]([ProductID])

)
