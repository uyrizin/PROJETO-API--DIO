# Contact Management API

API REST desenvolvida em ASP.NET Core para cadastro e gerenciamento de contatos.

Este projeto nasceu como um desafio de estudos da DIO e foi evoluido para servir como projeto de portfolio, com uma estrutura mais clara, endpoints organizados e documentacao de execucao local.

## Objetivo

Praticar desenvolvimento back-end com C# e .NET, aplicando conceitos de API REST, Entity Framework Core, persistencia em SQL Server e documentacao de endpoints.

## Tecnologias

- C#
- .NET 9
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- OpenAPI
- Git e GitHub

## Funcionalidades

- Cadastro de contatos
- Listagem de contatos
- Busca de contato por id
- Atualizacao de contato
- Remocao de contato
- Persistencia com Entity Framework Core
- Migrations para versionamento do banco de dados

## Endpoints

| Metodo | Rota | Descricao |
|---|---|---|
| GET | `/api/contatos` | Lista todos os contatos |
| GET | `/api/contatos/{id}` | Busca um contato por id |
| POST | `/api/contatos` | Cria um novo contato |
| PUT | `/api/contatos/{id}` | Atualiza um contato existente |
| DELETE | `/api/contatos/{id}` | Remove um contato |

## Exemplo de requisicao

```http
POST /api/contatos
Content-Type: application/json
```

```json
{
  "nome": "Yuri Higa",
  "telefone": "(00) 00000-0000",
  "ativo": true
}
```

## Como executar localmente

### Pre-requisitos

- .NET 9 SDK
- SQL Server ou SQL Server Express
- Git

### Passos

Clone o repositorio:

```bash
git clone https://github.com/uyrizin/PROJETO-API--DIO.git
cd PROJETO-API--DIO
```

Configure a connection string em `appsettings.Development.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost\\sqlexpress;Initial Catalog=bancodedadosapi;Integrated Security=True;TrustServerCertificate=True"
  }
}
```

Restaure os pacotes:

```bash
dotnet restore
```

Aplique as migrations:

```bash
dotnet ef database update
```

Execute a API:

```bash
dotnet run
```

Com a aplicacao rodando, teste os endpoints pelo arquivo `projeto api.http` ou por uma ferramenta como Postman/Insomnia.

## Estrutura principal

```text
Controllers/
  ContatosController.cs
Controllers/Entitys/
  Contatos.cs
context/
  Agenda.cs
Migrations/
  ...
Program.cs
```

## Proximos passos

- Adicionar DTOs para entrada e saida de dados
- Adicionar validacoes com Data Annotations ou FluentValidation
- Criar testes automatizados
- Adicionar autenticacao com JWT
- Publicar a API com Docker
- Criar pipeline de CI/CD no GitHub Actions

## Autor

Yuri Higa

- GitHub: [github.com/uyrizin](https://github.com/uyrizin)
- LinkedIn: [linkedin.com/in/yuri-higa-885750334](https://www.linkedin.com/in/yuri-higa-885750334)
