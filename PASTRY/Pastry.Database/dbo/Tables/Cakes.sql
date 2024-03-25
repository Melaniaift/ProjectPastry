CREATE TABLE [dbo].[Cakes] (
    [Id]      INT             IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (150)  NOT NULL,
    [Price]   DECIMAL (18, 2) NOT NULL,
    [Weight]  INT             NOT NULL,
    [ImageId] INT             NOT NULL,
    CONSTRAINT [PK_Cakes_1] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Cakes]
    ON [dbo].[Cakes]([Name] ASC);

