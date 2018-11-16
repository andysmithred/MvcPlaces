CREATE TABLE [dbo].[PlaceGroupSet] (
    [Id]      INT IDENTITY (1, 1) NOT NULL,
    [GroupId] INT NOT NULL,
    [PlaceId] INT NOT NULL,
    [ImportId] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PlaceGroupSet_ToPlaceGroup] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[PlaceGroup] ([Id]),
    CONSTRAINT [FK_PlaceGroupSet_ToPlace] FOREIGN KEY ([PlaceId]) REFERENCES [dbo].[Place] ([Id])
);

