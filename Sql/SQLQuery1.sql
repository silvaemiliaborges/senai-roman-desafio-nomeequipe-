create database T_Roman;

use T_Roman;


-------DDL-------

create table TipoUsuario (
		IdTipoUsuario int primary key identity
		,Nome varchar (255) not null unique
);
create table Professor (
    IdProfessor int primary key identity
	,NomeDoProfessor varchar (255) not null
	,IdTipoUsuario int foreign key references TipoUsuario(IdTipoUsuario)
	,Email varchar (255) not null unique
	,Senha varchar (255) not null 
);
create table Projeto (
	
	IdProjeto int primary key identity
	,Nome varchar (255) not null
	,Tema varchar (255) not null unique
	,NomeDoProfessor int foreign key references Professor(IdProfessor)
);

------DML------

insert into TipoUsuario(Nome)
values ('Professor'), ('Aluno'), ('Outros');

insert into Professor (NomeDoProfessor, IdTipoUsuario, Email, Senha)

values ('Edinalva', 1, 'Edi@nalva.com', '123456'),
		('Robson', 2, 'rob@son.com', '654321'),
		('Barbara',3, 'bar@bara.com', '987456');

insert into Projeto (Nome, Tema, NomeDoProfessor)
values ('Controle de Estoque', 'Gestão', 1 ),
		('Listagem de personagens', 'HQ’s', 1);

select * from Projeto
select * from Professor
select * from TipoUsuario


