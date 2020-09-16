Create DataBase UPA_HELPER
use UPA_HELPER

--DROP DATABASE UPA_HELPER

CREATE TABLE especializacao (
  IdEspecializacao INTEGER  NOT NULL  ,
  nome VARCHAR(100)  NOT NULL    ,
PRIMARY KEY(IdEspecializacao));
GO

/*
select *
from especializacao
*/

insert into especializacao
values(1, 'Clínico Geral')
,	  (2, 'Pediatra')
,     (3, 'Urologista')
,     (4, 'Ortopedista')
,     (5, 'Cardiologista')

CREATE TABLE paciente (
  IdPaciente INTEGER IDENTITY(1,1) NOT NULL  ,
  nome VARCHAR(100)  NOT NULL  ,
  CPF CHAR(11)  NOT NULL  ,
  sexo CHAR(1)  NOT NULL  ,
  dataNascimento DATETIME  NOT NULL  ,
  rua VARCHAR(60)  NOT NULL  ,
  bairro VARCHAR(80)  NOT NULL  ,
  cidade VARCHAR(60)  NOT NULL    ,
PRIMARY KEY(CPF))
;
GO

INSERT INTO paciente([nome],[cpf],[sexo],[dataNascimento],[rua],[bairro],[cidade]) VALUES('Rhonda Alexander','72436098623','F','27-02-52','Avenida Nazaré','Ouro Preto','Ribeirão das Neves'),('Ifeoma Swanson','90330330786','F','18-05-33','Avenida Adelino Jorge Montenegro','Arvoredo','Belo Horizonte'),('Dai Stafford','96142833603','F','19-09-55','Rua Rynaldo Borgianni','Bairro Industrial','Sabará'),('Tanya Conley','23963244462','F','30-03-86','Rua Rynaldo Borgianni','Ouro Preto','Betim'),('Colette Odom','90741675620','F','27-03-80','Rua João Paulo Meira','Bairro Industrial','Betim'),('Kelly Acosta','63406304474','F','21-08-65','Rua Comendador Assad Abdalla','Santa Cruz','Ribeirão das Neves'),('Lynn Sanchez','80041331047','F','21-07-85','Rua Rynaldo Borgianni','Acaiaca','Ribeirão das Neves'),('Isabella Moore','33061858638','F','01-09-84','Rua Comendador Assad Abdalla','Glória','Betim'),('Diana Santana','95177868381','F','24-03-05','Rua Acioli Monteiro','União','Sabará'),('Chastity Mcdonald','73575076629','F','17-04-54','Avenida Nazaré','Maria da Conceição','Sabará')
,																						 ('Alexander Mclean','81756771090','M','26-02-72','Rua Emí­lio Retrosi','Bairro Industrial','Contagem'),('Raphael Bridges','60226700503','M','01-12-14','Rua Manuel Teles Vitancos','Dom Joaquim','Ribeirão das Neves'),('Graham Morrison','86586025095','M','16-06-89','Rua João Paulo Meira','Arvoredo','Betim'),('Brian Dotson','77346946371','M','17-09-87','Rua Comendador Assad Abdalla','Arvoredo','Ribeirão das Neves'),('Kasper Davidson','22071918861','M','19-08-66','Rua Venceslau José Bernardes','Dom Joaquim','Sabará'),('Basil Edwards','27934457481','M','21-11-47','Rua Clodomiro Pinheiro','União','Sabará'),('Emery Merritt','16226940415','M','02-12-52','Avenida João Barreto de Menezes','Liberdade','Ribeirão das Neves'),('Stone Reilly','53456239890','M','24-01-79','Rua Comendador Assad Abdalla','Arvoredo','Belo Horizonte'),('Graham Good','17630728443','M','12-04-55','Rua Nelson Ferreira','Dona Clara','Ribeirão das Neves'),('Mufutau Meadows','33940429295','M','13-08-47','Rua John Redford','Riacho das Pedras','Betim')

/*
select *
from paciente
*/

CREATE TABLE UPA (
  IdUPA INTEGER IDENTITY(1,1) NOT NULL  ,
  rua VARCHAR(60)  NOT NULL  ,
  numero INTEGER  NOT NULL  ,
  bairro VARCHAR(80)  NOT NULL  ,
  cidade VARCHAR(60)  NOT NULL  ,
  regional VARCHAR(80)  NOT NULL    ,
PRIMARY KEY(IdUPA));
GO

insert into UPA
values('Av. Aurélio Lopes', '20', 'Diamante', 'Belo Horizonte', 'Barreiro')
,	  ('Rua Domingos Vieira', '488', 'Santa Efigênia', 'Belo Horizonte', 'Centro-Sul')
,	  ('Av. dos Andradas', '7260', 'Vera Cruz', 'Belo Horizonte', 'Leste')
,     ('R. Joaquim Gouvêia', '560', 'Nossa Senhora Aparecida', 'Belo Horizonte', 'Nordeste')
,     ('Rua da Formiga', '50', 'São Cristóvão', 'Belo Horizonte', 'Noroeste')
,	  ('Av. Barão Homem de Melo', '1710', 'Jardim America', 'Belo Horizonte', 'Oeste')
,     ('Av. Santa Terezinha', '515', 'Santa Terezinha', 'Belo Horizonte', 'Pampulha')
,     ('R. Oscar Lobo Pereira', '270', 'Primeiro de Maio', 'Belo Horizonte', 'Norte')
,     ('R. Padre Pedro Pinto', '175', 'Venda Nova', 'Belo Horizonte', 'Venda Nova')

