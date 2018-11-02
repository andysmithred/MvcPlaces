CREATE TABLE [dbo].[Continent] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    [Code] NVARCHAR (3)  DEFAULT ((0)) NOT NULL,
    [ParentId] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Continent_Continent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[Continent] ([Id])
);

