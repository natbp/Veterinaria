create database veterinaria
go
use veterinaria
go

create table clientes(
cedula_cli int primary key,
nombre_cli varchar(255),
nombre_usuc varchar(255),
direccion_cli varchar(255),
telefono_cli int,
contrasena_cli varchar(255)
);

create table mascotas(
id int primary key identity(1,1),
nombre_mascota varchar(255),
edad_mascota int,
raza varchar (255),
peso int,
descripcion text,
fk_cliente int foreign key references clientes (cedula_cli)
);

create table veterinarios(
cedula_vet int primary key,
nombre_vet varchar(255),
nombre_usuv varchar(255),
edad_vet int,
direccion_vet varchar(255),
correo_vet varchar(255),
telefono_vet int,
eps varchar(255),
contrasena_vet int
);

create table administracion(
id_admi int primary key identity(1,1),
nombre_admi varchar(255),
contrasena_admi int,
direccion_admi varchar(255),
telefono_admi int,
fk_cliente int foreign key references clientes (cedula_cli),
fk_veterinario int foreign key references veterinarios (cedula_vet),
fk_mascota int foreign key references mascotas (id)
);