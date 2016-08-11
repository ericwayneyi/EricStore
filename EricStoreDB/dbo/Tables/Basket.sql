CREATE TABLE [dbo].[Basket]
(
	[Id] INT Identity (1,1) NOT NULL PRIMARY KEY, 
    [UserId] INT NOT NULL, 
    CONSTRAINT [FK_Basket_User] FOREIGN KEY (UserId) REFERENCES [User](ID) ,
	

)
