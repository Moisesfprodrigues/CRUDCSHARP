# 🎓 CRUD de Alunos em C# com Microsoft Access

## 📖 Descrição

Este projeto consiste numa aplicação **Windows Forms desenvolvida em C#** que implementa as operações básicas de **CRUD (Create, Read, Update e Delete)** utilizando uma base de dados **Microsoft Access (.accdb)**.

A aplicação permite gerir registos de alunos através de uma interface gráfica simples e intuitiva, sendo ideal para fins educativos e para aprendizagem de acesso a bases de dados com **ADO.NET**.

---

## ✨ Funcionalidades

✅ Inserir novos alunos

✅ Consultar todos os alunos

✅ Atualizar dados de alunos existentes

✅ Apagar alunos

✅ Visualizar registos numa **DataGridView**

✅ Selecionar registos diretamente da tabela para edição

---

## 🛠 Tecnologias Utilizadas

* **C#**
* **Windows Forms**
* **Microsoft Access (.accdb)**
* **ADO.NET**
* **OleDbConnection**
* **OleDbCommand**
* **OleDbDataAdapter**
* **DataGridView**

---

## 🗄 Estrutura da Base de Dados

Tabela: **alunos**

| Campo  | Tipo                           |
| ------ | ------------------------------ |
| ID     | AutoNumeração (Chave Primária) |
| nome   | Texto Curto                    |
| numero | Número                         |
| nota   | Número                         |

---

## 📋 Operações Disponíveis

### ➕ Inserir Aluno

Adiciona um novo registo à base de dados.

```sql
INSERT INTO alunos (nome, numero, nota)
VALUES (@nome, @num, @nota)
```

### 🔍 Consultar Alunos

Lista todos os alunos existentes.

```sql
SELECT * FROM alunos
```

### ✏️ Atualizar Aluno

Atualiza os dados do aluno selecionado.

```sql
UPDATE alunos
SET nome=@nome,
    numero=@num,
    nota=@nota
WHERE ID=@id
```

### 🗑 Apagar Aluno

Remove um aluno da base de dados.

```sql
DELETE FROM alunos
WHERE ID=@id
```

---

## 🔗 Ligação à Base de Dados

A aplicação utiliza uma ligação **OLEDB** para comunicar com o Microsoft Access.

```csharp
con = new OleDbConnection(
@"Provider=Microsoft.ACE.OLEDB.12.0;
Data Source=D:\crud_exemplo\db.accdb;");
```

> ⚠️ **Importante:** Antes de executar o projeto deverá alterar o caminho da base de dados para a localização correta do ficheiro `db.accdb`.

---

## 🚀 Como Executar

### 1. Clonar o Repositório

```bash
git clone https://github.com/SEU_UTILIZADOR/SEU_REPOSITORIO.git
```

### 2. Abrir o Projeto

Abrir a solução no **Visual Studio**.

### 3. Configurar a Base de Dados

Editar a string de ligação para apontar para o ficheiro `db.accdb`.

### 4. Compilar

```text
Build → Build Solution
```

### 5. Executar

```text
Debug → Start Debugging
```

ou pressionar:

```text
F5
```

---

## 📸 Capturas de Ecrã

Adicione aqui imagens da aplicação.

### Interface Principal

```text
/screenshots/interface-principal.png
```

### Inserção de Dados

```text
/screenshots/inserir-aluno.png
```

### Consulta de Dados

```text
/screenshots/consulta-alunos.png
```

---

## 🎯 Objetivos Pedagógicos

Este projeto foi desenvolvido para demonstrar:

* Ligação a bases de dados Microsoft Access
* Utilização de ADO.NET
* Operações CRUD
* Queries parametrizadas
* Utilização de DataGridView
* Desenvolvimento de aplicações Windows Forms

---

## 📂 Estrutura do Projeto

```text
app_crud_db/
│
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
├── db.accdb
├── README.md
│
└── screenshots/
    ├── interface-principal.png
    ├── inserir-aluno.png
    └── consulta-alunos.png
```

---

## 👨‍🏫 Destinatários

Este projeto é indicado para:

* Alunos de Programação
* Cursos Profissionais de Informática
* Introdução a Bases de Dados
* Aprendizagem de C# Windows Forms
* Formação em ADO.NET

---

## 👤 Autor

**Moisés Rodrigues**

Professor de Informática, Programação, Redes e Automação.

---

## 📜 Licença

Este projeto é disponibilizado para fins **educativos e de aprendizagem**.
