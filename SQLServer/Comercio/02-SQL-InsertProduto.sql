USE Comercio
GO

INSERT INTO [dbo].[Produto]([Descricao],[QtdeEstoqueAtual],[QtdeEstoqueMinimo],[VrUnitario])
     VALUES ('Lápis', 100, 32, 1.50)
INSERT INTO [dbo].[Produto]([Descricao],[QtdeEstoqueAtual],[QtdeEstoqueMinimo],[VrUnitario])
     VALUES ('Caneta', 148, 60, 1.75)
INSERT INTO [dbo].[Produto]([Descricao],[QtdeEstoqueAtual],[QtdeEstoqueMinimo],[VrUnitario])
     VALUES ('Lapiseira 0.5', 32, 40, 9.00)
INSERT INTO [dbo].[Produto]([Descricao],[QtdeEstoqueAtual],[QtdeEstoqueMinimo],[VrUnitario])
     VALUES ('Lapiseira 0.9', 12, 23, 12.50)
INSERT INTO [dbo].[Produto]([Descricao],[QtdeEstoqueAtual],[QtdeEstoqueMinimo],[VrUnitario])
     VALUES ('Borracha', 300, 232, 0.70)
INSERT INTO [dbo].[Produto]([Descricao],[QtdeEstoqueAtual],[QtdeEstoqueMinimo],[VrUnitario])
     VALUES ('Mouse', 23, 5, 20.00)
INSERT INTO [dbo].[Produto]([Descricao],[QtdeEstoqueAtual],[QtdeEstoqueMinimo],[VrUnitario])
     VALUES ('Mouse Pad', 12, 3, 6.00)
INSERT INTO [dbo].[Produto]([Descricao],[QtdeEstoqueAtual],[QtdeEstoqueMinimo],[VrUnitario])
     VALUES ('Apontador', 78, 43, 1.50)
GO

SELECT *
  FROM DBO.PRODUTO