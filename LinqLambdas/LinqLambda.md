Linq C#

O que é o LINQ?

LINQ é uma abreviação de Language Integrated Query, ou seja, uma consulta integrada à linguagem. O LINQ é um conjunto de recursos da linguagem C# que permite a manipulação de dados de qualquer fonte de dados, como por exemplo, banco de dados, arquivos XML, coleções de objetos, etc.

Um dos principais objetivos do LINQ é permitir que o programador possa escrever consultas de forma padronizada, ou seja, usando a mesma sintaxe para qualquer fonte de dados.


Vantagens do LINQ

- Linguagem familiar, pois usa a mesma sintaxe para qualquer fonte de dados.
- Menos código, pois não é necessário escrever código para conexão com banco de dados, ou para ler arquivos XML, ou para percorrer coleções de objetos.
- Mais legibilidade, pois o código fica mais simples e mais fácil de ser entendido.
- Segurança de tipos, pois o compilador verifica se a consulta está correta em tempo de compilação.

Desvantagens do LINQ

- Performance, pois o LINQ é mais lento que o código tradicional, pois o LINQ precisa fazer a tradução da consulta para a linguagem de consulta da fonte de dados.
- Curva de aprendizado, pois é necessário aprender a sintaxe do LINQ, que é diferente da sintaxe tradicional.
- Algumas queries não podem ser escritas usando LINQ, pois o LINQ não suporta todas as funcionalidades de todas as fontes de dados, como por exemplo no SQL Server, que não é possível escrever uma query que retorne uma tabela temporária.

Lambdas

Surgiu como uma forma de simplificar o código, e tornar o código mais legível.

É uma forma de escrever funções anônimas, ou seja, funções sem nome, que podem ser passadas como parâmetro para outras funções.

Para criar uma função lambda em C#, basta usar o operador => (arrow).

Sintaxe:
(parametros) => expressão
Ex: 
(int x, int y) => x + y;
Na expressão acima, temos uma função lambda que recebe dois parâmetros inteiros e retorna a soma deles.

Aplicando lambda no Linq

IEnumerable<string> resultado1 = from e in fonteDados
                                 where e.Cor == "vermelha"
                                 select e.Nome;

Podemos reescrever essa mesma seleção usando uma lambda expression:

IEnumerable<string> resultado1 = fonteDados.Where(e => e.Cor == "vermelha").Select(e => e.Nome);

Onde:
e => e.Cor == "vermelha" é uma lambda expression que representa uma função que recebe um parâmetro e e retorna um booleano, ou seja, uma função que recebe uma fruta e retorna true se a cor da fruta for vermelha, e false caso contrário.

Em questão de performance, não há diferenças entre elas, mas o uso de lambda expressions é mais comum, pois torna o código mais legível e mais simples de ser escrito.