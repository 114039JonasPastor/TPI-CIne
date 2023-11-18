CREATE DATABASE CineNuevo0
GO

USE CineNuevo0
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
	estado bit

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


--OK--------------------------SP

-------------------------------------------FUNCIONES
Create procedure SP_CONSULTAR_FUNCIONES
as
begin
select * from FUNCIONES where estado = 1
end;


create procedure SP_CONSULTAR_FUNCIONES_ID
@IDFUNCION INT
AS
BEGIN
	SELECT * FROM FUNCIONES WHERE id_funcion = @IDFUNCION
END;


create proc SP_UPDATE_FUNCION
@id_funcion int,
@id_sala int,
@id_pelicula int,
@precio money,
@fecha_desde datetime,
@fecha_hasta datetime,
@horario datetime
as
begin
update funciones set id_sala = @id_sala, id_pelicula = @id_pelicula, precio = @precio, fecha_desde = @fecha_desde, fecha_hasta = fecha_hasta, Horario = @horario
where id_funcion = @id_funcion
end;


create proc SP_BAJA_FUNCION
@id_funcion int 
as
begin
update funciones set estado = 0
where id_funcion = @id_funcion
end;



CREATE proc [dbo].[SP_INSERTAR_FUNCION]
@id_sala int,
@id_pelicula int,
@precio money,
@fecha_desde datetime,
@fecha_hasta datetime,
@horario datetime,
@id_formato int
as
begin
insert into funciones(id_sala, estado, id_pelicula, precio, fecha_desde, fecha_hasta, horario, id_formato) 
values (@id_sala,1,@id_pelicula,@precio,@fecha_desde,@fecha_hasta,@horario, @id_formato)
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


-------------------------------------------TICKET
create proc SP_BAJA_TICKET
@id_ticket int
as
begin
update TICKETS set estado = 0 where id_ticket = @id_ticket
end;



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




----------------------------------------------------PELICULAS

create proc [dbo].[SP_CONSULTAR_PELICULAS_SIN_FILTRO]
as
select titulo Titulo, duracion Duracion,clasificacion Clasificacion, genero Genero, idioma Idioma, estado Estado 
from PELICULAS p
join GENEROS g on g.id_genero = p.id_genero
join IDIOMAS i on i.id_idioma = p.id_idioma
join CLASIFICACIONES c on c.id_clasificacion = p.id_clasificacion

--mejorar
create proc [dbo].[SP_CONSULTAR_PELICULAS]
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
where titulo like '%'+ @titulo +'%'
or duracion = @duracion
or p.id_genero = @id_genero
or p.id_idioma = @id_idioma


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


create proc SP_CONSULTAR_PELICULAS_SIN_FILTRO
as
select titulo Titulo, duracion Duracion,clasificacion Clasificacion, genero Genero, idioma Idioma 
from PELICULAS p
join GENEROS g on g.id_genero = p.id_genero
join IDIOMAS i on i.id_idioma = p.id_idioma
join CLASIFICACIONES c on c.id_clasificacion = p.id_clasificacion



alter proc SP_NUEVA_PELICULA
@titulo varchar(200),
@duracion int,
@sinopsis varchar(400),
@id_clasificacion int,
@id_genero int,
@id_idioma int
as
insert into PELICULAS(titulo,duracion,sinopsis,id_clasificacion,id_genero,id_idioma, estado) 
values (@titulo, @duracion, @sinopsis, @id_clasificacion, @id_genero, @id_idioma,1)


create proc SP_BAJA_PELICULA
@id_pelicula int 
as
begin
update PELICULAS set estado = 0
where id_pelicula = @id_pelicula
end;


-------Para pruebas-------
/*
select * from PELICULAS
update PELICULAS set estado = 1 where estado = 0
delete from PELICULAS where id_pelicula > 5
DBCC CHECKIDENT(peliculas, NORESEED);
DBCC CHECKIDENT(peliculas, RESEED, 5);
*/



--EXTRAS
create procedure SP_CONSULTAR_CLASIFICACIONES
AS
BEGIN
	SELECT * FROM CLASIFICACIONES
END;



create procedure SP_CONSULTAR_IDIOMAS
AS
BEGIN
	SELECT * FROM IDIOMAS
END;



