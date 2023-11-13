CREATE DATABASE CineNuevo
GO

USE CineNuevo
GO

CREATE TABLE CARGOS
(
	id_cargo int identity(1,1),
	descripcion varchar(50)

	CONSTRAINT PK_CARGOS PRIMARY KEY (id_cargo)
);

CREATE TABLE BARRIOS
(
	id_barrio int identity(1,1),
	barrio varchar(50)

	CONSTRAINT PK_BARRIOS PRIMARY KEY (id_barrio)
);

CREATE TABLE TIPOS_DOC
(
	id_tipo_doc int identity(1,1),
	tipo varchar(50)

	CONSTRAINT PK_TIPOS_DOC PRIMARY KEY (id_tipo_doc)
);

CREATE TABLE PROMOCIONES
(
	id_promocion int identity(1,1),
	fecha_desde datetime,
	fecha_hasta datetime,
	procentaje_descuento int

	CONSTRAINT PK_PROMOCIONES PRIMARY KEY (id_promocion)
);

CREATE TABLE CLIENTES
(
	id_cliente int identity(1,1),
	nombre varchar(50),
	apellido varchar(50),
	documento int,
	fecha_nac date,
	email varchar(50)

	CONSTRAINT PK_CLIENTES PRIMARY KEY (id_cliente)
);

CREATE TABLE EMPLEADOS
(
	id_empleado int identity(1,1),
	nombre varchar(50),
	apellido varchar(50),
	id_tipo_doc int,
	documento int,
	fecha_nac date,
	id_barrio int,
	id_cargo int,
	fecha_alta date,
	telefono varchar(50),
	email varchar(50)

	CONSTRAINT PK_EMPLEADOS PRIMARY KEY (id_empleado),
	
	CONSTRAINT FK_EMPLEADOS_TIPOS_DOC FOREIGN KEY (id_tipo_doc)
		REFERENCES TIPOS_DOC(id_tipo_doc),
	
	CONSTRAINT FK_EMPLEADOS_BARRIOS FOREIGN KEY (id_barrio)
		REFERENCES BARRIOS(id_barrio),
	
	CONSTRAINT FK_EMPLEADOS_CARGOS FOREIGN KEY (id_cargo)
		REFERENCES CARGOS(id_cargo)
);

CREATE TABLE MEDIOS_PEDIDO
(
	id_medio_pedido int identity(1,1),
	descripcion varchar(50)

	CONSTRAINT PK_MEDIOS_PEDIDO PRIMARY KEY (id_medio_pedido)
);

CREATE TABLE FORMAS_PAGO
(
	id_forma_pago int identity(1,1),
	descripcion varchar(50),
	porcentaje_recargo int

	CONSTRAINT PK_FORMAS_PAGO PRIMARY KEY (id_forma_pago)
);


CREATE TABLE TICKETS/**/
(
	id_ticket int identity(1,1),
	fecha date,
	id_cliente int,
	id_empleado int,
	id_medio_pedido int,
	id_promocion int,
	id_forma_pago int,
	total decimal,
	estado bit

	CONSTRAINT PK_TICKETS PRIMARY KEY (id_ticket),
	
	CONSTRAINT FK_TICKETS_CLIENTES FOREIGN KEY (id_cliente)
		REFERENCES CLIENTES(id_cliente),

	CONSTRAINT FK_TICKETS_EMPLEADOS FOREIGN KEY (id_empleado)
		REFERENCES EMPLEADOS(id_empleado),
	
	CONSTRAINT FK_TICKETS_MEDIOS_PEDIDO FOREIGN KEY (id_medio_pedido)
		REFERENCES MEDIOS_PEDIDO(id_medio_pedido),

	CONSTRAINT FK_TICKETS_PROMOCIONES FOREIGN KEY (id_promocion)
		REFERENCES PROMOCIONES(id_promocion),

	CONSTRAINT FK_TICKETS_FORMASP FOREIGN KEY (id_forma_pago)
		REFERENCES FORMAS_PAGO(id_forma_pago)
);

