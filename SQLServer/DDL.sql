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

TRUNCATE TABLE medico; -- Deleta todos os registros da tabela medico, resetando os autoincrementos

-- Paciente => codigo, nome, email
--> pk = codigo
--> codigo = identificador unico interno, autoincremento +1
----> int, não pode ser nulo, autoincremento, chave primaria
--> nome = nome do paciente
----> varchar(200), não pode ser nulo
--> email = email do paciente
----> varchar(100), pode ser nulo

CREATE TABLE paciente (
    codigo INT NOT NULL IDENTITY (1,1),
    nome VARCHAR(200) NOT NULL,
    email VARCHAR(100),
    CONSTRAINT pk_paciente PRIMARY KEY (codigo)
);

DROP TABLE paciente; -- Deleta a tabela paciente

-- Consulta => codigo medico, codigo paciente, data
--> fk = codigo medico, codigo paciente
--> codigo medico = codigo do medico
----> int, não pode ser nulo, chave estrangeira
--> codigo paciente = codigo do paciente
----> int, não pode ser nulo, chave estrangeira
--> data = data da consulta
----> date, não pode ser nulo
--> pk composta = codigo medico, codigo paciente, data

CREATE TABLE consulta (
    codigo_medicos INT NOT NULL,
    codigo_pacientes INT NOT NULL,
    [data] DATE NOT NULL,
    CONSTRAINT fk_consulta_medico FOREIGN KEY (codigo_medicos) REFERENCES medico (codigo), 
    -- CONSTRAINT => restrição, 
    -- FOREIGN KEY => chave estrangeira, 
    -- (codigo_medicos) => campo que será a chave estrangeira, 
    -- REFERENCES => referencia a tabela, 
    -- (medico) => tabela que será referenciada, 
    -- (codigo) => campo que será referenciado
    CONSTRAINT fk_consulta_paciente FOREIGN KEY (codigo_pacientes) REFERENCES paciente (codigo),
    CONSTRAINT pk_consulta PRIMARY KEY (codigo_medicos, codigo_pacientes, [data])
);