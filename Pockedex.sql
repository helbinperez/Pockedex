create database Pockedex
use Pockedex

--Tabla creada
create table Tipo_Pockemon
(
Id_tipo int IDENTITY,
Tipo varchar(100) 
)
alter table Tipo_Pockemon
ADD CONSTRAINT Id_tipo PRIMARY KEY (Id_tipo)

INSERT INTO Tipo_Pockemon(Tipo)
VALUES('VOLADOR')

INSERT INTO Tipo_Pockemon(Tipo)
VALUES('FUEGO')


--Tabla Ataques
create table Ataques
(
Id_ataque int IDENTITY,
Ataque varchar(50),
Constraint pk_id_ataque primary key (Id_ataque)
)

INSERT INTO Ataques(Ataque)
VALUES('PICOTAZO VENENO')

INSERT INTO Ataques(Ataque)
VALUES('GIRO FUEGO')

--Tabla Color
create table Color
(
Id_color int IDENTITY,
Color varchar(50),
constraint pk_id_color primary key (Id_color)
)

INSERT INTO Color(Color)
VALUES('ROJO')

INSERT INTO Color(Color)
VALUES('MORADO')


--Tabla Region
create table Region
(
Id_region int IDENTITY,
Region varchar(50),
Color_id int,
constraint pk_id_region primary key(Id_region)
)

INSERT INTO Region (Region, Color_id)
VALUES('TESELIA', 1)

INSERT INTO Region (Region, Color_id)
VALUES('SINNOH', 2)

--Tabla Pockemon
create table Pockemon
(
Id_Pockemon int IDENTITY,
Pockemon varchar(50),
Peso float,
Altura float,
Tipo_id int,
Region_id int,
constraint pk_pockemon primary key (Id_Pockemon),
constraint fk_pockemon_tipo_pock foreign key(Tipo_id) references Tipo_Pockemon(Id_tipo)
)
INSERT INTO Pockemon(Pockemon, Peso, Altura, Tipo_id, Region_id)
VALUES('PICKACHU', 10.5, 3.5, 1, 2)

INSERT INTO Pockemon(Pockemon, Peso, Altura, Tipo_id, Region_id)
VALUES('BOBARSO', 8.5, 2.5, 2, 1)

--Tabla Pockemon_Ataques
create table Pockemon_Ataque
(
Ataque_id int,
Pockemon_id int,
constraint pk_ataque_pockemon primary key (Ataque_id, Pockemon_id),
constraint fk_ataque_pockemon foreign key (Ataque_id) references Ataques(Id_ataque),
constraint fk_pockemon_ataque foreign key (Pockemon_id) references Pockemon(Id_pockemon)
)


SELECT * FROM POCKEMON