--CREATE TABLE TICKETS_FORMASP
--(
--	id_ticket_forma int identity(1,1),
--	id_ticket int,
--	id_forma_pago int,
--	monto_recargo int,

--	CONSTRAINT PK_TICKETS_FORMASP PRIMARY KEY (id_ticket_forma),

--	CONSTRAINT FK_TICKETS_FORMASP_TICKETS FOREIGN KEY (id_ticket)
--		REFERENCES TICKETS(id_ticket),
	
--	CONSTRAINT FK_TICKETS_FORMASP_FORMAS_PAGO FOREIGN KEY (id_forma_pago)
--		REFERENCES FORMAS_PAGO(id_forma_pago)
--);

CREATE TABLE NACIONALIDADES
(
	id_nacionalidad int identity(1,1),
	nacionalidad varchar(50)

	CONSTRAINT PK_NACIONALIDADES PRIMARY KEY (id_nacionalidad)
);

CREATE TABLE CLASIFICACIONES
(
	id_clasificacion int identity(1,1),
	clasificacion varchar(50)

	CONSTRAINT PK_CLASIFICACIONES PRIMARY KEY (id_clasificacion)
);

CREATE TABLE GENEROS
(
	id_genero int identity(1,1),
	genero varchar(50)

	CONSTRAINT PK_GENEROS PRIMARY KEY (id_genero)
);

create table IDIOMAS/**/
(
id_idioma int identity(1,1),
idioma varchar(200)
constraint pk_idioma primary key(id_idioma)
)

CREATE TABLE PELICULAS/**/
(
	id_pelicula int identity(1,1),
	titulo varchar(50),
	duracion int,
	sinopsis varchar(300),
	id_clasificacion int,
	id_genero int,
	id_idioma int,

	CONSTRAINT PK_PELICULAS PRIMARY KEY (id_pelicula),

	CONSTRAINT FK_PELICULAS_CLASIFICACIONES FOREIGN KEY (id_clasificacion)
		REFERENCES CLASIFICACIONES(id_clasificacion),
	
	CONSTRAINT FK_PELICULAS_GENEROS FOREIGN KEY (id_genero)
		REFERENCES GENEROS(id_genero),

	constraint fk_idiomas foreign key(id_idioma)
		references IDIOMAS(id_idioma)
);

CREATE TABLE ACTORES
(
	id_actor int identity(1,1),
	nombre varchar(50),
	apellido varchar(50),
	fecha_nac date,
	id_nacionalidad int,

	CONSTRAINT PK_ACTORES PRIMARY KEY (id_actor),

	CONSTRAINT FK_ACTORES_NACIONALIDADES FOREIGN KEY (id_nacionalidad)
		REFERENCES NACIONALIDADES(id_nacionalidad)
);

CREATE TABLE DIRECTORES
(
	id_director int identity(1,1),
	nombre varchar(50),
	apellido varchar(50),
	fecha_nac date,
	id_nacionalidad int,

	CONSTRAINT PK_DIRECTORES PRIMARY KEY (id_director),

	CONSTRAINT FK_DIRECTORES_NACIONALIDADES FOREIGN KEY (id_nacionalidad)
		REFERENCES NACIONALIDADES(id_nacionalidad)
);

CREATE TABLE PELICULAS_ACTORES
(
	id_pelicula_act int identity(1,1),
	id_pelicula int,
	id_actor int,

	CONSTRAINT PK_PELICULAS_ACTORES PRIMARY KEY (id_pelicula_act),

	CONSTRAINT FK_PELICULAS_ACTORES_PELICULAS FOREIGN KEY (id_pelicula)
		REFERENCES PELICULAS(id_pelicula),

	CONSTRAINT FK_PELICULAS_ACTORES_ACTORES FOREIGN KEY (id_actor)
		REFERENCES ACTORES(id_actor)
);

