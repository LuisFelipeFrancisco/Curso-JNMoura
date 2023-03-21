-- 1. Escreva a instrução para criar a base de dados “esporte”.
CREATE DATABASE esporte;
-- 2. Escreva a instrução para criar a tabela “campeonato”.
USE esporte;
CREATE TABLE campeonato (
    id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    nome varchar(50) NOT NULL,
    ativo bit NOT NULL
);
-- 3. Escreva a instrução para criar a tabela “equipe”.
USE esporte;
CREATE TABLE equipe (
    id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    nome varchar(50) NOT NULL
);
-- 4. Escreva a instrução para criar a tabela “partida”. Não se esqueça das chaves estrangeiras.
USE esporte;
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
-- 5. Escreva a instrução para inserir a partida 25 no banco de dados.
-- id partida: 25
-- id campeonato: 2
-- camp: Libertadores 
-- data: 15/05/2022
-- hora: 11:00
-- id equipe casa: 7
-- equipe casa: Emelec
-- id equipe visitante: 9
-- equipe visitante: Internacional
-- gols equipe casa: 4
-- gols equipe visitante: 1
USE esporte;
INSERT INTO partida (idcampeonato, idequipecasa, idequipevisitante, golsequipecasa, golsequipevisitante, data, hora)
VALUES (2, 7, 9, 4, 1, '2022-05-15', '11:00');
-- 6. Escreva a instrução para alterar o placar da partida 6 para oito gols do time da casa e dois gols do time visitante.
USE esporte;
UPDATE partida
SET golsequipecasa = 8, golsequipevisitante = 2
WHERE id = 6;
-- 7. Escreva a instrução para excluir os campeonatos inativos. (id é chave estrangeira)
-- Primeiro, desative os campeonatos inativos removendo a chave estrangeira.
USE esporte;
ALTER TABLE partida
DROP CONSTRAINT FK__partida__idcampe__49C3F6B7; -- nome gerado pelo SGDB, poderia ter criado meu proprio nome na criação da FK
-- Depois, remova os campeonatos inativos.
USE esporte;
DELETE FROM campeonato
WHERE ativo = 0;
-- 8. A instrução da questão 7 causará algum erro? Explique sua reposta.
-- Caso não seja removida a referencia da chave estrangeira antes sim, pois a FK não pode ser removida enquanto houver registros que a referenciam, então primeiro é necessário remover os registros que a referenciam.
-- 9. Sugira uma nova chave primária para a tabela Partida e explique o motivo da sua sugestão. Não precisa aplicá-la no banco de dados, somente sugerir e explicar.
-- Poderiamos usar uma chave composta com os campos idequipecasa, idequipevisitante, data e hora, pois a combinação destes campos é única.
-- 10. Escreva a instrução para selecionar todos os dados dos campeonatos ativos.
USE esporte;
SELECT id, nome, ativo
FROM campeonato
WHERE ativo = 1;
-- 11. Escreva a instrução para selecionar todos os dados das equipes que tenham a letra 'P' no nome.
USE esporte;
SELECT id, nome
FROM equipe
WHERE nome LIKE '%P%';
-- 12. Escreva a instrução para selecionar os nomes das equipes que possuem Id entre 3 e 6.
SELECT nome
FROM equipe
WHERE id BETWEEN 3 AND 6;
-- 13. Escreva a instrução para selecionar as datas e horas das partidas e os nomes das equipes que jogaram em casa no mês de abril de 2022.
SELECT p.data, p.hora, e.nome
FROM partida p
INNER JOIN equipe e ON p.idequipecasa = e.id
WHERE datepart(mm, p.data) = 4 AND datepart(yyyy, p.data) = 2022;
-- 14. Escreva a instrução para selecionar os nomes das equipes visitantes que jogaram em 15/05/2022.
SELECT e.nome
FROM partida p
INNER JOIN equipe e ON p.idequipevisitante = e.id
WHERE p.data = '2022-05-15';
-- 15. Escreva a instrução para selecionar as datas das partidas, os números de gols feitos em casa e os nomes das equipes que jogaram em casa e marcaram mais de três gols na data de 24/04/2022
SELECT p.data, p.golsequipecasa, e.nome
FROM partida p
INNER JOIN equipe e ON p.idequipecasa = e.id
WHERE p.data = '2022-04-24' AND p.golsequipecasa > 3;
-- 16. Escreva a instrução para selecionar os nomes das equipes que perderam partidas em casa. Devemos utilizar o “Distinct” neste comando? Por quê?
SELECT DISTINCT e.nome -- Não é necessário, mas é bom para evitar repetições
FROM partida p
INNER JOIN equipe e ON p.idequipecasa = e.id
WHERE p.golsequipecasa < p.golsequipevisitante; -- Empate não é derrota
-- Depende do que se deseja mostrar. Caso não queira mostrar o nome de uma equipe mais de uma vez, então sim, é necessário utilizar o DISTINCT.
-- Nesse caso sem o DISTINCT iria ver que certas equipes perderam mais de uma partida em casa; caso a analise ultilize essa informação, então não é necessário o DISTINCT.
-- 17. Escreva a instrução para selecionar os nomes das equipes que ganharam partidas fora de casa com placar acima de dois gols.
SELECT DISTINCT e.nome -- Não é necessário, mas é bom para evitar repetições
FROM partida p
INNER JOIN equipe e ON p.idequipevisitante = e.id
WHERE p.golsequipecasa < p.golsequipevisitante AND p.golsequipevisitante - p.golsequipecasa > 2; -- Empate não é vitoria e placar acima de 2 gols
-- 18. Escreva a instrução para contar o número de jogos realizados pela “Ferroviária” como visitante.
SELECT COUNT(*) as JogosRealizados
FROM partida p
INNER JOIN equipe e ON p.idequipevisitante = e.id
WHERE e.nome = 'Ferroviária';
-- 19. Escreva a instrução para selecionar o nome das equipes que não jogaram partidas de futebol.
-- adicionando um time para teste
INSERT INTO equipe (nome)
VALUES ('Teste');
SELECT e.nome
FROM equipe e
LEFT JOIN partida p ON p.idequipecasa = e.id OR p.idequipevisitante = e.id
WHERE p.id IS NULL;
-- removendo o time de teste
DELETE FROM equipe
WHERE nome = 'Teste';
-- 20. Qual a importância de visualizar o plano de execução das instruções.
-- O plano de execução mostra como o banco de dados irá executar a instrução, mostrando o caminho que será percorrido para executar a instrução.
-- Nos mostrando informações preciosas, como consumo de memória, tempo de execução, etc; Aonde podemos estar otimizando as instruções para melhorar o desempenho do banco de dados.