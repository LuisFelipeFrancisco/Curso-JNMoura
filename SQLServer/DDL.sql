-- Criando um banco de dados SQL Server
CREATE DATABASE consultorio;

-- Criando uma tabela
USE consultorio;

-- Medico => codigo, nome, crm, datanascimento 
--> pk = codigo
--> codigo = identificador unico interno, autoincremento +1
----> int, não pode ser nulo, autoincremento, chave primaria
--> nome = nome do medico
----> varchar(200), não pode ser nulo
--> crm = registro do medico
----> char(9), não pode ser nulo
--> datanascimento = data de nascimento do medico
----> date, pode ser nulo

CREATE TABLE medico (
    codigo INT NOT NULL IDENTITY (1,1), -- INT => inteiro, NOT NULL => não pode ser nulo, IDENTITY => autoincremento, (1,1) => começa em 1 e incrementa de 1 em 1
    nome VARCHAR(200) NOT NULL, -- VARCHAR => string variavel, NOT NULL => não pode ser nulo
    crm CHAR(9) NOT NULL, -- CHAR => string fixa, NOT NULL => não pode ser nulo
    datanascimento DATE, -- DATE => data formato AAAA-MM-DD
    CONSTRAINT pk_medico PRIMARY KEY (codigo) -- CONSTRAINT => restrição, PRIMARY KEY => chave primaria, (codigo) => campo que será a chave primaria
);
