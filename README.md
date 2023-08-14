# DS - Projeto Bancário
Segunda atividade de programação orientada a objetos na matéria de Desenvolvimento de Sistemas no curso Técnico em Desenvolvimento de Sistemas na Etec Albert Einstein.
Essa atividade foi passada pela professora Cristiane Tuji, com o objetivo de utilizar os conhecimentos passados em sala de aula no dia 08/08/2023.

## Features

O projeto foi construído em C# e .NET e se trata de um sistema básico de console que identifica dados do triângulo que o usuário informou utilizando Orientação a Objetos.
Para criar um projeto em C# e .NET no VS Code, siga as instruções abaixo:

1- `dotnet new console --use-program-main`: cria um novo console no modelo de estrutura antigo

~~~C#
namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
~~~

2- `dotnet new sln -n SolutionName`: cria uma nova solução

3- `dotnet sln add Project.csproj`: adiciona o projeto à solução criada

4- `dotnet run`: executa o código

5- `dotnet publish --configuration Release`: Publica o código para ser executado. 
Para executá-lo, acesse `bin\Release\net7.0\publish` e nesse pasta clique com o botão direito e seleciona a opção de abrir no terminal. Em seguida, execute o comando `dotnet NomeDoProjeto.dll`.

Opcional: Caso queira que as diretivas `using` não sejam implícitas, ou seja, que seja feito de forma manual, vá no arquivo de projeto e troque `<ImplicitUsings>enable</ImplicitUsings>` por `<ImplicitUsings>disable</ImplicitUsings>` como mostrado abaixo:

~~~XML

<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    ...
    <ImplicitUsings>disable</ImplicitUsings>
  </PropertyGroup>

</Project>

~~~