create procedure SP_CONSULTAR_GENEROS
AS
BEGIN
	SELECT * FROM GENEROS
END;






----------DATOS DB

INSERT INTO PROMOCIONES (fecha_desde, fecha_hasta, procentaje_descuento) VALUES ('2023-09-01', '2023-09-15', 20);
INSERT INTO PROMOCIONES (fecha_desde, fecha_hasta, procentaje_descuento) VALUES ('2023-10-01', '2023-10-31', 15);
INSERT INTO PROMOCIONES (fecha_desde, fecha_hasta, procentaje_descuento) VALUES ('2023-11-01', '2023-11-30', 10);
INSERT INTO PROMOCIONES (fecha_desde, fecha_hasta, procentaje_descuento) VALUES ('2023-12-01', '2023-12-31', 25);
INSERT INTO PROMOCIONES (fecha_desde, fecha_hasta, procentaje_descuento) VALUES ('2024-01-01', '2024-01-15', 30);
INSERT INTO CLIENTES (nombre, apellido, fecha_nac, email) VALUES ('Maria', 'González', '1990-05-15', 'maria@example.com');
INSERT INTO CLIENTES (nombre, apellido, fecha_nac, email) VALUES ('Juan', 'Pérez', '1985-12-10', 'juan@example.com');
INSERT INTO CLIENTES (nombre, apellido, fecha_nac, email) VALUES ('Luis', 'Torres', '1995-03-22', 'luis@example.com');
INSERT INTO CLIENTES (nombre, apellido, fecha_nac, email) VALUES ('Ana', 'Rodríguez', '1998-07-01', 'ana@example.com');
INSERT INTO CLIENTES (nombre, apellido, fecha_nac, email) VALUES ('Diego', 'López', '1980-09-30', 'diego@example.com');
INSERT INTO TIPOS_DOC (tipo) VALUES ('DNI');
INSERT INTO TIPOS_DOC (tipo) VALUES ('Pasaporte');
INSERT INTO TIPOS_DOC (tipo) VALUES ('Cédula de Ciudadanía');
INSERT INTO TIPOS_DOC (tipo) VALUES ('Licencia de Conducir');
INSERT INTO TIPOS_DOC (tipo) VALUES ('Tarjeta de Residencia');
INSERT INTO BARRIOS (barrio) VALUES ('Centro');
INSERT INTO BARRIOS (barrio) VALUES ('La Alameda');
INSERT INTO BARRIOS (barrio) VALUES ('El Poblado');
INSERT INTO BARRIOS (barrio) VALUES ('Los Laureles');
INSERT INTO BARRIOS (barrio) VALUES ('San Antonio');
INSERT INTO CARGOS (descripcion) VALUES ('Gerente');
INSERT INTO CARGOS (descripcion) VALUES ('Cajero');
INSERT INTO CARGOS (descripcion) VALUES ('Vendedor');
INSERT INTO CARGOS (descripcion) VALUES ('User');
INSERT INTO CARGOS (descripcion) VALUES ('Proyeccionista');
--
INSERT INTO EMPLEADOS (nombre, apellido, id_tipo_doc, documento, fecha_nac, id_barrio, id_cargo, fecha_alta, telefono, email) 
VALUES ('Luisa', 'Martínez', 1, 12345678, '1980-04-20', 1, 1, '2023-08-01', '555-1234', 'luisa@example.com');
INSERT INTO EMPLEADOS (nombre, apellido, id_tipo_doc, documento, fecha_nac, id_barrio, id_cargo, fecha_alta, telefono, email) 
VALUES ('Carlos', 'Gómez', 2, 87654321, '1982-11-15', 2, 2, '2023-08-03', '555-5678', 'carlos@example.com');
INSERT INTO EMPLEADOS (nombre, apellido, id_tipo_doc, documento, fecha_nac, id_barrio, id_cargo, fecha_alta, telefono, email) 
VALUES ('Laura', 'Fernández', 3, 11223344, '1990-09-02', 3, 3, '2023-08-10', '555-9876', 'laura@example.com');
INSERT INTO EMPLEADOS (nombre, apellido, id_tipo_doc, documento, fecha_nac, id_barrio, id_cargo, fecha_alta, telefono, email) 
VALUES ('Pedro', 'Díaz', 4, 99887766, '1985-03-11', 4, 4, '2023-08-05', '555-4321', 'pedro@example.com');
INSERT INTO EMPLEADOS (nombre, apellido, id_tipo_doc, documento, fecha_nac, id_barrio, id_cargo, fecha_alta, telefono, email) 
VALUES ('Sofía', 'López', 5, 66554433, '1994-07-25', 5, 5, '2023-08-02', '555-8765', 'sofia@example.com');
--
INSERT INTO MEDIOS_PEDIDO (descripcion) VALUES ('Web');
INSERT INTO MEDIOS_PEDIDO (descripcion) VALUES ('Teléfono');
INSERT INTO MEDIOS_PEDIDO (descripcion) VALUES ('Taquilla');
INSERT INTO MEDIOS_PEDIDO (descripcion) VALUES ('App Móvil');
INSERT INTO MEDIOS_PEDIDO (descripcion) VALUES ('Kiosco');

