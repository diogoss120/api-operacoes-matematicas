## api-operacoes-matematicas

Api simples feita com ASP.NET Core Web Api para realização de operações matemáticas.
<p>  Está api está documentada com o Swagger e poderá testada assim que executar o projeto. <br/>
Também implementei autenticação com JWT, disponibilizei um controller e uma action onde é possivel fazer o login com dados de email e senha <br/>
para obter como retorno da api um token que pode ser usado para se autenticar através do proprio Swagger.
 </p>
 
### Os seguintes logins poderam ser usados para se autenticar:
 - email: joao@gmail.com, senha: 123456, perfil: Aluno
 - email: marcelo@gmail.com, senha: 123456, perfil: Aluno
 - email: maria@gmail.com, senha: 123456, perfil: Matematico
 - email: roberto@gmail.com, senha: 123456, perfil: Matematico
 
<p>
 Esses dados de login estão em memoria, não implementei acesso ao banco de dados. <br/>
 O endpoint para somar números é aberto para ser usado livremente, o de multiplicar obriga que o usuário esteja autenticado e o de dividir <br/>
 obriga que o usuário esteja autenticado e que tenha a Role/Perfil 'Matematico'
</p>


## Para executar esse projeto:
- realize o clone do repositório com o git bash ou faça o download
- com o git bash ou terminal do sistema operacional, navegue até o diretório do projeto e execute:
- dotnet restore  // para restaurar as dependências
- dotnet watch run   // para rodar 
- ou abra o projeto com o visual studio e execute a aplicação por ele

## 🛠 Tecnologias
As seguintes ferramentas foram usadas na construção do projeto:

- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [ASP.NET core Web Api](https://docs.microsoft.com/pt-br/aspnet/core/web-api/?view=aspnetcore-5.0)
- [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
