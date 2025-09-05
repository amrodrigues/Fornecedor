# Fornecedor API

Este é um projeto ASP.NET Core Web API para gerenciar fornecedores. Ele utiliza o Entity Framework Core para acesso ao banco de dados e segue uma arquitetura simples com injeção de dependência.

## Tecnologias Utilizadas

- **ASP.NET Core 6.0**
- **Entity Framework Core**
- **SQL Server**
- **Swagger/OpenAPI** para documentação da API

## Configuração do Projeto

### Pré-requisitos

- **.NET 6 SDK** instalado
- **SQL Server** configurado e em execução
- Ferramenta `dotnet-ef` instalada globalmente:

### Configuração da String de Conexão

No arquivo `appsettings.json`, configure a string de conexão para o banco de dados:

```json { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Database=FornecedorDb;Trusted_Connection=True;" } }

### Restaurar Dependências

Execute o comando abaixo para restaurar os pacotes necessários:

```bash dotnet tool install --global dotnet-ef ```bash 

### Criar o Banco de Dados

1. Crie as migrações:
```bash dotnet ef migrations add InitialCreate ```bash 

2. Aplique as migrações para criar o banco de dados:
```bash  dotnet ef database update ```bash 

### Executar a Aplicação

Execute o comando abaixo para iniciar a aplicação:
```bash dotnet run	```bash 

A aplicação estará disponível em `https://localhost:5001/api/fornecedores` ou `http://localhost:5000/api/fornecedores`.


## Endpoints Disponíveis

Os endpoints da API foram gerados automaticamente utilizando o **Scaffolding** do Entity Framework Core. 



- **GET** `/api/fornecedores` - Retorna todos os fornecedores.
- **POST** `/api/fornecedores` - Adiciona um novo fornecedor.
- **PUT** `/api/fornecedores/{id}` - Atualiza um fornecedor existente.
- **DELETE** `/api/fornecedores/{id}` - Remove um fornecedor.

## Estrutura do Projeto

- **Model**: Contém as classes de modelo (ex.: `Fornecedor`).
- **Data**: Contém o contexto do banco de dados (`ApiContext`).
- **Controllers**: Contém os controladores da API.

 
   