-- Inserts para la tabla FORMAS_PAGO
INSERT INTO FORMAS_PAGO (descripcion, porcentaje_recargo) VALUES ('Efectivo', 0);
INSERT INTO FORMAS_PAGO (descripcion, porcentaje_recargo) VALUES ('Tarjeta de Crédito', 5);
INSERT INTO FORMAS_PAGO (descripcion, porcentaje_recargo) VALUES ('Tarjeta de Débito', 3);
INSERT INTO FORMAS_PAGO (descripcion, porcentaje_recargo) VALUES ('PayPal', 7);
INSERT INTO FORMAS_PAGO (descripcion, porcentaje_recargo) VALUES ('Transferencia Bancaria', 2);

-- Inserts para la tabla TICKETS
INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion) VALUES ('2023-08-15', 1, 1, 1, 1);
INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion) VALUES ('2023-08-16', 2, 2, 2, 2);
INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion) VALUES ('2023-08-17', 3, 3, 3, 3);
INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion) VALUES ('2023-08-18', 4, 4, 4, 4);
INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion) VALUES ('2023-08-19', 5, 5, 5, 5);

-- Inserts para la tabla CLASIFICACIONES
INSERT INTO CLASIFICACIONES (clasificacion) VALUES ('Apta para todos los públicos');
INSERT INTO CLASIFICACIONES (clasificacion) VALUES ('+7');
INSERT INTO CLASIFICACIONES (clasificacion) VALUES ('+12');
INSERT INTO CLASIFICACIONES (clasificacion) VALUES ('+16');
INSERT INTO CLASIFICACIONES (clasificacion) VALUES ('+18');

-- Inserts para la tabla GENEROS
INSERT INTO GENEROS (genero) VALUES ('Acción');
INSERT INTO GENEROS (genero) VALUES ('Comedia');
INSERT INTO GENEROS (genero) VALUES ('Drama');
INSERT INTO GENEROS (genero) VALUES ('Ciencia Ficción');
INSERT INTO GENEROS (genero) VALUES ('Romance');

insert into IDIOMAS
values ('Ingles'), ('Español');

-----
INSERT INTO PELICULAS (titulo, duracion, sinopsis, id_clasificacion, id_genero, id_idioma, estado) 
VALUES ('Misión Imposible', 130, 'Un agente se embarca en misiones imposibles para salvar el mundo.', 4, 1,1,1);
INSERT INTO PELICULAS (titulo, duracion, sinopsis, id_clasificacion, id_genero, id_idioma, estado) 
VALUES ('Locuras de Verano', 100, 'Un grupo de amigos vive locuras durante las vacaciones de verano.', 2, 2,1,1);
INSERT INTO PELICULAS (titulo, duracion, sinopsis, id_clasificacion, id_genero, id_idioma, estado) 
VALUES ('Sueño Americano', 150, 'La historia de un hombre que persigue el sueño americano.', 3, 3, 1,1);
INSERT INTO PELICULAS (titulo, duracion, sinopsis, id_clasificacion, id_genero, id_idioma, estado) 
VALUES ('La Guerra de las Galaxias', 180, 'Una saga épica de ciencia ficción.', 4, 4,2,1);
INSERT INTO PELICULAS (titulo, duracion, sinopsis, id_clasificacion, id_genero, id_idioma, estado) 
VALUES ('Amor Eterno', 120, 'Una historia de amor que trasciende el tiempo.', 5, 5, 2,1);

