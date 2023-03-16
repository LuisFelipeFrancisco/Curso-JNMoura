USE Comercio
GO

INSERT INTO [dbo].[VendaStatus] ([Id],[Descricao])
     VALUES (1, 'Em Aberto')
INSERT INTO [dbo].[VendaStatus] ([Id],[Descricao])
     VALUES (2, 'Finalizada')
GO

SELECT *
  FROM dbo.VendaStatus
GO


