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

SELECT nome, crm, datanascimento 
  FROM medico 
 WHERE codigo = 2; 
-- Seleciona todos os registros da tabela medico que tenham o código 1

DELETE FROM medico WHERE codigo = 4 OR codigo = 5 OR codigo = 6; 
-- Deleta os registros com código 4, 5 e 6