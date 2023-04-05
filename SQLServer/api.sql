insert into medico (nome, datanascimento, crm) values ('João', '1980-01-01', '123456');
select @@identity; -- Retorna o ultimo identity inserido, na conexão atual
select max (codigo) from medico; -- Retorna o maior codigo da tabela
select top 1 codigo from medico order by id desc; 
-- @@ => Variável de sistema (global)
select convert (int , @@identity); -- Converte o valor para inteiro
-- convert (tipo, valor) => Converte o valor para o tipo informado

-- Não é possivel ligar o identity, precisamos migrar a tabela
-- Para ligar o identity, precisamos criar uma nova tabela
-- e migrar os dados da tabela antiga para a nova
-- e depois apagar a tabela antiga
create table medico2 (
    codigo int identity (1,1) primary key,
    nome varchar (50) not null,
    datanascimento date not null,
    crm varchar (10) not null
);

go
set identity_insert medico2 on;

go
if exists (select * from medico)
    insert into medico2 (codigo, nome, datanascimento, crm)
    select codigo, nome, datanascimento, crm from medico;

go
set identity_insert medico2 off;

go
alter table consulta
    drop constraint fk_consulta_medico;

go
drop table medico;

go
exec sp_rename 'medico2', 'medico';