USE consultorio; -- Confirma o uso do banco de dados consultorio

INSERT INTO medico (nome, crm, datanascimento) -- Insere um novo registro na tabela medico
    VALUES ('João da Silva', '123456/SP', '1980-01-01'); 
    -- Valores dos campos nome, crm e datanascimento do registro

SELECT nome, crm, datanascimento FROM medico; -- Seleciona todos os registros da tabela medico

INSERT INTO medico (nome, crm, datanascimento)
    VALUES ('Maria da Silva', '123457/SP', '1999-12-31'); 

INSERT INTO medico (nome, crm, datanascimento)
    VALUES ('José da Silva', '654321/RJ', null); 
    -- Valores dos campos nome, crm e datanascimento do registro (datanascimento é nulo)

SELECT nome, crm, datanascimento 
  FROM medico 
 WHERE nome LIKE 'João%'; 
-- Seleciona todos os registros da tabela medico que tenham João no início do nome

SELECT codigo, nome, crm, datanascimento 
  FROM medico 
 WHERE codigo = 2; 
-- Seleciona todos os registros da tabela medico que tenham o código 1

DELETE FROM medico WHERE codigo = 4 OR codigo = 5 OR codigo = 6; 
-- Deleta os registros com código 4, 5 e 6

INSERT INTO medico -- Insere vários registros na tabela medico, sem especificar os campos
    VALUES ('Marcelo', '123456/RJ', '1996-05-08'), 
           ('Felipe', '114422/AM', '1994-01-31'), 
           ('João', '123456/SP', '1980-01-01'), 
           ('Maria', '123457/SP', '1999-12-31'), 
           ('José', '654321/RJ', null);

UPDATE medico SET nome = 'João' WHERE nome = 'Joao'; -- Altera o nome de Joao para João

INSERT INTO paciente (codigo, nome, email) 
    VALUES (100, 'João da Silva', 'joao@email.com'), 
           (50, 'Maria da Silva', 'maria@gmail.com'), 
           (1050, 'José da Silva', 'jose@email.com'), 
           (400, 'Felipe', 'felipe@hotmail.com');
