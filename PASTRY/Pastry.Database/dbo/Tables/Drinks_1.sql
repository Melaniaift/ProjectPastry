CREATE TABLE [dbo].[Drinks] (
    [Id]      INT                 IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (150)      NOT NULL,
    [Price]   DECIMAL (18, 2)     NOT NULL,
    [ImageId] [sys].[hierarchyid] NOT NULL,
    CONSTRAINT [PK_PastryDrinks] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Drinks_Images] FOREIGN KEY ([ImageId]) REFERENCES [dbo].[Images] ([path_locator])
);


GO
CREATE NONCLUSTERED INDEX [IX_PastryDrinks]
    ON [dbo].[Drinks]([Name] ASC);

