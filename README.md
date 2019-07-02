# ASP.NET Core 2.2 WebApi 

Neste respoitório demonstro uma maneira simples de construir um WebAPI com o ASP.NET Core e consumir através de um projeto MVC.

Este repositório contém uma controller onde existe a chamada de ações na API como GET/POST


## Pacotes
Para buildar o projeto serão necessários os seguintes pacotes:
- Microsoft.AspNetCore.App
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.Extensions.PlatformAbstractions
- Newtonsoft.Json
- Swashbuckle.AspNetCore

Podem ser instalados pelo seguinte comando nuget:

``` 
Install-Package Microsoft.AspNetCore.App -Version 2.2.0
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 2.2.4
Install-Package Microsoft.Extensions.PlatformAbstractions -Version 1.1.0
Install-Package Newtonsoft.Json -Version 12.0.2
Install-Package Swashbuckle.AspNetCore -Version 4.0.1
```

## Como Testar
- Para testar a aplicação MVC é necessário rodar o WebAPI para realizar as consultas.
- Adicionar caminho do XML nas configurações do projeto 

## Swagger
![ASPNETCOREWebAPIVersions](./ss/swagger.png)


## Tela de Inicio
![ASPNETCOREWebAPIVersions](./ss/inicio.png)


## Tela ddo Jogo
![ASPNETCOREWebAPIVersions](./ss/jogo.png)