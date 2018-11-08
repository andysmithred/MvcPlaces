CREATE TABLE [dbo].[Territory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [FullName] NVARCHAR(MAX) NULL, 
    [NativeName] NVARCHAR(MAX) NULL, 
    [ContinentId] INT NULL, 
    [ParentId] INT NULL, 
    [Population] INT NULL, 
    [Area] DECIMAL(18, 2) NULL, 
    [ISOCode] NVARCHAR(10) NULL, 
    [Latitude] FLOAT NULL, 
    [Longitude] FLOAT NULL, 
    [Zoom] INT NULL, 
    [TerritoryTypeId] INT NOT NULL,
	CONSTRAINT [FK_Territory_Continent] FOREIGN KEY ([ContinentId]) REFERENCES [dbo].[Continent] ([Id]),
	CONSTRAINT [FK_Territory_Territory] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[Territory] ([Id]),
	CONSTRAINT [FK_Territory_TerritoryType] FOREIGN KEY ([TerritoryTypeId]) REFERENCES [dbo].[TerritoryType] ([Id])
)
