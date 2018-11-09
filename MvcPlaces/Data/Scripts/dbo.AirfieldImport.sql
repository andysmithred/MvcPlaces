CREATE TABLE [dbo].[Airfield] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (MAX) NOT NULL,
    [RegionId]   INT            NOT NULL,
    [Elevation]  INT            NULL,
    [IataCode]   NVARCHAR (3)   NULL,
    [Type]       NVARCHAR (MAX) NULL,
    [Latitude]   FLOAT (53)     NULL,
    [Longitude]  FLOAT (53)     NULL,
    [BaseId]     INT            NULL,
    [IcaoCode]   NVARCHAR (4)   NULL,
    [Prominence] INT            DEFAULT ((0)) NOT NULL,
    [ImportId] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Airfield_To_Region] FOREIGN KEY ([RegionId]) REFERENCES [dbo].[Region] ([Id]),
    CONSTRAINT [FK_Airfield_To_Base] FOREIGN KEY ([BaseId]) REFERENCES [dbo].[Base] ([Id])
);

