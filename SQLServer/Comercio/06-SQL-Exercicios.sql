----------------------------------------------------------------
------------------- EXERCICIOS DE SQL SERVER -------------------
---------------------------------------------------------------- 

-- SELECIONE TODOS OS DADOS DOS PRODUTOS QUE COMECEM COM AS INICIAIS 'Mo'.
select Id, Descricao, QtdeEstoqueAtual, QtdeEstoqueMinimo, VrUnitario 
from produto 
where descricao like 'Mo%';

-- SELECIONE O NOME DOS CLIENTES CUJO NOME COMECE COM A LETRA 'G'.
select Nome from cliente where nome like 'G%';

-- ACRESCENTE 50 UNIDADES AO ESTOQUE MINIMO DE TODOS OS PRODUTOS.
select QtdeEstoqueMinimo from produto;
-- 32.00 foi para 82.00
-- 60.00 foi para 110.00
-- 40.00 foi para 90.00
-- 23.00 foi para 73.00
-- 232.00 foi para 282.00
-- 5.00 foi para 55.00
-- 3.00 foi para 53.00
-- 43.00 foi para 93.00
update produto set QtdeEstoqueMinimo = QtdeEstoqueMinimo + 50;

-- SELECIONE TODOS OS DADOS DOS CLIENTES DO SEXO FEMININO.
select Id, Nome, Sexo, DtNascimento, Email 
from cliente 
where sexo = 'F';

-- SELECIONE TODOS OS DADOS DOS PRODUTOS QUE ESTEJAM COM O ESTOQUE ATUAL ABAIXO DO ESTOQUE MINIMO.
select Id, Descricao, QtdeEstoqueAtual, QtdeEstoqueMinimo, VrUnitario from produto where QtdeEstoqueAtual < QtdeEstoqueMinimo;

-- SELECIONE O NOME DOS PRODUTOS QUE POSSUEM VRUNITARIO ACIMA DE R$ 10.00 EM ORDEM CRESCENTE DE QTDEESTOQUEATUAL.
select Descricao, QtdeEstoqueAtual, VrUnitario 
from produto 
where VrUnitario > 10 
order by QtdeEstoqueAtual asc;

-- SELECIONE TODOS OS DADOS DOS CLIENTES QUE NASCERAM NO MES DE JULHO.
select Id, Nome, Sexo, DtNascimento, Email 
from cliente 
where datepart(month, DtNascimento) = 7;
select Id, Nome, Sexo, DtNascimento, Email 
from cliente 
where month(DtNascimento) = 7;

-- ACRESCENTE 10% AO VRUNITARIO DE TODOS OS PRODUTOS.
select VrUnitario from produto;
-- 1.50 foi para 1.65
-- 1.75 foi para 1.92
-- 9.00 foi para 9.90
-- 12.50 foi para 13.75
-- 0.70 foi para 0.77
-- 20.00 foi para 22.00
-- 6.00 foi para 6.60
-- 1.50 foi para 1.65
update produto set VrUnitario = VrUnitario * 1.1;

-- SELECIONE O VALOR TOTAL DE PRODUTOS EM ESTOQUE
-- IMP.: VALOR TOTAL EM ESTOQUE = SOMA (QTDEESTOQUEATUAL * VRUNITARIO)
-- PARA CALCULAR A SOMA UTILIZE A FUNÇÃO SUM.
select sum(QtdeEstoqueAtual * VrUnitario) as ValorTotalEstoque 
from produto;

-- SELECIONE TODOS OS DADOS DOS CLIENTES QUE NASCERAM NOS MESES 08,09 E 10.
select Id, Nome, Sexo, DtNascimento, Email 
from cliente 
where datepart(month, DtNascimento) in (8,9,10);

-- SELECIONE O VALOR MÉDIO DOS PRODUTOS EM ESTOQUE
-- IMP.: VALOR MÉDIO DOS PRODUTOS EM ESTOQUE = MÉDIA (QTDEESTOQUEATUAL * VRUNITARIO)
-- PARA CALCULAR A MÉDIA UTILIZE A FUNÇÃO AVG.
select avg(QtdeEstoqueAtual * VrUnitario) as ValorMedioEstoque 
from produto;

-- SELECIONE O ID E NOME DOS CLIENTES CUJO NOME TERMINE COM A LETRA 'A' E NASCERAM NO ANO DE 1979.
select Id, Nome 
from cliente 
where nome like '%a' 
and datepart(year, DtNascimento) = 1979;

-- SELECIONAR TODOS OS DADOS DAS VENDAS (INCLUSIVE SEUS PRODUTOS) REALIZADAS PARA O CLIENTE 'Aroldo Rodrigues'.
select id, idcliente, idstatus, dt 
from venda 
where idcliente = (
    select id 
    from cliente 
    where nome = 'Aroldo Rodrigues');