CREATE TABLE PELICULAS_DIRECTORES
(
	id_pelicula_direct int identity(1,1),
	id_pelicula int,
	id_director int,

	CONSTRAINT PK_PELICULAS_DIRECTORES PRIMARY KEY (id_pelicula_direct),

	CONSTRAINT FK_PELICULAS_DIRECTORES_PELICULAS FOREIGN KEY (id_pelicula)
		REFERENCES PELICULAS(id_pelicula),

	CONSTRAINT FK_PELICULAS_DIRECTORES_DIRECTORES FOREIGN KEY (id_director)
		REFERENCES DIRECTORES(id_director)
);

CREATE TABLE TIPOS_SALAS
(
	id_tipo_sala int identity(1,1),
	tipo varchar(50)

	CONSTRAINT PK_TIPOS_SALAS PRIMARY KEY (id_tipo_sala)
);

CREATE TABLE SALAS
(
	id_sala int identity(1,1),
	nro_sala int,
	id_tipo_sala int,

	CONSTRAINT PK_SALAS PRIMARY KEY (id_sala),

	CONSTRAINT FK_SALAS_TIPOS_SALAS FOREIGN KEY (id_tipo_sala)
		REFERENCES TIPOS_SALAS(id_tipo_sala)
);

--CREATE TABLE ESTADOS
--(
--	id_estado int identity(1,1),
--	estado varchar(50),

--	CONSTRAINT PK_ESTADOS PRIMARY KEY (id_estado)
--);

--CREATE TABLE HORARIOS
--(
--	id_horario int identity(1,1),
--	horario datetime

--	CONSTRAINT PK_HORARIOS PRIMARY KEY (id_horario)
--);

create table FORMATOS/**/
(
id_formato int identity(1,1),
formato varchar(200)
constraint pk_formato primary key(id_formato)
)


CREATE TABLE FUNCIONES/**/
(
	id_funcion int identity(1,1),
	id_sala int,
	--id_horario int,
	horario datetime,
	id_formato int,
	estado bit,
	id_pelicula int,
	precio decimal,
	fecha_desde datetime,
	fecha_hasta datetime,
	
	CONSTRAINT PK_FUNCIONES PRIMARY KEY (id_funcion),

	constraint fk_formato foreign key(id_formato)
		references formatos(id_formato),

	CONSTRAINT FK_FUNCIONES_SALAS FOREIGN KEY (id_sala)
		REFERENCES SALAS(id_sala),
	
	--CONSTRAINT FK_FUNCIONES_HORARIOS FOREIGN KEY (id_horario)
	--	REFERENCES HORARIOS(id_horario),

	CONSTRAINT FK_FUNCIONES_PELICULAS FOREIGN KEY (id_pelicula)
		REFERENCES PELICULAS(id_pelicula)
);


CREATE TABLE BUTACAS/**/
(
	id_butaca int identity(1,1),
	numero int,
	CONSTRAINT PK_BUTACAS PRIMARY KEY (id_butaca),
);

CREATE TABLE DETALLES_TICKET/**/
(
	id_detalle int identity(1,1),
	id_ticket int,
	id_funcion int,
	id_butaca int,
	precio_venta decimal,

	CONSTRAINT PK_DETALLES_TICKET PRIMARY KEY (id_detalle),

	CONSTRAINT FK_DETALLES_TICKET_TICKETS FOREIGN KEY (id_ticket)
		REFERENCES TICKETS(id_ticket),

	constraint fk_butacas foreign key(id_butaca)
		references butacas(id_butaca),

	CONSTRAINT FK_DETALLES_TICKET_FUNCIONES FOREIGN KEY (id_funcion)
		REFERENCES FUNCIONES(id_funcion)
);


create table RESERVADAS/**/
(
id_reserva int identity(1,1),
id_butaca int,
id_funcion int,

constraint pk_Reservadas primary key (id_reserva),
constraint fk_butaca foreign key(id_butaca)
	references butacas(id_butaca),
constraint fk_funcion foreign key (id_funcion)
	references funciones(id_funcion)
)


----------------------------OK


create proc SP_INSERTAR_TICKET
@nuevo_id_ticket int output,
@fecha datetime,
@id_cliente int,
@id_medio_pedido int,
@id_promocion int,
@total money,
@id_forma_pago int
as
begin
insert into TICKETS(fecha,id_cliente,id_medio_pedido,id_promocion,total,estado, id_forma_pago) 
values (@fecha,@id_cliente,@id_medio_pedido,@id_promocion,@total,1,@id_forma_pago);
	set @nuevo_id_ticket = SCOPE_IDENTITY()
