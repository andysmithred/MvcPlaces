CREATE TABLE [dbo].[Region] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50)  NOT NULL,
    [CountryId]  INT            NOT NULL,
    [Area]       FLOAT (53)     NULL,
    [ISOCode]    NVARCHAR (10)  NULL,
    [HasFlag]    BIT            DEFAULT ((0)) NOT NULL,
    [Population] INT            NULL,
    [Type]       NVARCHAR (MAX) NULL,
    [ImportId] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Region_To_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([Id])
);

