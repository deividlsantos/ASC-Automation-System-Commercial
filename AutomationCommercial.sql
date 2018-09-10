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