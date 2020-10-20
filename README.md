## Patrimonio_empresa
É necessário executar no Sql Server o script do arquivo 'criar tabelas no sql' ou se preferir segue o código abaixo

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
```