-- Usando join
select v.id, v.idcliente, v.idstatus, v.dt 
from venda v 
join cliente c on v.idcliente = c.id 
where c.nome = 'Aroldo Rodrigues';

--- Professor:
select v.Id, v.IdCliente, v.IdStatus, v.Dt, vp.Id, vp.IdVenda, vp.IdProduto, vp.Qtde, vp.Vr
from Venda as v
inner join VendaProduto as vp on v.id = vp.IdVenda
inner join Cliente c on c.id = v.IdCliente
where c.Nome = 'Aroldo Rodrigues'
and v.IdStatus = 2;

-- SELECIONE O MENOR VRUNITARIO DO CADASTRO DE PRODUTO.
-- IMP.: UTILIZE A FUNÇÃO MIN.
select min(VrUnitario) as MenorValorUnitario 
from produto;

-- SELECIONE O NOME DOS PRODUTOS QUE TERMINEM COM A LETRA 'a'.
select Descricao 
from produto 
where descricao like '%a';

-- SELECIONAR TODOS OS DADOS DAS VENDAS (SOMENTE VENDAS - NÃO INCLUIR OS PRODUTOS) QUE ESTEJAM COM O STATUS ABERTO E FORAM 
-- REALIZADAS NO ANO DE 2022.
-- IMP.: ALÉM DO ID DO CLIENTE E DO ID DO STATUS DA VENDA, TANTO O NOME QUANTO A DESCRIÇÃO DOS MESMOS DEVEM SER 
--       EXIBIDOS NO SELECT. TOME CUIDADO PARA VENDAS QUE NÃO TENHAM CLIENTE.
select v.id, v.idcliente, v.idstatus, v.dt, cs.Descricao as StatusDescricao, c.Nome as ClienteNome 
from venda v 
left join cliente c on v.idcliente = c.id 
join vendaStatus cs on v.idstatus = cs.Id 
where v.idstatus = 1 
and datepart(year, v.dt) = 2022;

-- SELECIONE O NOME DOS CLIENTES QUE COMPRARAM O PRODUTO APONTADOR.
SELECT c.Nome -- Faz o select do nome do cliente
FROM cliente c -- Tabela cliente
JOIN venda v ON c.id = v.idcliente -- Faz o join da tabela venda com a tabela cliente, ON seria o equivalente ao WHERE
JOIN vendaProduto vp ON v.id = vp.idvenda -- Faz o join da tabela vendaProduto com a tabela venda
JOIN produto p ON vp.idproduto = p.id -- Faz o join da tabela produto com a tabela vendaProduto
WHERE p.descricao = 'Apontador' -- Faz o filtro para trazer somente os clientes que compraram o produto apontador
and v.idstatus = 2 -- Faz o filtro para trazer somente os clientes que compraram o produto apontador e que a venda foi finalizada

-- SELECIONAR O ID, DT DAS VENDAS DOS CLIENTES DO SEXO MASCULINO QUE FORAM REALIZADAS NO ANO DE 2023 
-- ORDENADAS POR DATA DE VENDA (CRESCENTE).
select v.id, v.dt 
from venda v 
join cliente c on v.idcliente = c.id 
where c.sexo = 'M' 
and datepart(year, v.dt) = 2023 
order by v.dt asc;

-- SELECIONE O NOME DOS CLIENTES QUE NÃO COMPRARAM O PRODUTO MOUSE.
select c1.nome -- Faz o select do nome do cliente
from cliente c1 -- Tabela cliente
where not exists ( -- Faz o filtro para trazer somente os clientes que não compraram o produto mouse
    select c.Nome -- Faz o select do nome do cliente
    from Venda as v -- Tabela venda
    inner join VendaProduto as vp on v.id = vp.IdVenda -- Faz o join da tabela vendaProduto com a tabela venda
    inner join Produto as p on p.Id = vp.IdProduto -- Faz o join da tabela produto com a tabela vendaProduto
    inner join Cliente c on c.Id = v.IdCliente -- Faz o join da tabela cliente com a tabela venda
    where p.Descricao = 'Mouse' -- Faz o filtro para trazer somente os clientes que compraram o produto mouse
    and v.IdStatus = 2 -- Faz o filtro para trazer somente os clientes que compraram o produto mouse e que a venda foi finalizada
    and v.IdCliente = c1.Id); -- Faz o filtro para trazer somente os clientes que não compraram o produto mouse

-- SELECIONAR O ID, DT DAS VENDAS DOS CLIENTES DE SEXO FEMININO ORDENADAS POR DATA DE VENDA (DECRESCENTE).
select v.id, v.dt 
from venda v 
join cliente c on v.idcliente = c.id 
where c.sexo = 'F' 
order by v.dt desc;