/*
drop table upa

select *
from UPA
*/

CREATE TABLE departamento (
  IdDepartamento INTEGER  NOT NULL  ,
  nome VARCHAR(100)  NOT NULL    ,
PRIMARY KEY(IdDepartamento));
GO

insert into departamento
values (1, 'Recepcao')
,      (2, 'Enfermagem')

/*
select *
from departamento
*/

CREATE TABLE medico (
  IdMedico INTEGER IDENTITY(1,1)  NOT NULL  ,
  CRM VARCHAR(5)  NOT NULL  ,
  nome VARCHAR(100)  NOT NULL  ,
  IdEspecializacao INTEGER  NOT NULL    ,
PRIMARY KEY(IdMedico),
  FOREIGN KEY(IdEspecializacao)
    REFERENCES especializacao(IdEspecializacao));
GO

insert into medico
values('65610', 'Douglas Ramos', 3)
,     ('12010', 'Gabriel do Carmo', 1)

/*
drop table medico
*/


CREATE INDEX IFK_FK__medico__IdEspeci__4222 ON medico (IdEspecializacao);
GO


CREATE TABLE administrador (
  IdAdministrador INTEGER  NOT NULL  ,
  nome VARCHAR(100)  NOT NULL  ,
  CPF CHAR(11)  NOT NULL  ,
  sexo CHAR(1)  NOT NULL  ,
  IdDepartamento INTEGER  NOT NULL  ,
  IdUPA INTEGER  NOT NULL  ,
  ATIVO BIT  NOT NULL DEFAULT ((0)) ,
  loginAdm VARCHAR(20)  NOT NULL  ,
  senha VARCHAR(8)  NOT NULL    ,
PRIMARY KEY(IdAdministrador),
  FOREIGN KEY(IdDepartamento)
    REFERENCES departamento(IdDepartamento),
  FOREIGN KEY(IdUPA)
    REFERENCES UPA(IdUPA));
GO


CREATE INDEX IFK_FK__administr__IdDep__5070 ON administrador (IdDepartamento);
GO
CREATE INDEX IFK_FK__administr__IdUPA__5165 ON administrador (IdUPA);
GO


CREATE TABLE funcionario (
  IdFuncionario INTEGER  NOT NULL  ,
  nome VARCHAR(100)  NOT NULL  ,
  CPF CHAR(11)  NOT NULL  ,
  sexo CHAR(1)  NOT NULL  ,
  IdDepartamento INTEGER  NOT NULL  ,
  IdUPA INTEGER  NOT NULL  ,
  ATIVO BIT  NOT NULL DEFAULT ((0)) ,
  loginFunc VARCHAR(20)  NOT NULL  ,
  senha VARCHAR(8)  NOT NULL    ,
  fotoFunc varchar(100)
PRIMARY KEY(IdFuncionario),
  FOREIGN KEY(IdDepartamento)
    REFERENCES departamento(IdDepartamento),
  FOREIGN KEY(IdUPA)
    REFERENCES UPA(IdUPA));
GO

insert into funcionario
values (1, 'Daniel Paiva', '12345678910', 'm', 1, 1, 1, 'paiva', '101010', 'C:\Users\Paiva\Desktop\upa-helper-csharp-project\images\user_paiva.jpg')
,      (2, 'Guilherme Pujoni', '70094562679', 'm', 1, 2, 1, 'pujoni', '202020', 'C:\Users\Paiva\Desktop\upa-helper-csharp-project\images\user_pujoni.jpeg')
,	   (3, 'Gabriel Mariano', '12345678911', 'm', 2, 3, 1, 'gabriel', '303030', 'C:\Users\Paiva\Desktop\upa-helper-csharp-project\images\user_gab.jpeg')  
,      (4, 'Douglas Ramos', '12345678950', 'm', 1, 4, 1, 'douglas', '404040', 'C:\Users\Paiva\Desktop\upa-helper-csharp-project\images\user_doug.jpeg')


/*
drop table funcionario

select *
from funcionario
*/

CREATE INDEX IFK_FK__funcionar__IdDep__5812 ON funcionario (IdDepartamento);
GO
CREATE INDEX IFK_FK__funcionar__IdUPA__5906 ON funcionario (IdUPA);
GO


CREATE TABLE atendimento (
  IdAtendimento INTEGER IDENTITY(1,1) NOT NULL  ,
  IdUPA INTEGER  NOT NULL  ,
  IdEspecializacao INTEGER  NOT NULL  ,
  statusAtendimento BIT  NOT NULL DEFAULT ((1)) ,
  descriçãoProblema TEXT  NOT NULL  ,
  dataAtendimento DATETIME  NOT NULL    ,
  CPF CHAR(11)	not null,
PRIMARY KEY(IdAtendimento),
  FOREIGN KEY(IdEspecializacao)
    REFERENCES especializacao(IdEspecializacao),
  FOREIGN KEY(CPF)
    REFERENCES paciente(CPF),
  FOREIGN KEY(IdUPA)
    REFERENCES UPA(IdUPA));
GO

/*
select *
from atendimento
*/

CREATE INDEX IFK_FK__atendimen__IdMed__46E7 ON atendimento (IdEspecializacao);
GO
CREATE INDEX IFK_FK__atendimen__IdUPA__45F3 ON atendimento (IdUPA);
GO
