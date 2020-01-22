CREATE TABLE [dbo].[RouteLeg]
(
	[Id]                    INT            IDENTITY (1, 1) NOT NULL,
    [Number]                INT            NOT NULL,
    [RouteId]               INT            NOT NULL,
    [OriginId]      INT            NOT NULL,
    [DestinationId] INT            NOT NULL,
    [Description]           NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_RouteLeg_ToRoute] FOREIGN KEY ([RouteId]) REFERENCES [dbo].[Route] ([Id]),
    CONSTRAINT [FK_RouteLeg_ToOrigin] FOREIGN KEY ([OriginId]) REFERENCES [dbo].[Place] ([Id]),
    CONSTRAINT [FK_RouteLeg_ToDestination] FOREIGN KEY ([DestinationId]) REFERENCES [dbo].[Place] ([Id])
)
