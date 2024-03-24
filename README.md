# Roteiro do Desafio Backend Projeto de Manipulação de String

Este roteiro contempla o desenvolvimento de uma API em C# utilizando o ASP.NET Core, organizado segundo os princípios da Clean Architecture. A API oferece um endpoint para manipulação de strings, incluindo a verificação de palíndromos e a contagem de ocorrências de caracteres. Além disso, é detalhado como realizar testes no endpoint usando o Postman.

## Arquitetura e Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** ASP.NET Core
- **Arquitetura:** Clean Architecture
- **Ferramentas de Desenvolvimento:**
  - Visual Studio (para desenvolvimento e compilação)
  - .NET CLI (para compilação e execução via linha de comando)
  - Postman (para testar a API)

## Estrutura do Projeto

A solução é organizada em múltiplas camadas, seguindo a Clean Architecture:

- **Domain**: Contém as entidades e interfaces de domínio.
- **Application**: Orquestra as operações, dependendo das interfaces definidas no domínio.
- **Infrastructure**: Implementa a lógica de acesso a dados e serviços externos.
- **Presentation (API)**: Oferece os endpoints para interação com o usuário ou sistemas externos.

## Compilando e Executando a API

### Utilizando o Visual Studio

1. **Abrir a Solução**: Abra o arquivo `.sln` no Visual Studio.
2. **Restaurar Pacotes NuGet**: Clique com o botão direito na solução e selecione "Restore NuGet Packages".
3. **Compilar a Solução**: Selecione "Build" > "Build Solution".
4. **Executar a API**: Pressione `F5` ou clique em "Debug" > "Start Debugging".

### Utilizando o .NET CLI

Abra um terminal ou prompt de comando e navegue até o diretório do projeto da API.

```bash
# Restaurar Pacotes NuGet
dotnet restore

# Compilar o Projeto
dotnet build

# Executar a API
dotnet run --project Caminho/Para/O/Projeto.csproj
