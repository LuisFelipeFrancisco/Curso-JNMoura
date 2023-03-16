USE Comercio
GO

INSERT INTO [dbo].[Cliente]([Nome],[Sexo],[DtNascimento],[Email])
     VALUES ('Ana Maria Braga de Almeida', 'F', '1976-08-15', 'anamaria@gmail.com')
INSERT INTO [dbo].[Cliente]([Nome],[Sexo],[DtNascimento],[Email])
     VALUES ('Beatriz Souza', 'F', '1966-07-15', 'beatriz@gmail.com')
INSERT INTO [dbo].[Cliente]([Nome],[Sexo],[DtNascimento],[Email])
     VALUES ('Carlos Nascimento', 'M', '1978-09-17', 'carlosnascimento@hotmail.com')
INSERT INTO [dbo].[Cliente]([Nome],[Sexo],[DtNascimento],[Email])
     VALUES ('João Garcia Neto', 'M', '1945-01-23', 'joao.neto@gmail.com')
INSERT INTO [dbo].[Cliente]([Nome],[Sexo],[DtNascimento],[Email])
     VALUES ('Aroldo Rodrigues', 'M', '2000-07-15', 'aroldo.rodrigues@hotmail.com')
INSERT INTO [dbo].[Cliente]([Nome],[Sexo],[DtNascimento],[Email])
     VALUES ('Beatriz Souza Santos', 'F', '1988-10-13', 'beatriz.souza@gmail.com')
INSERT INTO [dbo].[Cliente]([Nome],[Sexo],[DtNascimento],[Email])
     VALUES ('Géssica Andrade Silva', 'F', '1979-07-29', 'gessica.silva@hotmail.com')
GO

SELECT *
  FROM dbo.Cliente
GO



