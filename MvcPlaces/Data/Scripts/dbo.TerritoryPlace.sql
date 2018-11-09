CREATE TABLE [dbo].[TerritoryPlace]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TerritoryId] INT NOT NULL, 
    [PlaceId] INT NOT NULL,
	CONSTRAINT [FK_TerritoryPlace_Territory] FOREIGN KEY ([TerritoryId]) REFERENCES [dbo].[Territory] ([Id]),
	CONSTRAINT [FK_TerritoryPlace_Place] FOREIGN KEY ([PlaceId]) REFERENCES [dbo].[Place] ([Id])
)
