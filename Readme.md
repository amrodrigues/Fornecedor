# Fornecedor API

Este � um projeto ASP.NET Core Web API para gerenciar fornecedores. Ele utiliza o Entity Framework Core para acesso ao banco de dados e segue uma arquitetura simples com inje��o de depend�ncia.

## Tecnologias Utilizadas

- **ASP.NET Core 6.0**
- **Entity Framework Core**
- **SQL Server**
- **Swagger/OpenAPI** para documenta��o da API

## Configura��o do Projeto

### Pr�-requisitos

- **.NET 6 SDK** instalado
- **SQL Server** configurado e em execu��o
- Ferramenta `dotnet-ef` instalada globalmente:

### Configura��o da String de Conex�o

No arquivo `appsettings.json`, configure a string de conex�o para o banco de dados:

```json { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Database=FornecedorDb;Trusted_Connection=True;" } }

### Restaurar Depend�ncias

Execute o comando abaixo para restaurar os pacotes necess�rios:

```bash dotnet tool install --global dotnet-ef ```bash 

### Criar o Banco de Dados

1. Crie as migra��es:
```bash dotnet ef migrations add InitialCreate ```bash 

2. Aplique as migra��es para criar o banco de dados:
```bash  dotnet ef database update ```bash 

### Executar a Aplica��o

Execute o comando abaixo para iniciar a aplica��o:
```bash dotnet run	```bash 

A aplica��o estar� dispon�vel em `https://localhost:5001/api/fornecedores` ou `http://localhost:5000/api/fornecedores`.


## Endpoints Dispon�veis

Os endpoints da API foram gerados automaticamente utilizando o **Scaffolding** do Entity Framework Core. 



- **GET** `/api/fornecedores` - Retorna todos os fornecedores.
- **POST** `/api/fornecedores` - Adiciona um novo fornecedor.
- **PUT** `/api/fornecedores/{id}` - Atualiza um fornecedor existente.
- **DELETE** `/api/fornecedores/{id}` - Remove um fornecedor.

## Estrutura do Projeto

- **Model**: Cont�m as classes de modelo (ex.: `Fornecedor`).
- **Data**: Cont�m o contexto do banco de dados (`ApiContext`).
- **Controllers**: Cont�m os controladores da API.

 
   
