CREATE TABLE [dbo].[Produtos]
(
	[ProdutoId] INT NOT NULL PRIMARY KEY, 
    [Nome] NVARCHAR(150) NULL, 
    [Descricao] NVARCHAR(250) NULL, 
    [Preco] NUMERIC(10, 2) NULL, 
    [Categoria] NVARCHAR(150) NULL
)
