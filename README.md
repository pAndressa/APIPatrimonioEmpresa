## Patrimonio_empresa
É necessário executar no Sql Server na versão 2012 o script a baixo para a criação das tabelas no banco de dados, executar na mesa ordem.

```sql
CREATE DATABASE Patrimonio_Empresa;

use Patrimonio_Empresa;

CREATE TABLE Marca(
	marcaID int not null Primary Key identity(1,1),
	nome varchar(200) not null
);

CREATE TABLE Patrimonio(
	numero_tombo int not null PRIMARY KEY  identity(1,1),
	nome varchar(200) not null,
	descricao varchar(500),	
	marcaID int foreign key references Marca(marcaID)
);

CREATE TABLE usuario(
 usuarioId INT PRIMARY KEY Identity(1,1),
 nome VARCHAR(100) NOT NULL,
 email VARCHAR(200) NOT NULL,
 senha VARCHAR(50)NOT NULL
);
```
<p>Nesse projeto foi utilizado o .Net na versão 3.1.</p>
Também é utilizado o JWT para autenticação ( Microsoft.AspNetCore.Authentication.Core/2.2.0 , Microsoft.AspNetCore.Authentication.JwtBearer/3.1.9 ), o NewtonsofJson
(Microsoft.AspNetCore.Mvc.NewtonsoftJson/3.1.9 ), SQLClient ( System.Data.SqlClient/4.8.2 ).
Para se autenticar é neccessário cadastrar um login, ou seja se registrar, utilizando o controller Autoriza.
Não foi utilizado o Swagger, para testar recomendo o uso do postman.