-- Inserts para la tabla TIPOS_SALAS
INSERT INTO TIPOS_SALAS (tipo) VALUES ('Sala 2D');
INSERT INTO TIPOS_SALAS (tipo) VALUES ('Sala 3D');
INSERT INTO TIPOS_SALAS (tipo) VALUES ('Sala IMAX');
INSERT INTO TIPOS_SALAS (tipo) VALUES ('Sala VIP');
INSERT INTO TIPOS_SALAS (tipo) VALUES ('Sala 4D');

-- Inserts para la tabla SALAS
INSERT INTO SALAS (nro_sala, id_tipo_sala) VALUES (1, 1);
INSERT INTO SALAS (nro_sala, id_tipo_sala) VALUES (2, 2);
INSERT INTO SALAS (nro_sala, id_tipo_sala) VALUES (3, 3);
INSERT INTO SALAS (nro_sala, id_tipo_sala) VALUES (4, 4);
INSERT INTO SALAS (nro_sala, id_tipo_sala) VALUES (5, 5);

INSERT INTO BUTACAS(numero) 
VALUES
(1),
(2),
(3),
(4),
(5),
(6),
(7),
(8)
-------
select * from FORMATOS
INSERT INTO FORMATOS (formato) VALUES ('2D');
INSERT INTO FORMATOS (formato) VALUES ('3D');
INSERT INTO FORMATOS (formato) VALUES ('IMAX');
INSERT INTO FORMATOS (formato) VALUES ('Dolby Atmos');
INSERT INTO FORMATOS (formato) VALUES ('ScreenX');

INSERT INTO FUNCIONES (id_sala, horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta)
VALUES
(2, '2022-01-15 15:30:00', 1, 1, 3, 12.50, '2022-01-01', '2022-02-01'),
(2, '2022-02-20 18:45:00', 2, 0, 1, 15.75, '2022-02-01', '2022-03-01'),
(3, '2022-03-10 20:15:00', 3, 1, 1, 20.00, '2022-03-01', '2022-04-01'),
(4, '2022-04-05 14:00:00', 4, 0, 2, 18.25, '2022-04-01', '2022-05-01'),
(5, '2022-05-22 17:30:00', 5, 1, 3, 25.50, '2022-05-01', '2022-06-01'),
(1, '2022-06-12 19:45:00', 1, 0, 3, 30.75, '2022-06-01', '2022-07-01'),
(2, '2022-07-08 21:00:00', 2, 1, 4, 35.00, '2022-07-01', '2022-08-01'),
(3, '2022-08-18 16:15:00', 3, 0, 4, 40.25, '2022-08-01', '2022-09-01'),
(4, '2022-09-25 12:30:00', 4, 1, 5, 45.50, '2022-09-01', '2022-10-01'),
(5, '2022-10-30 14:45:00', 5, 0, 1, 50.75, '2022-10-01', '2022-11-01'),
(3, '2022-11-15 18:00:00', 1, 1, 2, 55.00, '2022-11-01', '2022-12-01'),
(2, '2023-01-03 20:30:00', 2, 0, 2, 60.25, '2023-01-01', '2023-02-01'),
(3, '2023-02-12 15:45:00', 3, 1, 3, 65.50, '2023-02-01', '2023-03-01'),
(4, '2023-03-08 17:15:00', 4, 0, 3, 70.75, '2023-03-01', '2023-04-01'),
(1, '2023-04-20 19:30:00', 5, 1, 4, 75.00, '2023-04-01', '2023-05-01'),
(1, '2023-05-28 12:45:00', 1, 0, 4, 80.25, '2023-05-01', '2023-06-01'),
(2, '2023-06-17 14:00:00', 2, 1, 5, 85.50, '2023-06-01', '2023-07-01'),
(3, '2023-07-22 16:30:00', 3, 0, 1, 90.75, '2023-07-01', '2023-08-01'),
(4, '2023-08-10 18:45:00', 4, 1, 2, 95.00, '2023-08-01', '2023-09-01'),
(5, '2023-09-05 21:00:00', 5, 0, 5, 100.25, '2023-09-01', '2023-10-01');
---
-- INSERTAR 20 DATOS EN LA TABLA TICKETS
INSERT INTO TICKETS (fecha, id_cliente, id_empleado, id_medio_pedido, id_promocion, id_forma_pago, total)
VALUES
('2023-11-01', 1, 1, 1, 1, 1, 50),
('2023-11-02', 2, 2, 2, 2, 2, 75.00),
('2023-11-03', 3, 3, 1, 1, 3, 60.00),
('2023-11-04', 4, 4, 2, 2, 1, 45.00),
('2023-11-05', 5, 5, 1, 2, 2, 80.00),
('2023-11-06', 1, 1, 2, 1, 3, 55.00),
('2023-11-07', 2, 2, 1, 2, 1, 70.00),
('2023-11-08', 3, 3, 2, 1, 2, 65.00),
('2023-11-09', 4, 4, 1, 2, 3, 40.00),
('2023-11-10', 5, 5, 2, 1, 1, 85.00),
('2023-11-11', 1, 1, 1, 2, 2, 90.00),
('2023-11-12', 2, 2, 2, 1, 3, 55.00),
('2023-11-13', 3, 3, 1, 2, 1, 70.00),
('2023-11-14', 4, 4, 2, 1, 2, 65.00),
('2023-11-15', 5, 5, 1, 2, 3, 40.00),
('2023-11-16', 1, 1, 2, 1, 1, 85.00),
('2023-11-17', 2, 2, 1, 2, 2, 90.00),
('2023-11-18', 3, 3, 2, 1, 3, 55.00),
('2023-11-19', 4, 4, 1, 2, 1, 70.00),
('2023-11-20', 5, 5, 2, 1, 2, 65.00);

