CREATE TABLE [dbo].[Place] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (MAX) NOT NULL,
	[LocalName] NVARCHAR(MAX) NULL,
    [Latitude]  FLOAT (53)     NULL,
    [Longitude] FLOAT (53)     NULL,
    [Zoom] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);