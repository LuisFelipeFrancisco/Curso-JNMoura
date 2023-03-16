USE Comercio
GO

INSERT INTO [dbo].[Venda] ([IdCliente],[IdStatus],[Dt])
     VALUES (NULL, 1, GETDATE() - 12) -- GETDATE()
INSERT INTO [dbo].[Venda] ([IdCliente],[IdStatus],[Dt])
     VALUES (1, 2, GETDATE() - 45)
INSERT INTO [dbo].[Venda] ([IdCliente],[IdStatus],[Dt])
     VALUES (2, 2, GETDATE() - 34)
INSERT INTO [dbo].[Venda] ([IdCliente],[IdStatus],[Dt])
     VALUES (3, 2, GETDATE() - 23)
INSERT INTO [dbo].[Venda] ([IdCliente],[IdStatus],[Dt])
     VALUES (4, 2, GETDATE() - 2)
INSERT INTO [dbo].[Venda] ([IdCliente],[IdStatus],[Dt])
     VALUES (5, 2, GETDATE() - 324)
INSERT INTO [dbo].[Venda] ([IdCliente],[IdStatus],[Dt])
     VALUES (6, 1, GETDATE() - 265)
INSERT INTO [dbo].[Venda] ([IdCliente],[IdStatus],[Dt])
     VALUES (6, 1, GETDATE() - 23)
INSERT INTO [dbo].[Venda] ([IdCliente],[IdStatus],[Dt])
     VALUES (6, 2, GETDATE() - 4)
INSERT INTO [dbo].[Venda] ([IdCliente],[IdStatus],[Dt])
     VALUES (5, 1, GETDATE() - 78)
INSERT INTO [dbo].[Venda] ([IdCliente],[IdStatus],[Dt])
     VALUES (NULL, 2, GETDATE() - 48)
INSERT INTO [dbo].[Venda] ([IdCliente],[IdStatus],[Dt])
     VALUES (NULL, 1, GETDATE() - 512)
GO


SELECT *
  FROM DBO.Venda