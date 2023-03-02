create database reporteador;
use reporteador;

create table reportes(
id int unsigned not null primary key auto_increment,
ruta varchar(100),
nombre varchar(50),
fecha varchar(50),
estado int(1)
);
