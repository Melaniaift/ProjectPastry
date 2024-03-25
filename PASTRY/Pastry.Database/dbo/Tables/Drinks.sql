CREATE TABLE [dbo].[Drinks] (
    [Id]      INT             IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (150)  NOT NULL,
    [Price]   DECIMAL (18, 2) NOT NULL,
    [ImageId] INT             NOT NULL,
    CONSTRAINT [PK_Drinks] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Drinks]
    ON [dbo].[Drinks]([Name] ASC);

