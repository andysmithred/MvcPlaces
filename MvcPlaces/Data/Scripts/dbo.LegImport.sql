CREATE TABLE [dbo].[Leg] (
    [Id]                    INT            IDENTITY (1, 1) NOT NULL,
    [Number]                INT            NOT NULL,
    [RouteId]               INT            NOT NULL,
    [OriginAirfieldId]      INT            NOT NULL,
    [DestinationAirfieldId] INT            NOT NULL,
    [Description]           NVARCHAR (MAX) NULL,
    [ImportId] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Leg_ToRoute] FOREIGN KEY ([RouteId]) REFERENCES [dbo].[Route] ([Id]),
    CONSTRAINT [FK_Leg_ToAirfieldOrigin] FOREIGN KEY ([OriginAirfieldId]) REFERENCES [dbo].[Airfield] ([Id]),
    CONSTRAINT [FK_Leg_ToAirfieldDestination] FOREIGN KEY ([DestinationAirfieldId]) REFERENCES [dbo].[Airfield] ([Id])
);

