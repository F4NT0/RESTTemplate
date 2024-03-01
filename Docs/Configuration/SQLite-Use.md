[Home](README.md)

## Exemplos de uso do SQLite
---
### Acessando o SQLite pelo PowerShell
Acessar pelo prompt de comando somente acessamos a rota `C://sqlite` e rodamos o comando __sqlite3__ diretamente:
![[SQLiteConsolePrompt.png]]
Para acessar pelo Powershell é um pouco diferente, temos que colocar `.\` antes do comando:
![[SQLitePowershell.png]]
### Comandos mais usados
Quando colocamos o comando **.help** no console conectados ao SQLite ele nos mostra os tipos de comandos que podemos usar:

| Comando | Descrição |
| ---- | ---- |
| `.databases` | Lista todos os bancos de dados. |
| `.tables` | Lista todas as tabelas no banco de dados atual. |
| `.schema` | Mostra o esquema de criação de todas as tabelas. |
| `.header on` | Ativa a exibição de nomes de colunas no resultado da consulta. |
| `.mode column` | Configura o formato de saída para o modo coluna. |
| `.exit` | Sai do SQLite. |
| `SELECT * FROM nome_tabela;` | Seleciona todos os dados de uma tabela. |
| `INSERT INTO nome_tabela (coluna1, coluna2) VALUES (valor1, valor2);` | Insere dados em uma tabela. |
| `UPDATE nome_tabela SET coluna1 = valor1 WHERE condição;` | Atualiza dados em uma tabela. |
| `DELETE FROM nome_tabela WHERE condição;` | Deleta dados de uma tabela. |
### Criação de um database
Para isso devemos criar uma pasta em nosso diretório **C:/sqlite** chamado **db** onde iremos colocar nossos databases. Esse é o caminho onde colocaremos e interagiremos com nosso banco de dados SQLite:

```
C://sqlite/db
```

Acessamos o diretório **C:/sqlite** por um console e rodamos o seguinte comando:

```
sqlite3 db/nomedatabase.db
```

Esse comando vai criar um banco de dados chamado `nomedatabase` dentro do diretório **db** totalmente vazio.
### Verificando qual database está conectado
---
Quando rodamos o comando __.database__ conectado ao `sqlite3` podemos ver a rota para o banco de dados conectado atualmente, já que ele não mostra o nome do database sempre que você se conecta nele.
```sql
sqlite> .database
sqlite> C:/sqlite/db/restemplate.db
```

### Desconectando de um database
---
Podemos nos desconectar de um database utilizando três comandos: __.exit__ ou __.quit__ ou __.q__ 
Esses comando farão o `sqlite3` finalizar e voltar ao console normal.

### Acessando no SQLite Studio
---
Com o nosso banco de dados criado, podemos acessar ele pelo GUI do SQLite Studio da seguinte forma:
1. Abra o SQLiteStudio e clique na opção **Database** no canto superior esquerdo e depois em **Add a database**
### Criação de uma tabela
### Exportação de Backup
### Inserção de dados pelo SQLite Studio

