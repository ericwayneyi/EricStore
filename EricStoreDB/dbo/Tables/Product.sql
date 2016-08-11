CREATE TABLE [dbo].[Product] (
    [ID]          INT            NOT NULL,
    [Name]        NVARCHAR (200) NULL,
    [Price]       SMALLMONEY     NULL,
    [Description] NVARCHAR (200) NULL,
    [CanPurchase] BIT            NULL,
    [SoldOut]     BIT            NULL, 
	[Full]      NVARCHAR (256) NULL,
    [Thumb]     NVARCHAR (256) NULL
    CONSTRAINT [PK_Product] PRIMARY KEY (ID)
);

