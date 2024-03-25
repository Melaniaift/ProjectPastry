CREATE TABLE [dbo].[Ingredients] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_IngredientsP] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_Ingredients]
    ON [dbo].[Ingredients]([Name] ASC);

