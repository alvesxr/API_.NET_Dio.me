# 📇 API de Agenda de Contatos — .NET 8

> Primeira API desenvolvida com ASP.NET Core 8, construída durante o curso **TIVIT - .NET com GitHub Copilot** na [DIO.me](https://www.dio.me/).

---

## 📋 Sobre o Projeto

API RESTful para gerenciamento de uma agenda de contatos, com operações completas de **CRUD** (Create, Read, Update, Delete). O projeto foi desenvolvido como prática do módulo **"Criando APIs com .NET C#"**, explorando o fluxo completo de uma API back-end em C#: criação de endpoints, integração com banco de dados via Entity Framework Core e documentação interativa com Swagger.

---

## 🚀 Tecnologias Utilizadas

| Tecnologia | Versão |
|---|---|
| [.NET](https://dotnet.microsoft.com/) | 8.0 |
| [ASP.NET Core](https://docs.microsoft.com/aspnet/core) | 8.0 |
| [Entity Framework Core](https://docs.microsoft.com/ef/core/) | 8.0 |
| [SQL Server](https://www.microsoft.com/sql-server) | — |
| [Swagger / Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) | 6.6.2 |

---

## 📁 Estrutura do Projeto

```
API_.NET_Dio.me/
├── Context/
│   └── AgendaContext.cs         # DbContext do Entity Framework
├── Controllers/
│   └── ContatoController.cs     # Controller com os endpoints do CRUD
├── Entities/
│   └── Contato.cs               # Entidade/modelo de Contato
├── Migrations/                  # Migrations do Entity Framework
├── Program.cs                   # Configuração e inicialização da aplicação
├── appsettings.json
└── appsettings.Development.json # String de conexão com o banco de dados
```

---

## 🗃️ Modelo de Dados

### `Contato`

| Campo | Tipo | Descrição |
|---|---|---|
| `Id` | `int` | Identificador único (chave primária, auto-incremento) |
| `Nome` | `string` | Nome do contato |
| `Telefone` | `int` | Número de telefone (somente dígitos) |
| `Ativo` | `bool` | Indica se o contato está ativo |

---

## 🔌 Endpoints da API

**Base URL:** `/contato`

| Método HTTP | Rota | Descrição |
|---|---|---|
| `POST` | `/contato` | Cria um novo contato |
| `GET` | `/contato` | Retorna todos os contatos |
| `GET` | `/contato/{id}` | Retorna um contato pelo ID |
| `GET` | `/contato/por-nome?nome={nome}` | Busca contatos pelo nome |
| `PUT` | `/contato/{id}` | Atualiza um contato existente |
| `DELETE` | `/contato/{id}` | Remove um contato |

### Exemplos de Uso

#### Criar um contato — `POST /contato`

**Request Body:**
```json
{
  "nome": "João Silva",
  "telefone": 11999999999,
  "ativo": true
}
```

**Response `200 OK`:**
```json
{
  "id": 1,
  "nome": "João Silva",
  "telefone": 11999999999,
  "ativo": true
}
```

---

#### Buscar todos os contatos — `GET /contato`

**Response `200 OK`:**
```json
[
  {
    "id": 1,
    "nome": "João Silva",
    "telefone": 11999999999,
    "ativo": true
  },
  {
    "id": 2,
    "nome": "Maria Souza",
    "telefone": 21988888888,
    "ativo": false
  }
]
```

---

#### Buscar por nome — `GET /contato/por-nome?nome=João`

**Response `200 OK`:**
```json
[
  {
    "id": 1,
    "nome": "João Silva",
    "telefone": 11999999999,
    "ativo": true
  }
]
```

---

#### Atualizar um contato — `PUT /contato/{id}`

**Request Body:**
```json
{
  "nome": "João Silva Atualizado",
  "telefone": 11977777777,
  "ativo": false
}
```

**Response `200 OK`:** dados atualizados do contato.

---

#### Deletar um contato — `DELETE /contato/{id}`

**Response `204 No Content`**

---

## ⚙️ Como Executar Localmente

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads) (Express ou superior)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)

### Passos

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/alvesxr/API_.NET_Dio.me.git
   cd API_.NET_Dio.me
   ```

2. **Configure a string de conexão** no arquivo `appsettings.Development.json`:
   ```json
   {
     "ConnectionStrings": {
       "ConexaoPadrao": "Server=localhost\\sqlexpress; Initial Catalog=Agenda; Integrated Security=True; TrustServerCertificate=True"
     }
   }
   ```
   > Ajuste `Server` conforme sua instância do SQL Server.

3. **Aplique as migrations** para criar o banco de dados:
   ```bash
   dotnet ef database update
   ```

4. **Execute a aplicação:**
   ```bash
   dotnet run
   ```

5. **Acesse o Swagger UI** no navegador:
   ```
   http://localhost:5041/swagger
   ```

---

## 📖 Documentação Interativa (Swagger)

A API conta com documentação interativa gerada automaticamente pelo **Swagger UI**, disponível em `/swagger` quando executada em ambiente de desenvolvimento. Por lá é possível visualizar todos os endpoints e testá-los diretamente no navegador.

---

## 📚 Contexto de Aprendizado

Projeto desenvolvido durante o módulo **"Criando APIs com .NET C#"** do curso **TIVIT - .NET com GitHub Copilot**, oferecido na plataforma [DIO.me](https://www.dio.me/).

**Conceitos praticados:**
- Criação de uma Web API com ASP.NET Core
- Implementação de CRUD completo com Entity Framework Core
- Persistência de dados em SQL Server
- Uso de migrations para versionamento do banco de dados
- Documentação e teste de endpoints com Swagger

---

## 🏷️ Tags

`#dotnet` `#aspnet` `#csharp` `#entityframework` `#sqlserver` `#swagger` `#backend` `#api` `#diome`
