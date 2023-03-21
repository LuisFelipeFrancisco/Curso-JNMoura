-- Database esporte
-- Table campeonato
--- Campos: id, nome, ativo
---- id: chave primaria, auto incremento (1,1), não nulo
---- nome: varchar(50), não nulo
---- ativo: bit, não nulo
-- Tabela equipe
--- Campos: id, nome
---- id: chave primaria, auto incremento (1,1), não nulo
---- nome: varchar(50), não nulo
-- Tabela partida
---- Campos: id, id campeonato, idequeipecasa, idequipevisitante, golsequipecasa, golsequipevisitante, data, hora
----- id: chave primaria, auto incremento (1,1), não nulo
----- id campeonato: chave estrangeira, não nulo (campeonato.id)
----- idequeipecasa: chave estrangeira, não nulo (equipe.id)
----- idequipevisitante: chave estrangeira, não nulo (equipe.id)
----- golsequipecasa: int, não nulo
----- golsequipevisitante: int, não nulo
----- data: date, não nulo
----- hora: time, não nulo

CREATE DATABASE esporte;
USE esporte;

CREATE TABLE campeonato (
    id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    nome varchar(50) NOT NULL,
    ativo bit NOT NULL
);

CREATE TABLE equipe (
    id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    nome varchar(50) NOT NULL
);

CREATE TABLE partida (
    id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    idcampeonato int NOT NULL,
    idequipecasa int NOT NULL,
    idequipevisitante int NOT NULL,
    golsequipecasa int NOT NULL,
    golsequipevisitante int NOT NULL,
    data date NOT NULL,
    hora time NOT NULL,
    FOREIGN KEY (idcampeonato) REFERENCES campeonato(id),
    FOREIGN KEY (idequipecasa) REFERENCES equipe(id),
    FOREIGN KEY (idequipevisitante) REFERENCES equipe(id)
);
