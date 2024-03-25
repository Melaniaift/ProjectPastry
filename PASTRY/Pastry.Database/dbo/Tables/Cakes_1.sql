CREATE TABLE [dbo].[Cakes] (
    [Id]      INT                 IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (150)      NOT NULL,
    [Price]   DECIMAL (18, 2)     NOT NULL,
    [Weight]  INT                 NOT NULL,
    [ImageId] [sys].[hierarchyid] NOT NULL,
    CONSTRAINT [PK_PastryCakes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Cakes_Images] FOREIGN KEY ([ImageId]) REFERENCES [dbo].[Images] ([path_locator])
);


GO
CREATE NONCLUSTERED INDEX [IX_PastryCakes]
    ON [dbo].[Cakes]([Name] ASC);

