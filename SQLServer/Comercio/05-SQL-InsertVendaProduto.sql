USE Comercio
GO

INSERT INTO [dbo].[VendaProduto] ([IdVenda],[IdProduto],[Qtde],[Vr])
     VALUES (1,3,1,10.00),(1,4,2,12.48),(1,1,12,1.50)
     -- Foi feita uma venda de 3 produtos, sendo 1 lapiseira, 2 lapiseiras e 12 lápis
     
INSERT INTO [dbo].[VendaProduto] ([IdVenda],[IdProduto],[Qtde],[Vr])
     VALUES (2,3,1,9.00) 
     
INSERT INTO [dbo].[VendaProduto] ([IdVenda],[IdProduto],[Qtde],[Vr])
     VALUES (3,8,1,1.50)

INSERT INTO [dbo].[VendaProduto] ([IdVenda],[IdProduto],[Qtde],[Vr])
     VALUES (4,3,1,9.00), (4,1,1,1.50)

INSERT INTO [dbo].[VendaProduto] ([IdVenda],[IdProduto],[Qtde],[Vr])
     VALUES (5,4,2,12.50), (5,7,2,5)

INSERT INTO [dbo].[VendaProduto] ([IdVenda],[IdProduto],[Qtde],[Vr])
     VALUES (6,5,3,1)

INSERT INTO [dbo].[VendaProduto] ([IdVenda],[IdProduto],[Qtde],[Vr])
     VALUES (7,8,12,1.50)
     
INSERT INTO [dbo].[VendaProduto] ([IdVenda],[IdProduto],[Qtde],[Vr])
     VALUES (8,8,1,2), (8,1,20,2)
     
INSERT INTO [dbo].[VendaProduto] ([IdVenda],[IdProduto],[Qtde],[Vr])
     VALUES (9,1,1,1.50)
     
INSERT INTO [dbo].[VendaProduto] ([IdVenda],[IdProduto],[Qtde],[Vr])
     VALUES (10,2,1,1.75)
          
INSERT INTO [dbo].[VendaProduto] ([IdVenda],[IdProduto],[Qtde],[Vr])
     VALUES (11,8,2,2), (11,6,1,20)
     
INSERT INTO [dbo].[VendaProduto] ([IdVenda],[IdProduto],[Qtde],[Vr])
     VALUES (12,1,2,1.50)
          
GO

SELECT *
  FROM dbo.VendaProduto
GO