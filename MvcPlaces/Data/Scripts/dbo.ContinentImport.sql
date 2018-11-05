CREATE TABLE [dbo].[Continent] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50) NOT NULL,
    [Area]       INT           NULL,
    [Population] FLOAT (53)    NULL,
    [Code]       NVARCHAR (3)  DEFAULT ((0)) NOT NULL,
    [ImportId] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

