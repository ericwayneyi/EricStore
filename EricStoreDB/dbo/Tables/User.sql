CREATE TABLE [dbo].[User] (
    [ID]    INT           IDENTITY (1, 1) NOT NULL,
    [Email] NVARCHAR (56) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    UNIQUE NONCLUSTERED ([Email] ASC)
);

