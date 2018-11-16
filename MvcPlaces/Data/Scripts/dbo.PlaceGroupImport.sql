CREATE TABLE [dbo].[PlaceGroup] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [ImportId] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

