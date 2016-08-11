CREATE TABLE [dbo].[Review] (
    [ID]        INT           NOT NULL,
    [ProductID] INT           NOt NULL,
    [Stars]     INT            NULL,
    [Body]      NTEXT          NULL,
    UserId Int not NULL, 
	Constraint fk_Product Foreign Key (ProductID) References Product(ID),
	Constraint fk_ReviewUser Foreign Key (UserId) References [User](ID),
	Constraint pk_Review Primary Key (ID)
);

