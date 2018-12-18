CREATE TABLE [dbo].[DriveLeg] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Number]        INT            NOT NULL,
    [DriveId]       INT            NOT NULL,
    [OriginId]      INT            NOT NULL,
    [DestinationId] INT            NOT NULL,
    [Description]   NVARCHAR (MAX) NULL,
    [ImportId] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_DriveLeg_ToDrive] FOREIGN KEY ([DriveId]) REFERENCES [dbo].[Drive] ([Id]),
    CONSTRAINT [FK_DriveLeg_ToPlace_Destination] FOREIGN KEY ([DestinationId]) REFERENCES [dbo].[Place] ([Id]),
    CONSTRAINT [FK_DriveLeg_ToPlace_Origin] FOREIGN KEY ([OriginId]) REFERENCES [dbo].[Place] ([Id])
);

