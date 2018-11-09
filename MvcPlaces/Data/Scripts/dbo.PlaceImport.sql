CREATE TABLE [dbo].[Place] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (MAX) NOT NULL,
    [RegionId]  INT            NOT NULL,
    [Latitude]  FLOAT (53)     NULL,
    [Longitude] FLOAT (53)     NULL,
    [ImportId] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Place_ToRegion] FOREIGN KEY ([RegionId]) REFERENCES [dbo].[Region] ([Id])
);

