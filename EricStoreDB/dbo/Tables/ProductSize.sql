CREATE TABLE [dbo].[ProductSize]
(
	[ProductId] INT NOT NULL, 
	Size Float Not Null, 
    CONSTRAINT [PK_ProductSize] PRIMARY KEY ([ProductId], [Size]),
    CONSTRAINT [FK_ProductSize_Product] FOREIGN KEY (ProductId) REFERENCES Product(ID)
)
