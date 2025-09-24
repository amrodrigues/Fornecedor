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
```json 
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=FornecedorDb;Trusted_Connection=True;"
  }
}
```

### Restaurar Dependências

Execute o comando abaixo para restaurar os pacotes necessários:

```bash
 dotnet tool install --global dotnet-ef 
```

### Criar o Banco de Dados

1. Crie as migrações:
```bash
 dotnet ef migrations add InitialCreate 
```
2. Aplique as migrações para criar o banco de dados:
```bash
 dotnet ef database update  
```
### Executar a Aplicação

Execute o comando abaixo para iniciar a aplicação:
```bash
dotnet run 
```

A aplicação estará disponível em `https://localhost:5001/api/fornecedores` ou `http://localhost:5000/api/fornecedores`.



## Endpoints Disponíveis

Os endpoints da API foram gerados automaticamente utilizando o **Scaffolding** do Entity Framework Core. 

<img width="1038" height="574" alt="Scalofin" src="https://github.com/user-attachments/assets/274328b9-ae11-4352-aea9-5ef726c84406" />
<img width="885" height="377" alt="Controlador" src="https://github.com/user-attachments/assets/de2192ff-2e6a-4cc4-88ea-1e8a0c7d399e" />
 
- **GET** `/api/fornecedores` - Retorna todos os fornecedores.
- **POST** `/api/fornecedores` - Adiciona um novo fornecedor.
- **PUT** `/api/fornecedores/{id}` - Atualiza um fornecedor existente.
- **DELETE** `/api/fornecedores/{id}` - Remove um fornecedor.

## Estrutura do Projeto

- **Model**: Contém as classes de modelo (ex.: `Fornecedor`).
- **Data**: Contém o contexto do banco de dados (`ApiContext`).
- **Controllers**: Contém os controladores da API.

## Testes da API

As funcionalidades de **CRUD** (Create, Read, Update, Delete) desta API foram testadas e validadas usando o **Postman**. Todos os endpoints estão funcionando corretamente.

 
   
