CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(10) NOT NULL, 
    [UnitPrice] MONEY NOT NULL, 
    [StockAmount] INT NOT NULL
)