end;

create procedure SP_INSERTAR_DETALLE
@id_ticket int,
@id_funcion int,
@id_butaca int,
@precio_venta money
as
begin
insert into DETALLES_TICKET(id_ticket,id_funcion,id_butaca,precio_venta) 
values(@id_ticket,@id_funcion,@id_butaca,@precio_venta);
end;

Create procedure SP_CONSULTAR_FUNCIONES
as
begin
select * from FUNCIONES where estado = 1
end;

create proc SP_BAJA_FUNCION
@id_funcion int 
as
begin
update funciones set estado = 0
where id_funcion = @id_funcion
end;

create proc SP_UPDATE_FUNCION
@id_funcion int,
@id_sala int,
@id_pelicula int,
@precio money,
@fecha_desde datetime,
@fecha_hasta datetime,
@horarios varchar(200)
as
begin
update funciones set id_sala = @id_sala, id_pelicula = @id_pelicula, precio = @precio, fecha_desde = @fecha_desde, fecha_hasta = fecha_hasta, Horario = @horarios
where id_funcion = @id_funcion
end;

create proc SP_BAJA_TICKET
@id_ticket int
as
begin
update TICKETS set estado = 0 where id_ticket = @id_ticket
end;

create proc SP_COMBO_FUNCIONES
as
begin
select titulo Titulo, duracion Duracion ,sinopsis Sinopsis, idioma Idioma, 
	ge.genero Genero, clasificacion Clasificacion, Horario, nro_sala Sala
from PELICULAS p join GENEROS g on p.id_genero = g.id_genero
join CLASIFICACIONES cl on cl.id_clasificacion = p.id_clasificacion
join IDIOMAS i on i.id_idioma = p.id_idioma
join GENEROS ge on ge.id_genero = p.id_genero
join FUNCIONES f on f.id_pelicula = p.id_pelicula
join SALAS s on s.id_sala = f.id_sala
end;

CREATE proc [dbo].[SP_INSERTAR_FUNCION]
@id_sala int,
@id_pelicula int,
@precio money,
@fecha_desde datetime,
@fecha_hasta datetime,
@horario datetime
as
begin
insert into funciones(id_sala, estado, id_pelicula, precio, fecha_desde, fecha_hasta, horario) 
values (@id_sala,1,@id_pelicula,@precio,@fecha_desde,@fecha_hasta,@horario)
end;

create proc SP_CONSULTAR_PELICULAS
@titulo varchar(200),
@duracion int,
@id_genero int,
@id_idioma int
as
select titulo Titulo, duracion Duracion,clasificacion Clasificacion, genero Genero, idioma Idioma 
from PELICULAS p
join GENEROS g on g.id_genero = p.id_genero
join IDIOMAS i on i.id_idioma = p.id_idioma
join CLASIFICACIONES c on c.id_clasificacion = p.id_clasificacion
where titulo = @titulo or duracion = @duracion or @id_genero = @id_genero or @id_idioma = @id_idioma


select * from PELICULAS

create proc SP_NUEVA_PELICULA
@titulo varchar(200),
@duracion int,
@sinopsis varchar(400),
@id_clasificacion int,
@id_genero int,
@id_idioma int
as
insert into PELICULAS(titulo,duracion,sinopsis,id_clasificacion,id_genero,id_idioma) values (@titulo, @duracion, @sinopsis, @id_clasificacion, @id_genero, @id_idioma)


create proc SP_MODIFICAR_PELICULA
@id_pelicula int,
@titulo varchar(200),
@duracion int,
@sinopsis varchar(400),
@id_clasificacion int,
@id_genero int,
@id_idioma int
as
update PELICULAS set titulo = @titulo, duracion = @duracion, sinopsis = @sinopsis, id_clasificacion = @id_clasificacion, id_genero = @id_genero, id_idioma = @id_idioma
where id_pelicula = @id_pelicula


