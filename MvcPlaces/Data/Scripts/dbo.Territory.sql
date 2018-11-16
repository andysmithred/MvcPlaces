CREATE TABLE [dbo].[Territory] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (50)   NOT NULL,
    [FullName]        NVARCHAR (MAX)  NULL,
    [NativeName]      NVARCHAR (MAX)  NULL,
    [ContinentId]     INT             NULL,
    [ParentId]        INT             NULL,
    [Population]      INT             NULL,
    [Area]            DECIMAL (18, 2) NULL,
    [ISOCode]         NVARCHAR (10)   NULL,
    [Latitude]        FLOAT (53)      NULL,
    [Longitude]       FLOAT (53)      NULL,
    [Zoom]            INT             NULL,
    [TerritoryTypeId] INT             NOT NULL,
    [GeoChartLevel] NVARCHAR(50) NULL, 
    [FlagId] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Territory_Continent] FOREIGN KEY ([ContinentId]) REFERENCES [dbo].[Continent] ([Id]),
    CONSTRAINT [FK_Territory_Territory] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[Territory] ([Id]),
    CONSTRAINT [FK_Territory_TerritoryType] FOREIGN KEY ([TerritoryTypeId]) REFERENCES [dbo].[TerritoryType] ([Id]),
	CONSTRAINT [FK_Territory_Flag] FOREIGN KEY ([FlagId]) REFERENCES [dbo].[Flag] ([Id])
);

