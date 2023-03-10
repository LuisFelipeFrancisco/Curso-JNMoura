create database empresa;

use empresa;

create table departamento(
    codigo int not null,
    nome varchar(50) not null,
    constraint pk_departamento primary key(codigo)
);

create table funcionario(
    codigo int not null,
    codigo_departamento int not null,
    primeiro_nome varchar(50) not null,
    segundo_nome varchar(50) null, -- Nem todos funcionarios tem nome composto
    ultimo_nome varchar(50) not null,
    data_nascimento date not null,
    cpf char(11) not null,
    rg varchar(20) not null, -- RG pode ter letras
    endereco varchar(100) not null,
    cep varchar(8) not null,
    cidade varchar(50) not null,
    fone varchar(15) not null,
    funcao varchar(50) not null,
    salario numeric(10,2) not null, -- (Precisão, Escala) 10 digitos, 2 casas decimais (9999999999.99)
    constraint pk_funcionario primary key(codigo),
    constraint fk_funcionario_departamento foreign key(codigo_departamento) references departamento(codigo)
);

--1) Descreva o comando para listar todos os dados de funcionários ordenados por cidade.
select * from funcionario order by cidade; -- Não usar o * em produção
--2) Descreva o comando para listar todos os dados dos funcionários que têm salário superior a R$ 1.000,00.
select * from funcionario where salario > 1000;
--3) Descreva o comando para listar o nome dos funcionários que nasceram no mês de agosto.
select primeiro_nome, segundo_nome, ultimo_nome from funcionario where month(data_nascimento) = 8;
--4) Descreva o comando para listar os nomes, endereços e fones dos funcionários que moram em Recife e que exerçam a função de Telefonista.
select primeiro_nome, segundo_nome, ultimo_nome, endereco, fone from funcionario where cidade = 'Recife' and funcao = 'Telefonista';
--5) Descreva o comando para listar os nomes dos funcionários que trabalham no departamento Pessoal (codigo ??).
select primeiro_nome, segundo_nome, ultimo_nome from funcionario where codigo_departamento = 1;
----ou selecionando pelo nome do departamento
select primeiro_nome, segundo_nome, ultimo_nome from funcionario where codigo_departamento = (select codigo from departamento where nome = 'Pessoal');
--6) Descreva o comando para listar o nome, o nome do departamento e a função de todos os funcionários.
--???
--7) Descreva o comando para listar os departamentos dos funcionários que têm a função de Supervisor.
select nome from departamento where codigo = (select codigo_departamento from funcionario where funcao = 'Supervisor');
--8) Descreva o comando para listar a quantidade de funcionários desta empresa.
select count(*) from funcionario;
--9) Descreva o comando para listar o nome de todos os funcionários que não tenham segundo nome.
select primeiro_nome, ultimo_nome from funcionario where segundo_nome is null;
--10) Descreva o comando para listar os departamentos que não possuem funcionários.
select nome from departamento where codigo not in (select codigo_departamento from funcionario);
--11) Descreva o comando para excluir o departamento 8.
----Deletar os registros da tabela funcionario que possuem o codigo do departamento 8
delete from funcionario where codigo_departamento = 8;
----ou mudar os funcionarios de departamento
update funcionario set codigo_departamento = 1 where codigo_departamento = 8;
----Deletar o departamento 8
delete from departamento where codigo = 8;
--12) Descreva o comando para alterar o salário do funcionário 10 para R$ 2500,00.
update funcionario set salario = 2500 where codigo = 10;
--13) Descreva o comando para inserir o funcionário com os seguintes dados:
--Codigo: 100 -- codigo não deveria ser auto incremento 
--CodigoDeparamento: 3
--Primeiro_Nome: Joaquim
--Segundo_Nome: Barbosa
--Ultimo_Nome: Silva
--Data_Nascimento: 23/04/1978
--CPF: 287.989.098-77 -- 11 digitos sem pontos e traço
--RG: 13.908.345-X -- 9 digitos sem pontos e traço
--Enderco: Av. das nações 1234
--CEP: 14356234
--Cidade: Campinas
--Fone: 998987899
--Funcao: Gerente
--Salario: R$ 12000,00
insert into departamento values(3, 'Departamento 3');

insert into funcionario values(
    100, 
    3, 
    'Joaquim', 
    'Barbosa', 
    'Silva', 
    '1978-04-23', 
    '28798909877',
    '13908345X', 
    'Av. das nações 1234', 
    '14356234', 
    'Campinas', 
    '998987899', 
    'Gerente', 
    12000
);