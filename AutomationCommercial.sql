create database AutomationCommercial;

use AutomationCommercial;

create table endereco(
id bigint primary key auto_increment,
rua varchar(50) not null,
numero int not null,
bairro varchar(50) not null,
cidade varchar(50) not null,
estado varchar(45) not null,
pais varchar(45) not null);

create table cargo(
id bigint primary key auto_increment,
descricao varchar(50) not null,
teto_mini decimal not null,
teto_max decimal not null);

create table clientes(
id bigint primary key auto_increment,
id_endereco bigint,
nome varchar(45) not null,
rg varchar(10) not null,
cpf varchar(11) not null,
email varchar(50) not null,
telefone varchar(10),
celular varchar(11) not null,
foreign key (id_endereco) references endereco(id));