-- EXIBIR O RELATÓRIO DE VENDAS FINALIZADAS COM OS SEGUINTES CAMPOS:
---- ID VENDA, DESCRICAO DO STATUS DA VENDA, IDCLIENTE E NOME DO CLIENTE
---- IMP.: OS DADOS DO CLIENTE DA VENDA SÓ DEVEM SER EXIBIDOS SE A VENDA POSSUIR CLIENTES
---------- ASSIM, SE A VENDA NÃO POSSUIR CLIENTE, ELA DEVE SER EXIBIDA NO RELATÓRIO COM OS CAMPOS DE CLIENTE COM VALOR NULO.
select v.id, vs.Descricao as StatusDescricao, v.idcliente, c.Nome as ClienteNome 
from venda v 
join vendaStatus vs on v.idstatus = vs.Id 
left join cliente c on v.idcliente = c.id 
where v.idstatus = 2;

-- EXIBIR O NUMERO DE VENDAS QUE ESTÃO FINALIZADAS.
-- IMP.: PROCURAR PELA FUNÇÃO COUNT.
select count(*) as NumeroVendasFinalizadas 
from venda 
where idstatus = 2;

-- EXIBIR O NUMERO DE VENDAS QUE ESTÃO FINALIZADAS E EM ABERTO.
-- IMP.: PROCURAR PELA FUNÇÃO COUNT E GROUP BY.
select count(*) as NumeroDeVendas, vs.Descricao as StatusDescricao 
from venda v 
join vendaStatus vs on v.idstatus = vs.Id 
group by vs.Descricao;

-- SELECIONE O ID, DESCRICAO E VRUNITARIO DOS PRODUTOS QUE FORAM VENDIDOS PARA CLIENTES DO SEXO MASCULINO NO ANO DE 2013,
-- CONSIDERANDO SOMENTE VENDAS FINALIZADAS.
select p.Id, p.Descricao, p.VrUnitario 
from produto p 
join vendaProduto vp on p.id = vp.idproduto 
join venda v on vp.idvenda = v.id 
join cliente c on v.idcliente = c.id 
where c.sexo = 'M' 
and datepart(year, v.dt) = 2013 
and v.idstatus = 2;

-- SELECIONE O ID, DESCRICAO DOS PRODUTOS QUE NAO FORAM INCLUÍDOS EM VENDA ALGUMA.
select p.Id, p.Descricao 
from produto p 
left join vendaProduto vp on p.id = vp.idproduto 
where vp.idproduto is null;

-- SELECIONE O NOME DOS CLIENTES QUE NÃO COMPRARAM NA LOJA.
---- Seria mais "simples" retornar todos os clientes que não tem vendas finalizadas, pois se não tem vendas finalizadas, não comprou na loja.
select c.Nome --- Faz o select do nome do cliente
from cliente c --- Usando a tabela cliente
where not exists ( --- Usando o not exists para retornar os clientes que não tem vendas finalizadas
    select distinct v.idcliente --- Faz o select do id do cliente da tabela venda, usando o distinct para não retornar o mesmo cliente mais de uma vez
    from venda v --- Tabela venda
    where v.idstatus = 2 --- Faz o filtro para trazer somente as vendas finalizadas
    and v.idcliente is not null --- Faz o filtro para trazer somente as vendas finalizadas que tem cliente
    and v.idcliente = c.id); --- Faz o filtro para trazer somente as vendas finalizadas que tem cliente e que o cliente é o mesmo que está na tabela cliente

-- SELECIONE O ID DA VENDA, DESCRICAO, VR UNITARIO, QTDE DO PRODUTO E CALCULE PARA CADA PRODUTO O VALOR TOTAL
-- CONSIDERANDO SOMENTE AS VENDAS FINALIZADAS PARA CLIENTES DO SEXO FEMININO.
select v.id, p.Descricao, p.VrUnitario, vp.Qtde, p.VrUnitario * vp.Qtde as ValorTotal 
from venda v 
join vendaProduto vp on v.id = vp.idvenda 
join produto p on vp.idproduto = p.id 
join cliente c on v.idcliente = c.id 
where c.sexo = 'F' 
and v.idstatus = 2;

-- SELECIONE O ID, DESCRICAO E VRUNITARIO DOS PRODUTOS E O ID DA VENDA DOS PRODUTOS QUE FORAM VENDIDOS 
-- ENTRE OS MESES 10 E 11 DE 2022, CONSIDERANDO SOMENTE VENDAS FINALIZADAS
select p.Id, p.Descricao, p.VrUnitario, v.id 
from produto p 
join vendaProduto vp on p.id = vp.idproduto 
join venda v on vp.idvenda = v.id 
where datepart(month, v.dt) 
between 10 
and 11 
and datepart(year, v.dt) = 2022 
and v.idstatus = 2;

-- ALTERE A DATA DA(S) VENDA(S) DO CLIENTE 'Aroldo Rodrigues' PARA 01/01/2020.
update venda set dt = '2020-01-01' 
where idcliente = (
    select id f
    rom cliente 
    where nome = 'Aroldo Rodrigues');