-- INSERTAR 20 DETALLES DE TICKETS
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta)
VALUES
(1, 4, 2, 20.00),
(2, 5, 3, 25.00),
(3, 3, 4, 18.00),
(4, 4, 5, 22.00),
(5, 5, 6, 30.00),
(6, 6, 7, 12.00),
(7, 7, 8, 28.00),
(8, 3, 1, 24.00),
(9, 4, 2, 19.00),
(10, 5, 3, 16.00),
(11, 8, 4, 23.00),
(12, 9, 5, 26.00),
(13, 3, 6, 14.00),
(14, 4, 7, 17.00),
(15, 5, 8, 21.00),
(16, 10, 1, 27.00),
(17, 20, 2, 13.00),
(18, 3, 3, 29.00),
(19, 4, 4, 31.00),
(24, 11, 3, 29.00),
(25, 19, 4, 31.00);

-- Detalles para tickets del 1 al 10
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (1, 3, 1, 15.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (2, 4, 2, 12.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (3, 5, 3, 18.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (4, 6, 4, 14.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (5, 7, 5, 16.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (6, 8, 6, 20.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (7, 9, 7, 22.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (8, 10, 8, 19.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (9, 11, 1, 25.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (10, 12, 2, 29.99);

-- Detalles para tickets del 11 al 20
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (11, 13, 3, 32.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (12, 14, 4, 28.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (13, 15, 5, 30.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (14, 16, 6, 26.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (15, 17, 7, 24.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (16, 18, 8, 35.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (17, 19, 1, 38.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (18, 20, 2, 40.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (19, 21, 3, 42.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (20, 22, 4, 45.99);

-- Detalles para tickets del 21 al 30
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (21, 3, 5, 48.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (22, 4, 6, 50.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (23, 5, 7, 55.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (24, 6, 8, 58.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (25, 7, 1, 60.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (1, 8, 2, 62.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (2, 9, 3, 65.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (3, 7, 4, 70.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (4, 3, 5, 75.99);
INSERT INTO DETALLES_TICKET (id_ticket, id_funcion, id_butaca, precio_venta) VALUES (5, 4, 6, 80.99);


exec sp_insertar_funcion 1,2,223,'2023/11/10', '2023/11/12','2023/11/11',1

select * from SALAS
select * from FUNCIONES
select * from PELICULAS
update FUNCIONES set id_formato = 1 where id_funcion = 46

DBCC CHECKIDENT(funciones, NORESEED);
DBCC CHECKIDENT(funciones, RESEED, 21);

SELECT * FROM SALAS WHERE id_sala = 4;
