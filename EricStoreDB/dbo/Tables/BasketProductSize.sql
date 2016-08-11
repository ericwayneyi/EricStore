CREATE TABLE [dbo].[BasketProductSize]
(
	[BasketId] INT NOT NULL, 
    [ProductId] INT NOT NULL, 
    [Size] FLOAT NOT NULL, 
    [Quantity ] INT NOT NULL DEFAULT 1, 
    CONSTRAINT [PK_BasketProductSize] PRIMARY KEY ([Size], [BasketId], [ProductId]), 
    CONSTRAINT [FK_BasketProductSize_Basket] FOREIGN KEY (BasketId) REFERENCES Basket(Id), 
    CONSTRAINT [FK_BasketProductSize_Product] FOREIGN KEY (ProductId) REFERENCES Product(ID),

)
