CREATE TABLE [dbo].[CakeIngredients] (
    [CakeId]       INT NOT NULL,
    [IngredientId] INT NOT NULL,
    CONSTRAINT [PK_CakeIngredients] PRIMARY KEY CLUSTERED ([CakeId] ASC, [IngredientId] ASC),
    CONSTRAINT [FK_CakeIngredients_Cakes] FOREIGN KEY ([CakeId]) REFERENCES [dbo].[Cakes] ([Id]),
    CONSTRAINT [FK_CakeIngredients_Ingredients] FOREIGN KEY ([IngredientId]) REFERENCES [dbo].[Ingredients] ([Id])
);

