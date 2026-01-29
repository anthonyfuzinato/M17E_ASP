/* Criar a tabela utilizadores */
create table utilizadores (
	id int identity primary key,
	email varchar(200) unique not null check(email like '%@%.%'),
	nome varchar(100) not null,
	palavra_passe varchar(64) not null,
	sal int,
	token varchar(100),
	data_validade date,
	perfil int
);

/* Criar um admin */
insert into utilizadores (email, nome, palavra_passe, sal, perfil)
values ('admin@gmail.com','admin',HASHBYTES('SHA2_512','123450'),0,0);

insert into utilizadores(email, nome, palavra_passe, sal, perfil)
values ('anthony@gmail.com','admin',HASHBYTES('SHA2_512','123450'),0,0);