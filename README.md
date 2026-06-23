CRUD de Alunos em C# com Microsoft Access
Descrição

Este projeto é uma aplicação Windows Forms desenvolvida em C# que implementa as operações básicas de CRUD (Create, Read, Update e Delete) utilizando uma base de dados Microsoft Access (.accdb).

A aplicação permite gerir registos de alunos através de uma interface gráfica simples, sendo adequada para fins educativos e para introdução ao acesso a bases de dados com ADO.NET.

Funcionalidades
Inserir novos alunos
Listar alunos existentes
Atualizar dados de um aluno
Apagar alunos
Visualizar os registos numa DataGridView
Selecionar um registo para edição através da grelha
Estrutura da Base de Dados

Tabela: alunos

Campo	Tipo
ID	AutoNumeração (Chave Primária)
nome	Texto Curto
numero	Número
nota	Número
Exemplo de Registos
ID	Nome	Número	Nota
1	João Silva	1001	18
2	Maria Costa	1002	16
3	Pedro Sousa	1003	14
Ligação à Base de Dados

A aplicação utiliza a seguinte string de ligação:

Provider=Microsoft.ACE.OLEDB.12.0;
Data Source=D:\crud_exemplo\db.accdb;

Importante: Antes de executar o projeto deverá alterar o caminho da base de dados para o local onde se encontra o ficheiro db.accdb.

Exemplo:

con = new OleDbConnection(
@"Provider=Microsoft.ACE.OLEDB.12.0;
Data Source=C:\Projetos\CRUD\db.accdb;");
Operações Disponíveis
Inserir

Adiciona um novo aluno à base de dados.

INSERT INTO alunos (nome, numero, nota)
VALUES (@nome, @num, @nota)
Consultar

Carrega todos os registos existentes.

SELECT * FROM alunos
Atualizar

Atualiza os dados de um aluno selecionado.

UPDATE alunos
SET nome=@nome,
    numero=@num,
    nota=@nota
WHERE ID=@id
Apagar

Remove um aluno da base de dados.

DELETE FROM alunos
WHERE ID=@id
Como Executar
Clonar ou descarregar este repositório.
Abrir a solução no Visual Studio.
Instalar o Microsoft Access Database Engine caso necessário.
Ajustar o caminho do ficheiro db.accdb.
Compilar e executar o projeto.
Objetivos Pedagógicos

Este projeto foi desenvolvido para demonstrar:

Ligação a bases de dados Access
Utilização de ADO.NET
Operações CRUD
Utilização de parâmetros SQL
Manipulação de DataGridView
Desenvolvimento de aplicações Windows Forms
Autor

Moisés Rodrigues

Projeto desenvolvido para fins educativos e de aprendizagem de programação em C# com acesso a bases de dados.
