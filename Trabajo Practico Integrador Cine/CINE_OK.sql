
CREATE DATABASE CineOK
go
USE CineOK
go


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


CREATE TABLE TICKETS
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

create table IDIOMAS
(
id_idioma int identity(1,1),
idioma varchar(200)
constraint pk_idioma primary key(id_idioma)
)

CREATE TABLE PELICULAS
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

CREATE TABLE HORARIOS
(
	id_horario int identity(1,1),
	horario datetime

	CONSTRAINT PK_HORARIOS PRIMARY KEY (id_horario)
);

create table FORMATOS
(
	id_formato int identity(1,1),
	formato varchar(200)
	
	constraint pk_formato primary key(id_formato)
)


CREATE TABLE FUNCIONES
(
	id_funcion int identity(1,1),
	id_sala int,
	id_horario int,
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
	
	CONSTRAINT FK_FUNCIONES_HORARIOS FOREIGN KEY (id_horario)
		REFERENCES HORARIOS(id_horario),

	CONSTRAINT FK_FUNCIONES_PELICULAS FOREIGN KEY (id_pelicula)
		REFERENCES PELICULAS(id_pelicula)
);


CREATE TABLE BUTACAS
(
	id_butaca int identity(1,1),
	numero varchar(4),
	CONSTRAINT PK_BUTACAS PRIMARY KEY (id_butaca),
);

CREATE TABLE DETALLES_TICKET
(
	id_detalle int,
	id_ticket int,
	id_funcion int,
	id_butaca int,
	precio_venta decimal,

	CONSTRAINT PK_DETALLES_TICKET PRIMARY KEY (id_detalle, id_ticket),

	--CONSTRAINT FK_DETALLES_TICKET_TICKETS FOREIGN KEY (id_ticket)
	--	REFERENCES TICKETS(id_ticket),

	constraint fk_butacas foreign key(id_butaca)
		references butacas(id_butaca),

	CONSTRAINT FK_DETALLES_TICKET_FUNCIONES FOREIGN KEY (id_funcion)
		REFERENCES FUNCIONES(id_funcion)
);


create table RESERVADAS
(
id_reserva int identity(1,1),
id_butaca int,
id_funcion int,

constraint pk_Reservadas primary key (id_reserva),
constraint fk_butaca foreign key(id_butaca)
	references butacas(id_butaca),
constraint fk_funcion foreign key (id_funcion)
	references funciones(id_funcion)
);


go

--OK--------------------------SP



--EXTRAS
create procedure SP_CONSULTAR_CLASIFICACIONES
AS
BEGIN
	SELECT * FROM CLASIFICACIONES
END;
GO

create procedure SP_CONSULTAR_IDIOMAS
AS
BEGIN
	SELECT * FROM IDIOMAS
END;
GO


create procedure SP_CONSULTAR_GENEROS
AS
BEGIN
	SELECT * FROM GENEROS
END;
GO


----------------------------------------------------PELICULAS

CREATE PROCEDURE SP_CONSULTAR_PELICULAS_DTO
AS
BEGIN
	select id_pelicula ID, titulo Titulo, duracion Duracion, 
	clasificacion Clasificacion, genero Genero, idioma Idioma, estado Estado
from PELICULAS p
join GENEROS g on g.id_genero = p.id_genero
join IDIOMAS i on i.id_idioma = p.id_idioma
join CLASIFICACIONES c on c.id_clasificacion = p.id_clasificacion
order by titulo
END;
GO

create proc [dbo].[SP_CONSULTAR_PELICULAS_SIN_FILTRO]
as
begin
select P.*, titulo Titulo, sinopsis Sinopsis,clasificacion Clasificacion, genero Genero, idioma Idioma 
from PELICULAS p
join GENEROS g on g.id_genero = p.id_genero
join IDIOMAS i on i.id_idioma = p.id_idioma
join CLASIFICACIONES c on c.id_clasificacion = p.id_clasificacion
WHERE estado = 1
end;
GO

create proc [dbo].[SP_CONSULTAR_PELICULAS]
@titulo varchar(200),
@sinopsis varchar(200),
@id_genero int,
@id_idioma int
as
begin
select P.*, titulo Titulo, sinopsis Sinopsis,clasificacion Clasificacion, genero Genero, idioma Idioma 
from PELICULAS p
join GENEROS g on g.id_genero = p.id_genero
join IDIOMAS i on i.id_idioma = p.id_idioma
join CLASIFICACIONES c on c.id_clasificacion = p.id_clasificacion
where estado = 1
AND (titulo like '%'+ @titulo +'%' OR @titulo IS NULL)
AND (sinopsis like '%'+ @sinopsis +'%' OR @sinopsis IS NULL)
AND (p.id_genero = @id_genero OR @id_genero IS NULL)
AND (p.id_idioma = @id_idioma OR @id_idioma IS NULL)
end;
GO

create procedure SP_CONSULTAR_PELICULA_ID
@id_pelicula int
as
begin
select P.*, titulo Titulo, sinopsis Sinopsis,clasificacion Clasificacion, genero Genero, idioma Idioma 
from PELICULAS p
join GENEROS g on g.id_genero = p.id_genero
join IDIOMAS i on i.id_idioma = p.id_idioma
join CLASIFICACIONES c on c.id_clasificacion = p.id_clasificacion
where id_pelicula = @id_pelicula
end;
GO


create proc SP_MODIFICAR_PELICULA
@id_pelicula int,
@titulo varchar(200),
@duracion int,
@sinopsis varchar(400),
@id_clasificacion int,
@id_genero int,
@id_idioma int
as
begin
update PELICULAS set titulo = @titulo, duracion = @duracion, sinopsis = @sinopsis, id_clasificacion = @id_clasificacion, id_genero = @id_genero, id_idioma = @id_idioma
where id_pelicula = @id_pelicula
end;
GO


create proc SP_NUEVA_PELICULA
@titulo varchar(200),
@duracion int,
@sinopsis varchar(400),
@id_clasificacion int,
@id_genero int,
@id_idioma int
as
begin
insert into PELICULAS(titulo,duracion,sinopsis,id_clasificacion,id_genero,id_idioma, estado) 
values (@titulo, @duracion, @sinopsis, @id_clasificacion, @id_genero, @id_idioma,1)
end;
GO

create proc SP_BAJA_PELICULA
@id_pelicula int 
as
begin
update PELICULAS set estado = 0
where id_pelicula = @id_pelicula
end;
GO



-------------------------------------------FUNCIONES
create procedure SP_CONSULTAR_FUNCIONES
as
begin
select * from FUNCIONES where estado = 1 order by id_funcion desc
end;
GO


create procedure SP_CONSULTAR_FUNCIONES_ID
@IDFUNCION INT
AS
BEGIN
	SELECT * FROM FUNCIONES WHERE id_funcion = @IDFUNCION
END;
GO


create proc SP_UPDATE_FUNCION
@id_funcion int,
@id_sala int,
@id_pelicula int,
@precio money,
@fecha_desde datetime,
@fecha_hasta datetime,
@id_horario int
as
begin
update funciones set id_sala = @id_sala, id_pelicula = @id_pelicula, precio = @precio, fecha_desde = @fecha_desde, fecha_hasta = fecha_hasta, id_horario = @id_horario
where id_funcion = @id_funcion
end;
GO


create proc SP_BAJA_FUNCION
@id_funcion int 
as
begin
update funciones set estado = 0
where id_funcion = @id_funcion
end;
GO






-------------------------------------------TICKET

create PROCEDURE SP_CONSULTAR_TICKETS
	@fecha_desde Datetime,
	@fecha_hasta Datetime,
	@cliente varchar(50),
	@empleado varchar(50),
	@pelicula varchar(50)
AS
BEGIN
	SELECT t.id_ticket, c.nombre +' '+ c.apellido 'Nombre cliente',
			e.nombre +' '+ e.apellido 'Nombre empleado', p.titulo, t.total, t.fecha
	FROM TICKETS T
	join CLIENTES C on T.id_cliente = c.id_cliente
	join EMPLEADOS E on e.id_empleado = t.id_empleado
	join DETALLES_TICKET dt on dt.id_ticket = t.id_ticket
	join FUNCIONES f on f.id_funcion = dt.id_funcion
	join PELICULAS p on p.id_pelicula = f.id_pelicula
	WHERE (@fecha_desde is null OR fecha >= @fecha_desde)
	AND (@fecha_hasta is null OR fecha <= @fecha_hasta)
	AND (@cliente is null OR c.nombre + c.apellido LIKE '%' + @cliente + '%')
	AND (@empleado is null OR e.nombre + e.apellido LIKE '%' + @empleado + '%')
	AND (@pelicula is null or p.titulo LIKE '%' + @pelicula + '%' );
END;
GO


create PROCEDURE SP_CONSULTAR_DETALLE_TICKET
	@id_ticket int
AS
BEGIN
	SELECT D.*, B.*, fo.formato, s.*, p.titulo, t.total, t.fecha, p.id_pelicula,
			cl.nombre +' '+ cl.apellido 'cliente', H.*, C.*, i.*, g.*
	FROM DETALLES_TICKET D
	JOIN BUTACAS B ON B.id_butaca = D.id_butaca
	JOIN FUNCIONES F ON F.id_funcion = D.id_funcion
	JOIN HORARIOS H ON H.id_horario = F.id_horario
	JOIN FORMATOS FO ON FO.id_formato = f.id_formato
	join SALAS S ON S.id_sala = F.id_sala
	JOIN PELICULAS P ON P.id_pelicula = F.id_pelicula
	JOIN CLASIFICACIONES C ON C.id_clasificacion = P.id_clasificacion
	JOIN IDIOMAS I ON I.id_idioma = P.id_idioma
	JOIN GENEROS G ON G.id_genero = P.id_genero
	JOIN TICKETS T ON T.id_ticket = d.id_ticket
	join CLIENTES CL on T.id_cliente = cl.id_cliente
	AND T.id_ticket = @id_ticket
END;
GO

create proc SP_BAJA_TICKET
@id_ticket int
as
begin
update TICKETS set estado = 0 where id_ticket = @id_ticket
end;
GO



create procedure SP_INSERTAR_DETALLE
@id_detalle int,
@id_ticket int,
@id_funcion int,
@id_butaca int,
@precio_venta money
as
begin
insert into DETALLES_TICKET(id_detalle, id_ticket,id_funcion,id_butaca,precio_venta) 
values(@id_detalle, @id_ticket,@id_funcion,@id_butaca,@precio_venta);
end;
GO
-----------------------------


create proc SP_CONSULTAR_SALAS
as
BEGIN
select * from SALAS
END;
GO

create proc SP_CONSULTAR_HORARIOS
as
BEGIN
select * from HORARIOS
END;
GO


CREATE proc [dbo].[SP_INSERTAR_FUNCION]
@id_sala int,
@id_pelicula int,
@precio money,
@fecha_desde datetime,
@fecha_hasta datetime,
@id_horario int
as
begin
insert into funciones(id_sala, estado, id_pelicula, precio, fecha_desde, fecha_hasta, id_horario, id_formato) 
values (@id_sala,1,@id_pelicula,@precio,@fecha_desde,@fecha_hasta,@id_horario, 3)
end;
GO



create proc SP_CONSULTAR_CLIENTES
as
BEGIN
select id_cliente ID, nombre+' '+apellido Nombre from CLIENTES
END;
GO


CREATE proc SP_GET_TICKETS_FILTROS
@id int,
@fecha datetime,
@cliente varchar(200)
as
BEGIN
select id_ticket 'Numero de ticket', nombre+' '+apellido Cliente, fecha Fecha from TICKETS t
join clientes c on c.id_cliente = t.id_cliente
where (id_ticket = @id or fecha = @fecha or nombre+' '+apellido = @cliente) and estado = 1
END;
GO

CREATE proc [dbo].[SP_CONSULTAR_FUNCIONES_FILTROS]
@id_funcion int,
@desde datetime,
@hasta datetime
as
BEGIN
select f.id_funcion 'Numero de funcion',titulo Pelicula, nro_sala Sala,tipo 'Tipo de sala',horario Horario, fecha_desde 'Fecha desde', fecha_hasta 'Fecha hasta', precio Precio
from FUNCIONES f join PELICULAS p on p.id_pelicula = f.id_pelicula
join SALAS s on s.id_sala = f.id_sala
join Horarios h on h.id_horario = f.id_horario
join TIPOS_SALAS ts on ts.id_tipo_sala = s.id_tipo_sala
where (f.id_funcion = @id_funcion or (fecha_desde >= @desde and fecha_hasta <= @hasta)) and f.estado = 1
END;
GO


create proc SP_CONSULTAR_PROMOCIONES
as
BEGIN
select id_promocion, procentaje_descuento from PROMOCIONES
END;
GO

create proc SP_CONSUTAR_FORMAS_PAGO
AS
BEGIN
SELECT * FROM FORMAS_PAGO
END;
GO

create proc SP_CONSULTAR_MEDIOS_PEDIDOS
as
BEGIN
select * from MEDIOS_PEDIDO
END;
GO

create proc SP_CONSULTAR_BUTACAS
as
BEGIN
select * from BUTACAS
END;
GO


CREATE proc [dbo].[SP_INSERTAR_TICKET]
@nuevo_id_ticket int output,
@fecha datetime,
@id_cliente int,
@id_medio_pedido int,
@id_promocion int,
@total money,
@id_forma_pago int
as
begin
insert into TICKETS(fecha,id_cliente, id_medio_pedido,id_promocion,total,estado, id_forma_pago) 
values (@fecha,@id_cliente, @id_medio_pedido,@id_promocion,@total,1,@id_forma_pago);
	set @nuevo_id_ticket = SCOPE_IDENTITY()
end;
GO


create PROCEDURE [dbo].[SP_PROXIMO_ID]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(id_ticket)+1  FROM TICKETS);
END;
go



-------Para pruebas-------

--select * from PELICULAS
--update PELICULAS set duracion = 120 where sinopsis = 'Sinopsis...'
--delete from PELICULAS where id_pelicula > 5
--DBCC CHECKIDENT(peliculas, NORESEED);
--DBCC CHECKIDENT(peliculas, RESEED, 5);


----------DATOS DB

USE CineOK
GO

INSERT INTO PROMOCIONES VALUES ('2023-09-01', '2023-09-15', 20);
INSERT INTO PROMOCIONES VALUES ('2023-10-01', '2023-10-31', 15);
INSERT INTO PROMOCIONES VALUES ('2023-11-01', '2023-11-30', 10);
INSERT INTO PROMOCIONES VALUES ('2023-12-01', '2023-12-31', 25);
INSERT INTO PROMOCIONES VALUES ('2024-01-01', '2024-01-15', 30);

INSERT INTO CLIENTES (nombre, apellido, fecha_nac, email) VALUES 
('Maria', 'González', '1990-05-15', 'maria@example.com'),
 ('Juan', 'Pérez', '1985-12-10', 'juan@example.com'),
 ('Luis', 'Torres', '1995-03-22', 'luis@example.com'),
 ('Ana', 'Rodríguez', '1998-07-01', 'ana@example.com'),
 ('Diego', 'López', '1980-09-30', 'diego@example.com'),
('Juan', 'Gomez', '1990-05-15', 'juan.gomez@example.com'),
('Ana', 'Lopez', '1985-08-23', 'ana.lopez@example.com'),
('Carlos', 'Rodriguez', '1992-02-10', 'carlos.rodriguez@example.com'),
('Maria', 'Martinez', '1988-11-30', 'maria.martinez@example.com'),
('Pablo', 'Fernandez', '1995-07-18', 'pablo.fernandez@example.com'),
('Laura', 'Garcia', '1993-04-05', 'laura.garcia@example.com'),
('Diego', 'Sanchez', '1987-09-12', 'diego.sanchez@example.com'),
('Sofia', 'Diaz', '1991-01-28', 'sofia.diaz@example.com'),
('Alejandro', 'Perez', '1986-06-20', 'alejandro.perez@example.com'),
('Elena', 'Torres', '1994-03-08', 'elena.torres@example.com'),
('Victor', 'Ruiz', '1989-12-14', 'victor.ruiz@example.com'),
('Carmen', 'Navarro', '1996-10-02', 'carmen.navarro@example.com'),
('Javier', 'Jimenez', '1984-07-25', 'javier.jimenez@example.com'),
('Isabel', 'Luna', '1997-04-17', 'isabel.luna@example.com'),
('Adrian', 'Hernandez', '1998-09-05', 'adrian.hernandez@example.com'),
('Lucia', 'Gutierrez', '1983-11-11', 'lucia.gutierrez@example.com'),
('Marcos', 'Molina', '1999-06-28', 'marcos.molina@example.com'),
('Natalia', 'Castro', '1982-08-03', 'natalia.castro@example.com'),
('Hugo', 'Vargas', '2000-01-20', 'hugo.vargas@example.com'),
('Clara', 'Romero', '1981-12-09', 'clara.romero@example.com'),
('Pedro', 'Alvarez', '2001-03-15', 'pedro.alvarez@example.com'),
('Luisa', 'Serrano', '1980-04-22', 'luisa.serrano@example.com'),
('Roberto', 'Ortega', '2002-07-10', 'roberto.ortega@example.com'),
('Ana Maria', 'Flores', '1979-09-18', 'ana.flores@example.com');

INSERT INTO TIPOS_DOC (tipo) VALUES ('DNI');
INSERT INTO TIPOS_DOC (tipo) VALUES ('Pasaporte');
INSERT INTO TIPOS_DOC (tipo) VALUES ('Cédula de Ciudadanía');
INSERT INTO TIPOS_DOC (tipo) VALUES ('Licencia de Conducir');
INSERT INTO TIPOS_DOC (tipo) VALUES ('Tarjeta de Residencia');

INSERT INTO BARRIOS (barrio) VALUES ('Centro');
INSERT INTO BARRIOS (barrio) VALUES ('Nueva Córdoba');
INSERT INTO BARRIOS (barrio) VALUES ('Güemes');
INSERT INTO BARRIOS (barrio) VALUES ('Alta Córdoba');
INSERT INTO BARRIOS (barrio) VALUES ('Chateu');

INSERT INTO CARGOS (descripcion) VALUES ('Gerente');
INSERT INTO CARGOS (descripcion) VALUES ('Cajero');
INSERT INTO CARGOS (descripcion) VALUES ('Vendedor');
INSERT INTO CARGOS (descripcion) VALUES ('User');
INSERT INTO CARGOS (descripcion) VALUES ('Proyeccionista');
--
INSERT INTO EMPLEADOS (nombre, apellido, id_tipo_doc, documento, fecha_nac, id_barrio, id_cargo, fecha_alta, telefono, email) 
VALUES ('María', 'Martínez', 1, 12345678, '1980-04-20', 1, 1, '2021-02-01', '555-1234', 'maria@gmail.com');
INSERT INTO EMPLEADOS (nombre, apellido, id_tipo_doc, documento, fecha_nac, id_barrio, id_cargo, fecha_alta, telefono, email) 
VALUES ('Martín', 'Polliotto', 2, 87654321, '1982-04-17', 2, 2, '2021-06-03', '555-5678', 'martin@polliotto.com');
INSERT INTO EMPLEADOS (nombre, apellido, id_tipo_doc, documento, fecha_nac, id_barrio, id_cargo, fecha_alta, telefono, email) 
VALUES ('David', 'Alonso', 3, 11223344, '1990-09-02', 3, 3, '2021-08-10', '555-9876', 'fargan@gmail.com');
INSERT INTO EMPLEADOS (nombre, apellido, id_tipo_doc, documento, fecha_nac, id_barrio, id_cargo, fecha_alta, telefono, email) 
VALUES ('Guillermo', 'Díaz', 4, 99887766, '1985-03-11', 4, 4, '2021-08-05', '555-4321', 'willy@gmail.com');
INSERT INTO EMPLEADOS (nombre, apellido, id_tipo_doc, documento, fecha_nac, id_barrio, id_cargo, fecha_alta, telefono, email) 
VALUES ('Sofía', 'Hernández', 5, 66554433, '1994-07-25', 5, 5, '2021-08-02', '555-8765', 'sofia@hotmail.com');
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
('1A'),
('1B'),
('1C'),
('2A'),
('2B'),
('2C'),
('3A'),
('3B');

INSERT INTO FORMATOS (formato) VALUES ('2D');
INSERT INTO FORMATOS (formato) VALUES ('3D');
INSERT INTO FORMATOS (formato) VALUES ('IMAX');
INSERT INTO FORMATOS (formato) VALUES ('Dolby Atmos');
INSERT INTO FORMATOS (formato) VALUES ('ScreenX');

INSERT INTO HORARIOS(horario)
VALUES ('10:00'),
('12:00'),
('12:30'),
('14:00'),
('15:30'),
('16:00'),
('17:00'),
('18:30'),
('20:30');

INSERT INTO PELICULAS (titulo, duracion, sinopsis, id_clasificacion, id_genero, id_idioma, estado)
VALUES ('Aventuras Explosivas', 120, 'Una película llena de acción y emoción.', 1, 1, 1, 1),
	   ('Misión Imposible', 130, 'Un agente se embarca en misiones imposibles para salvar el mundo.', 2, 1, 2,1),
       ('Misión Imposible: Protocolo Fantasma', 135, 'Ethan Hunt enfrenta una nueva misión imposible.', 2, 1, 2, 1),
       ('El Último Guerrero', 110, 'Un guerrero lucha contra fuerzas oscuras para salvar el reino.', 3, 1, 1, 1),
       ('Intrépidos', 105, 'Un grupo de héroes se une para salvar el mundo.', 4, 1, 2, 1),
       ('El Renacer del Dragón', 125, 'Un maestro de las artes marciales busca venganza.', 5, 1, 1, 1);

INSERT INTO PELICULAS (titulo, duracion, sinopsis, id_clasificacion, id_genero, id_idioma, estado)
VALUES ('Risas y Más Risas', 95, 'Una comedia que te hará reír a carcajadas.', 1, 2, 2, 1),
       ('Locuras en la Ciudad', 110, 'Un grupo de amigos vive situaciones cómicas en la gran ciudad.', 2, 2, 1, 1),
       ('La Boda del Año', 120, 'Preparativos para una boda que se convierten en un caos divertido.', 3, 2, 2, 1),
       ('¡Qué Desastre!', 100, 'Un día en la vida de un personaje desafortunado.', 4, 2, 1, 1),
       ('Comedia Romántica', 115, 'Amor y risas se entrelazan en esta comedia romántica.', 5, 2, 2, 1),
	   ('Locuras de Verano', 100, 'Un grupo de amigos vive locuras durante las vacaciones de verano.', 2, 2,1,1)

INSERT INTO PELICULAS (titulo, duracion, sinopsis, id_clasificacion, id_genero, id_idioma, estado)
VALUES ('El Peso del Pasado', 130, 'Un drama profundo sobre la redención.', 1, 3, 1, 1),
       ('Secretos Familiares', 115, 'Una familia enfrenta sus secretos más oscuros.', 2, 3, 2, 1),
       ('Vidas Entrelazadas', 140, 'Historias de diferentes personas que se cruzan en el destino.', 3, 3, 1, 1),
       ('El Último Adiós', 105, 'Una emotiva historia de despedida y aceptación.', 4, 3, 2, 1),
       ('Más Allá de la Esperanza', 125, 'Una mirada esperanzadora en medio de la adversidad.', 5, 3, 1, 1),
	   ('Sueño Americano', 150, 'La historia de un hombre que persigue el sueño americano.', 3, 3, 1,1)

INSERT INTO PELICULAS (titulo, duracion, sinopsis, id_clasificacion, id_genero, id_idioma, estado)
VALUES ('El Futuro Desconocido', 110, 'Explorando mundos futuros y tecnologías asombrosas.', 1, 4, 2, 1),
       ('Invasión Extraterrestre', 125, 'La humanidad lucha contra una invasión alienígena.', 2, 4, 1, 1),
       ('Viaje a las Estrellas', 140, 'Exploración intergaláctica en busca de nuevos horizontes.', 3, 4, 2, 1),
       ('Realidad Virtual', 105, 'Aventuras en un mundo virtual lleno de sorpresas.', 4, 4, 1, 1),
       ('Máquinas Conscientes', 120, 'Inteligencia artificial y su impacto en la sociedad.', 5, 4, 2, 1),
	   ('La Guerra de las Galaxias', 180, 'Una saga épica de ciencia ficción.', 4, 4,2,1)

INSERT INTO PELICULAS (titulo, duracion, sinopsis, id_clasificacion, id_genero, id_idioma, estado)
VALUES ('Amor Eterno', 115, 'Una historia de amor que trasciende el tiempo.', 1, 5, 1, 1),
       ('Enamorados en París', 130, 'Romance florece en las calles de la Ciudad del Amor.', 2, 5, 2, 1),
       ('Cita a Ciegas', 100, 'Dos almas perdidas se encuentran en una cita inesperada.', 3, 5, 1, 1),
       ('Historia de Amor Prohibido', 145, 'Amor que desafía barreras sociales y culturales.', 4, 5, 2, 1),
       ('El Último Baile', 110, 'Una historia de amor durante una noche mágica.', 5, 5, 1, 1);



-- Inserts para la tabla FUNCIONES en el rango de fechas de los tickets del año 2021
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (2, 4, 3, 1, 1, 150, '2021-01-01', '2021-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (3, 2, 5, 1, 2, 120, '2021-01-01', '2021-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (1, 6, 2, 1, 5, 180, '2021-01-01', '2021-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (4, 1, 4, 1, 6, 200, '2021-01-01', '2021-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (5, 9, 1, 1, 9, 130, '2021-01-01', '2021-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (3, 3, 3, 1, 14, 220, '2021-01-01', '2021-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (2, 7, 5, 1, 23, 160, '2021-01-01', '2021-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (5, 5, 2, 1, 7, 140, '2021-01-01', '2021-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (1, 8, 4, 1, 27, 250, '2021-01-01', '2021-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (4, 1, 1, 1, 28, 170, '2021-01-01', '2021-12-31');


-- Inserts para la tabla FUNCIONES en el rango de fechas del año 2022
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (2, 4, 3, 1, 3, 150, '2022-01-01', '2022-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (3, 2, 5, 1, 21, 120, '2022-01-01', '2022-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (1, 6, 2, 1, 24, 180, '2022-01-01', '2022-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (4, 1, 4, 1, 10, 200, '2022-01-01', '2022-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (5, 9, 1, 1, 27, 130, '2022-01-01', '2022-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (3, 3, 3, 1, 12, 220, '2022-01-01', '2022-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (2, 7, 5, 1, 26, 160, '2022-01-01', '2022-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (5, 5, 2, 1, 15, 140, '2022-01-01', '2022-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (1, 8, 4, 1, 29, 250, '2022-01-01', '2022-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (4, 1, 1, 1, 17, 170, '2022-01-01', '2022-12-31');


-- Inserts para la tabla FUNCIONES en el rango de fechas del año 2023
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (2, 4, 3, 1, 2, 150, '2023-01-01', '2023-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (3, 2, 5, 1, 19, 120, '2023-01-01', '2023-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (1, 6, 2, 1, 14, 180, '2023-01-01', '2023-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (4, 1, 4, 1, 5, 200, '2023-01-01', '2023-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (5, 9, 1, 1, 17, 130, '2023-01-01', '2023-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (3, 3, 3, 1, 21, 220, '2023-01-01', '2023-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (2, 7, 5, 1, 4, 160, '2023-01-01', '2023-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (5, 5, 2, 1, 13, 140, '2023-01-01', '2023-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (1, 8, 4, 1, 24, 250, '2023-01-01', '2023-12-31');
INSERT INTO FUNCIONES (id_sala, id_horario, id_formato, estado, id_pelicula, precio, fecha_desde, fecha_hasta) VALUES (4, 1, 1, 1, 28, 170, '2023-01-01', '2023-12-31');



--2021
-- Enero
INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
VALUES 
  ('2021-01-01', 1, 1, 1, 1, 300),
  ('2021-01-02', 1, 1, 1, 1, 250),
  ('2021-01-05', 1, 1, 1, 1, 400),
  ('2021-01-08', 1, 1, 1, 1, 320),
  ('2021-01-12', 1, 1, 1, 1, 480),
  ('2021-01-15', 1, 1, 1, 1, 350),
  ('2021-01-24', 1, 1, 1, 1, 290),
  ('2021-01-25', 1, 1, 1, 1, 500),
  ('2021-01-27', 1, 1, 1, 1, 200),
  ('2021-01-30', 1, 1, 1, 1, 120);


INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
VALUES
(1, 1, 1, 2, 150.00), (2, 1, 1, 3, 150.00), (3, 2, 2, 1, 250.00), (4, 3, 3, 6, 400.00), (5, 4, 4, 4, 150.00), (6, 4, 4, 4, 170.00), 
(7, 5, 5, 2, 240.00), (8, 5, 5, 3, 240.00), (9, 6, 6, 2, 350.00), (10, 7, 7, 3, 290.00), (11, 8, 8, 1, 250.00), (12, 8, 8, 1, 250.00), 
(13, 9, 9, 7, 200.00), (14, 10, 10, 8, 120.00);

-- Febrero
INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
VALUES 
  ('2021-02-02', 1, 1, 1, 1, 250),
  ('2021-02-05', 1, 1, 1, 1, 120),
  ('2021-02-08', 1, 1, 1, 1, 200),
  ('2021-02-12', 1, 1, 1, 1, 270),
  ('2021-02-15', 1, 1, 1, 1, 180),
  ('2021-02-20', 1, 1, 1, 1, 150),
  ('2021-02-24', 1, 1, 1, 1, 290),
  ('2021-02-28', 1, 1, 1, 1, 200);

INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
VALUES
(15, 11, 1, 2, 150.00), 
(16, 11, 1, 3, 100.00), 
(17, 12, 2, 1, 120.00), 
(18, 13, 3, 6, 200.00), 
(19, 14, 4, 4, 270.00), 
(20, 15, 4, 5, 180.00), 
(21, 16, 5, 2, 150.00), 
(22, 17, 5, 3, 290.00), 
(23, 18, 6, 2, 200.00);

-- Marzo
INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
VALUES 
  ('2021-03-02', 4, 5, 3, 2, 320),
  ('2021-03-05', 2, 12, 4, 1, 450),
  ('2021-03-08', 5, 7, 2, 3, 380),
  ('2021-03-12', 1, 18, 1, 5, 420),
  ('2021-03-15', 3, 15, 5, 4, 300),
  ('2021-03-20', 4, 6, 3, 2, 280),
  ('2021-03-24', 5, 8, 2, 1, 490),
  ('2021-03-28', 2, 11, 4, 3, 350),
  ('2021-03-15', 3, 20, 1, 5, 420),
  ('2021-03-18', 1, 14, 5, 4, 250),
  ('2021-03-22', 3, 9, 3, 2, 480),
  ('2021-03-26', 4, 19, 2, 1, 410),
  ('2021-03-29', 5, 13, 4, 3, 300),
  ('2021-03-30', 2, 10, 1, 5, 470);


INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
VALUES
(24, 19, 1, 2, 150.00), 
(25, 19, 1, 3, 100.00), 
(26, 19, 2, 4, 120.00), 
(27, 20, 3, 6, 200.00), 
(28, 21, 4, 4, 270.00), 
(29, 21, 8, 5, 270.00), 
(30, 22, 4, 5, 180.00), 
(31, 23, 5, 2, 150.00), 
(32, 24, 8, 1, 120.00), 
(33, 25, 4, 5, 180.00), 
(34, 26, 5, 2, 150.00), 
(35, 27, 9, 1, 120.00), 
(36, 27, 3, 2, 200.00), 
(37, 28, 4, 4, 270.00), 
(38, 29, 10, 5, 180.00), 
(39, 30, 10, 2, 150.00), 
(40, 31, 5, 3, 290.00), 
(41, 32, 6, 2, 200.00);

-- Abril
INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
VALUES ('2021-04-03', 5, 14, 2, 4, 420),
('2021-04-10', 2, 7, 1, 3, 310),
('2021-04-15', 4, 18, 3, 2, 480),
('2021-04-22', 1, 10, 5, 1, 250),
('2021-04-28', 3, 5, 4, 5, 370);

INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
VALUES
(42, 33, 10, 2, 150.00), 
(43, 33, 10, 3, 100.00), 
(44, 34, 2, 4, 120.00), 
(45, 34, 3, 6, 200.00), 
(46, 35, 8, 4, 270.00), 
(47, 36, 8, 5, 270.00), 
(48, 37, 4, 5, 180.00), 
(49, 37, 5, 2, 150.00), 
(50, 37, 5, 3, 150.00);

---- Mayo
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2021-05-07', 3, 12, 4, 2, 320),
--('2021-05-15', 5, 6, 1, 5, 450),
--('2021-05-28', 2, 19, 3, 4, 290);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(38, 4, 1, 270.00), 
--(39, 1, 2, 150.00), 
--(39, 1, 3, 100.00), 
--(39, 1, 4, 180.00), 
--(40, 7, 6, 150.00), 
--(40, 7, 8, 290.00);

---- Junio
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2021-06-03', 4, 15, 2, 3, 380),
--('2021-06-09', 2, 8, 3, 5, 260),
--('2021-06-12', 1, 19, 1, 4, 410),
--('2021-06-17', 5, 4, 5, 2, 340),
--('2021-06-21', 3, 11, 4, 1, 480),
--('2021-06-23', 1, 16, 2, 5, 310),
--('2021-06-26', 4, 7, 1, 3, 470),
--('2021-06-28', 5, 12, 5, 4, 290),
--('2021-06-30', 2, 5, 3, 1, 380);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(41, 1, 2, 150.00), 
--(41, 1, 3, 100.00), 
--(42, 2, 4, 120.00), 
--(42, 2, 6, 200.00), 
--(43, 4, 4, 270.00), 
--(44, 4, 5, 270.00), 
--(45, 5, 5, 180.00), 
--(45, 5, 2, 150.00), 
--(46, 6, 1, 120.00), 
--(46, 6, 5, 180.00), 
--(47, 7, 2, 150.00), 
--(47, 7, 1, 120.00), 
--(48, 8, 2, 200.00), 
--(48, 8, 4, 270.00), 
--(49, 9, 5, 180.00);

---- Julio
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2021-07-02', 5, 13, 4, 3, 280),
--('2021-07-06', 3, 20, 1, 5, 370),
--('2021-07-10', 2, 9, 2, 4, 240),
--('2021-07-15', 4, 16, 5, 2, 320),
--('2021-07-18', 1, 7, 3, 1, 400),
--('2021-07-22', 5, 12, 1, 5, 270),
--('2021-07-25', 3, 5, 4, 3, 310),
--('2021-07-28', 2, 18, 5, 4, 260),
--('2021-07-30', 4, 1, 2, 1, 180);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(50, 1, 2, 150.00), 
--(51, 1, 3, 100.00), 
--(52, 2, 4, 120.00), 
--(52, 2, 6, 200.00), 
--(53, 4, 4, 270.00), 
--(54, 4, 5, 270.00), 
--(55, 5, 5, 180.00), 
--(55, 5, 2, 150.00), 
--(56, 6, 1, 120.00), 
--(56, 6, 5, 180.00), 
--(57, 7, 2, 150.00), 
--(58, 8, 2, 200.00);

---- Agosto
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total)
--VALUES('2021-08-03', 2, 16, 4, 3, 290),
--('2021-08-09', 4, 8, 2, 1, 240),
--('2021-08-12', 5, 14, 3, 5, 370),
--('2021-08-18', 1, 5, 5, 4, 180),
--('2021-08-23', 3, 19, 1, 2, 320),
--('2021-08-28', 5, 7, 3, 5, 270);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(59, 1, 2, 150.00), 
--(60, 1, 3, 100.00), 
--(60, 1, 4, 120.00), 
--(61, 2, 6, 200.00), 
--(61, 2, 4, 270.00), 
--(61, 2, 5, 270.00), 
--(62, 5, 5, 180.00), 
--(63, 6, 2, 150.00), 
--(64, 8, 1, 120.00);

---- Septiembre
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total)
--VALUES('2021-09-05', 3, 10, 1, 4, 310),
--('2021-09-08', 4, 15, 3, 2, 250),
--('2021-09-12', 1, 7, 2, 5, 290),
--('2021-09-17', 2, 19, 4, 1, 360),
--('2021-09-19', 5, 4, 1, 3, 200),
--('2021-09-22', 3, 14, 5, 2, 330),
--('2021-09-25', 1, 6, 2, 5, 280),
--('2021-09-28', 4, 17, 4, 1, 390),
--('2021-09-14', 2, 11, 3, 3, 180),
--('2021-09-07', 5, 2, 5, 4, 260),
--('2021-09-30', 3, 20, 1, 2, 310),
--('2021-09-10', 1, 9, 3, 5, 230);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(65, 1, 2, 150.00), 
--(66, 1, 3, 100.00), 
--(67, 2, 4, 120.00), 
--(68, 2, 6, 200.00), 
--(69, 4, 4, 270.00), 
--(70, 4, 5, 270.00), 
--(71, 5, 5, 180.00), 
--(72, 5, 2, 150.00), 
--(73, 6, 1, 120.00), 
--(74, 6, 5, 180.00), 
--(75, 7, 2, 150.00), 
--(76, 7, 1, 120.00);

---- Octubre
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2021-10-03', 2, 14, 4, 1, 250),
--('2021-10-08', 4, 6, 2, 5, 180),
--('2021-10-15', 1, 19, 1, 3, 200),
--('2021-10-22', 5, 8, 5, 2, 270),
--('2021-10-28', 3, 17, 3, 4, 230);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(77, 1, 2, 150.00), 
--(77, 1, 3, 100.00), 
--(78, 2, 4, 120.00), 
--(78, 2, 6, 200.00), 
--(79, 4, 4, 270.00), 
--(79, 4, 5, 270.00), 
--(80, 5, 5, 180.00), 
--(80, 5, 6, 180.00), 
--(81, 9, 2, 150.00), 
--(81, 9, 1, 200.00);

---- Noviembre
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2021-11-02', 3, 5, 3, 2, 220),
--('2021-11-06', 1, 16, 4, 1, 260),
--('2021-11-10', 4, 11, 2, 5, 180),
--('2021-11-14', 2, 8, 1, 4, 280),
--('2021-11-18', 5, 3, 5, 3, 200),
--('2021-11-21', 1, 20, 3, 2, 240),
--('2021-11-25', 4, 7, 5, 1, 270),
--('2021-11-27', 2, 13, 1, 5, 190),
--('2021-11-29', 3, 19, 2, 4, 210),
--('2021-11-30', 5, 10, 4, 3, 290);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(82, 1, 2, 150.00), 
--(82, 1, 3, 100.00), 
--(83, 2, 4, 120.00), 
--(83, 2, 6, 200.00), 
--(84, 4, 4, 270.00), 
--(85, 5, 5, 270.00), 
--(85, 5, 6, 180.00), 
--(86, 5, 2, 150.00), 
--(87, 8, 1, 120.00), 
--(88, 9, 5, 180.00), 
--(88, 9, 2, 150.00), 
--(88, 9, 1, 120.00), 
--(89, 3, 2, 200.00), 
--(89, 3, 3, 270.00), 
--(90, 10, 5, 180.00), 
--(90, 10, 6, 150.00), 
--(90, 10, 6, 290.00), 
--(91, 6, 8, 200.00);

---- Diciembre
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total)
--VALUES('2021-12-02', 5, 15, 4, 3, 270),
--('2021-12-04', 3, 8, 2, 1, 200),
--('2021-12-07', 1, 17, 5, 4, 180),
--('2021-12-10', 4, 12, 1, 5, 260),
--('2021-12-12', 2, 5, 3, 2, 290),
--('2021-12-15', 5, 20, 4, 1, 170),
--('2021-12-18', 1, 10, 1, 5, 240),
--('2021-12-21', 4, 6, 5, 3, 230),
--('2021-12-24', 2, 19, 2, 4, 280),
--('2021-12-26', 3, 14, 3, 2, 260),
--('2021-12-28', 5, 7, 1, 4, 210),
--('2021-12-16', 1, 2, 2, 1, 180),
--('2021-12-20', 4, 16, 4, 3, 290),
--('2021-12-29', 2, 11, 5, 2, 250),
--('2021-12-30', 3, 4, 3, 1, 190);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(92, 1, 2, 150.00), 
--(92, 1, 3, 100.00), 
--(93, 2, 4, 120.00), 
--(94, 3, 6, 200.00), 
--(95, 4, 4, 270.00), 
--(96, 8, 5, 270.00), 
--(97, 4, 5, 180.00), 
--(98, 5, 2, 150.00), 
--(99, 8, 1, 120.00), 
--(99, 8, 2, 180.00), 
--(100, 5, 1, 150.00), 
--(101, 9, 2, 120.00), 
--(102, 3, 3, 200.00), 
--(103, 4, 4, 270.00), 
--(104, 10, 5, 180.00), 
--(105, 10, 2, 150.00), 
--(106, 5, 1, 290.00), 
--(106, 5, 2, 200.00);


----2022
---- Enero 2022
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2022-01-02', 3, 8, 4, 2, 250),
--('2022-01-04', 5, 16, 1, 5, 180),
--('2022-01-06', 1, 20, 2, 1, 200),
--('2022-01-09', 4, 7, 3, 3, 220),
--('2022-01-12', 2, 10, 5, 4, 270),
--('2022-01-15', 5, 18, 1, 5, 190),
--('2022-01-18', 1, 14, 2, 3, 210),
--('2022-01-21', 3, 3, 4, 2, 230),
--('2022-01-24', 4, 19, 5, 1, 250),
--('2022-01-27', 2, 6, 3, 4, 180),
--('2022-01-30', 5, 12, 1, 2, 200),
--('2022-01-03', 3, 15, 2, 5, 220),
--('2022-01-07', 1, 11, 4, 3, 260),
--('2022-01-11', 4, 5, 5, 1, 280),
--('2022-01-14', 2, 17, 1, 4, 240),
--('2022-01-17', 5, 9, 3, 2, 270),
--('2022-01-20', 1, 13, 4, 5, 200),
--('2022-01-23', 3, 2, 2, 1, 240),
--('2022-01-26', 4, 4, 5, 3, 260),
--('2022-01-29', 2, 1, 1, 4, 190);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(107, 11, 2, 150.00), 
--(108, 11, 3, 100.00), 
--(109, 12, 4, 120.00), 
--(110, 12, 6, 200.00), 
--(111, 14, 4, 270.00), 
--(112, 15, 5, 270.00), 
--(113, 15, 6, 180.00), 
--(114, 15, 2, 150.00), 
--(115, 18, 1, 120.00), 
--(116, 19, 5, 180.00), 
--(117, 19, 2, 150.00), 
--(118, 19, 1, 120.00), 
--(119, 13, 2, 200.00), 
--(120, 13, 3, 270.00), 
--(121, 16, 5, 180.00), 
--(122, 16, 6, 150.00), 
--(123, 17, 6, 290.00), 
--(124, 18, 8, 200.00),
--(125, 18, 6, 150.00), 
--(126, 20, 6, 290.00);

---- Febrero 2022
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2022-02-02', 3, 8, 4, 2, 270),
--('2022-02-04', 5, 16, 1, 5, 230),
--('2022-02-06', 1, 20, 2, 1, 250),
--('2022-02-09', 4, 7, 3, 3, 190),
--('2022-02-12', 2, 10, 5, 4, 220),
--('2022-02-15', 5, 18, 1, 5, 200),
--('2022-02-18', 1, 14, 2, 3, 280),
--('2022-02-21', 3, 3, 4, 2, 290),
--('2022-02-24', 4, 19, 5, 1, 260),
--('2022-02-27', 2, 6, 3, 4, 200),
--('2022-02-28', 5, 12, 1, 2, 210),
--('2022-02-03', 3, 15, 2, 5, 280);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(127, 11, 2, 150.00), 
--(127, 11, 3, 100.00), 
--(127, 11, 4, 120.00), 
--(128, 12, 6, 200.00), 
--(129, 14, 4, 270.00), 
--(130, 15, 5, 270.00), 
--(131, 15, 6, 180.00), 
--(132, 15, 2, 150.00), 
--(133, 18, 1, 120.00), 
--(133, 18, 5, 180.00), 
--(134, 19, 1, 150.00), 
--(134, 19, 2, 120.00), 
--(135, 13, 2, 200.00), 
--(135, 13, 3, 270.00), 
--(136, 18, 5, 180.00), 
--(137, 16, 6, 150.00), 
--(138, 11, 7, 290.00);

---- Marzo 2022
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2022-03-02', 3, 8, 4, 2, 290),
--('2022-03-04', 5, 16, 1, 5, 200),
--('2022-03-06', 1, 20, 2, 1, 220),
--('2022-03-09', 4, 7, 3, 3, 180),
--('2022-03-12', 2, 10, 5, 4, 240),
--('2022-03-15', 5, 18, 1, 5, 230),
--('2022-03-18', 1, 14, 2, 3, 280),
--('2022-03-21', 3, 3, 4, 2, 250),
--('2022-03-24', 4, 19, 5, 1, 290),
--('2022-03-27', 2, 6, 3, 4, 190),
--('2022-03-28', 5, 12, 1, 2, 200),
--('2022-03-03', 3, 15, 2, 5, 260);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(139, 11, 2, 150.00), 
--(139, 11, 3, 100.00), 
--(139, 11, 4, 120.00), 
--(140, 12, 6, 200.00), 
--(141, 14, 4, 270.00), 
--(142, 15, 5, 270.00), 
--(143, 15, 6, 180.00), 
--(144, 15, 2, 150.00), 
--(145, 18, 1, 120.00), 
--(145, 18, 5, 180.00), 
--(146, 19, 1, 150.00), 
--(147, 19, 2, 120.00), 
--(148, 13, 2, 200.00), 
--(149, 13, 3, 270.00), 
--(150, 16, 5, 180.00), 
--(150, 16, 6, 150.00), 
--(150, 16, 7, 290.00);

---- Abril 2022
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2022-04-03', 5, 7, 4, 2, 260),
--('2022-04-06', 1, 12, 3, 3, 180),
--('2022-04-09', 4, 18, 1, 4, 240),
--('2022-04-12', 2, 3, 5, 5, 190),
--('2022-04-15', 3, 10, 2, 1, 220),
--('2022-04-18', 5, 14, 1, 2, 250),
--('2022-04-21', 2, 20, 3, 3, 200),
--('2022-04-24', 4, 6, 2, 5, 270);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(151, 11, 2, 150.00), 
--(151, 11, 3, 100.00), 
--(151, 11, 4, 120.00), 
--(152, 12, 6, 200.00), 
--(153, 14, 4, 270.00), 
--(154, 15, 5, 270.00), 
--(155, 15, 6, 180.00), 
--(156, 15, 2, 150.00), 
--(157, 18, 1, 120.00), 
--(158, 18, 5, 180.00);

---- Mayo 2022
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2022-05-05', 3, 15, 4, 1, 280),
--('2022-05-08', 2, 8, 2, 3, 210),
--('2022-05-11', 5, 11, 1, 4, 260),
--('2022-05-14', 1, 19, 3, 5, 180),
--('2022-05-20', 4, 5, 5, 2, 230);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(159, 12, 2, 150.00), 
--(159, 11, 3, 100.00), 
--(160, 13, 4, 120.00), 
--(161, 12, 6, 200.00), 
--(161, 14, 4, 270.00), 
--(162, 15, 5, 270.00), 
--(163, 16, 6, 180.00), 
--(163, 17, 2, 150.00), 
--(163, 18, 1, 120.00), 
--(163, 19, 5, 180.00);

---- Junio 2022
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2022-06-03', 4, 17, 3, 5, 250),
--('2022-06-08', 1, 8, 2, 4, 220),
--('2022-06-15', 3, 14, 1, 3, 190),
--('2022-06-20', 5, 5, 4, 2, 270),
--('2022-06-28', 2, 20, 5, 1, 200);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(164, 12, 2, 150.00), 
--(165, 11, 3, 100.00), 
--(166, 13, 4, 120.00), 
--(167, 12, 6, 200.00), 
--(168, 19, 5, 180.00);

---- Julio 2022
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2022-07-04', 3, 15, 2, 4, 260),
--('2022-07-12', 2, 8, 5, 1, 220),
--('2022-07-18', 5, 11, 1, 3, 180),
--('2022-07-25', 1, 20, 4, 2, 240);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(169, 12, 2, 150.00), 
--(169, 11, 3, 100.00), 
--(170, 13, 4, 120.00), 
--(171, 12, 8, 200.00),  
--(172, 18, 1, 120.00), 
--(172, 19, 5, 180.00);

---- Agosto 2022
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2022-08-02', 4, 7, 3, 5, 150),
--('2022-08-07', 2, 16, 1, 2, 200),
--('2022-08-12', 1, 5, 4, 3, 250),
--('2022-08-18', 3, 19, 2, 4, 180),
--('2022-08-22', 5, 11, 5, 1, 220),
--('2022-08-25', 1, 13, 3, 2, 170),
--('2022-08-20', 4, 2, 4, 1, 190),
--('2022-08-16', 2, 8, 1, 5, 270),
--('2022-08-28', 3, 14, 5, 3, 130),
--('2022-08-30', 5, 20, 2, 4, 160);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(173, 11, 2, 150.00), 
--(174, 11, 3, 100.00), 
--(175, 11, 4, 120.00), 
--(175, 12, 6, 200.00), 
--(176, 14, 4, 270.00), 
--(177, 15, 5, 270.00), 
--(178, 15, 6, 180.00), 
--(178, 15, 2, 150.00), 
--(178, 18, 1, 120.00), 
--(179, 18, 5, 180.00), 
--(180, 19, 1, 150.00), 
--(181, 19, 2, 120.00), 
--(182, 20, 2, 200.00);

---- Septiembre 2022
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2022-09-03', 1, 6, 3, 4, 280),
--('2022-09-08', 4, 15, 2, 1, 110),
--('2022-09-13', 2, 5, 4, 2, 240),
--('2022-09-17', 3, 18, 1, 5, 170),
--('2022-09-22', 5, 10, 5, 3, 200),
--('2022-09-25', 1, 12, 2, 4, 140),
--('2022-09-19', 4, 3, 4, 1, 260),
--('2022-09-15', 2, 9, 1, 5, 180),
--('2022-09-28', 3, 13, 5, 2, 150),
--('2022-09-30', 5, 19, 3, 4, 230);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(183, 11, 1, 150.00), 
--(184, 11, 2, 100.00), 
--(185, 12, 3, 120.00), 
--(186, 12, 4, 200.00), 
--(186, 14, 5, 270.00), 
--(186, 14, 6, 270.00), 
--(187, 15, 7, 180.00), 
--(187, 15, 8, 150.00), 
--(188, 18, 1, 120.00), 
--(189, 18, 2, 180.00), 
--(190, 19, 3, 150.00), 
--(191, 19, 4, 120.00), 
--(192, 13, 5, 200.00), 
--(192, 13, 6, 270.00);

---- Octubre 2022
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2022-10-03', 1, 6, 3, 4, 120),
--('2022-10-08', 4, 15, 2, 1, 250),
--('2022-10-13', 2, 5, 4, 2, 130),
--('2022-10-17', 3, 18, 1, 5, 200),
--('2022-10-22', 5, 10, 5, 3, 180),
--('2022-10-25', 1, 12, 2, 4, 170),
--('2022-10-19', 4, 3, 4, 1, 280),
--('2022-10-15', 2, 9, 1, 5, 140),
--('2022-10-28', 3, 13, 5, 2, 160),
--('2022-10-30', 5, 19, 3, 4, 190);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(193, 11, 2, 150.00), 
--(194, 12, 3, 100.00), 
--(195, 13, 4, 120.00), 
--(196, 14, 6, 200.00), 
--(197, 15, 4, 270.00), 
--(198, 16, 5, 270.00), 
--(199, 16, 6, 180.00), 
--(200, 17, 2, 150.00), 
--(200, 17, 1, 120.00), 
--(201, 18, 5, 180.00), 
--(202, 20, 1, 150.00);

---- Noviembre 2022
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2022-11-03', 2, 7, 1, 3, 210),
--('2022-11-08', 4, 14, 4, 2, 120),
--('2022-11-13', 1, 5, 2, 1, 250),
--('2022-11-17', 3, 18, 5, 4, 160),
--('2022-11-22', 5, 9, 3, 1, 220),
--('2022-11-25', 2, 12, 1, 5, 190),
--('2022-11-19', 4, 3, 4, 2, 230),
--('2022-11-15', 1, 8, 5, 3, 170),
--('2022-11-28', 3, 13, 2, 1, 200),
--('2022-11-30', 5, 20, 1, 4, 140);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(203, 11, 2, 150.00), 
--(204, 11, 3, 100.00), 
--(205, 12, 4, 120.00), 
--(206, 13, 6, 200.00), 
--(207, 14, 4, 270.00), 
--(208, 15, 5, 270.00), 
--(209, 15, 6, 180.00), 
--(210, 16, 2, 150.00), 
--(211, 17, 1, 120.00), 
--(212, 19, 5, 180.00);

---- Diciembre 2022
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total)
--VALUES('2022-12-03', 2, 6, 3, 4, 260),
--('2022-12-08', 4, 15, 2, 1, 130),
--('2022-12-13', 1, 5, 4, 2, 240),
--('2022-12-17', 3, 18, 1, 5, 180),
--('2022-12-22', 5, 10, 5, 3, 150),
--('2022-12-25', 2, 12, 2, 4, 200),
--('2022-12-19', 4, 3, 4, 1, 170),
--('2022-12-15', 1, 9, 1, 5, 220),
--('2022-12-28', 3, 13, 5, 2, 190),
--('2022-12-30', 5, 19, 3, 4, 160);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(213, 11, 2, 150.00), 
--(213, 11, 3, 100.00), 
--(214, 12, 4, 120.00), 
--(215, 13, 6, 200.00), 
--(215, 13, 7, 270.00), 
--(215, 13, 8, 120.00), 
--(216, 14, 6, 200.00), 
--(217, 15, 4, 270.00), 
--(218, 16, 5, 270.00), 
--(219, 17, 6, 180.00), 
--(220, 18, 5, 270.00), 
--(221, 19, 6, 180.00), 
--(221, 19, 2, 150.00), 
--(222, 20, 1, 120.00), 
--(222, 20, 5, 180.00);



---- Enero 2023
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2023-01-03', 2, 7, 1, 3, 150),
--('2023-01-08', 4, 14, 4, 2, 220),
--('2023-01-13', 1, 5, 2, 1, 180),
--('2023-01-17', 3, 18, 5, 4, 270),
--('2023-01-22', 5, 9, 3, 1, 130);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(223, 21, 2, 150.00), 
--(223, 21, 3, 100.00), 
--(224, 22, 4, 120.00), 
--(225, 23, 6, 200.00), 
--(225, 23, 7, 270.00), 
--(225, 23, 8, 120.00), 
--(226, 24, 6, 200.00), 
--(227, 25, 4, 270.00);

---- Febrero 2023
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2023-02-03', 2, 7, 1, 3, 240),
--('2023-02-08', 4, 14, 4, 2, 160),
--('2023-02-13', 1, 5, 2, 1, 200),
--('2023-02-17', 3, 18, 5, 4, 170),
--('2023-02-22', 5, 9, 3, 1, 190);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(228, 21, 2, 150.00), 
--(229, 22, 3, 100.00), 
--(230, 23, 4, 120.00), 
--(230, 23, 6, 200.00), 
--(231, 24, 7, 270.00), 
--(231, 24, 8, 120.00), 
--(232, 26, 6, 200.00), 
--(232, 26, 4, 270.00);

---- Marzo 2023
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2023-03-03', 2, 7, 1, 3, 180),
--('2023-03-08', 4, 14, 4, 2, 250),
--('2023-03-13', 1, 5, 2, 1, 130),
--('2023-03-17', 3, 18, 5, 4, 220);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(233, 27, 2, 150.00), 
--(233, 27, 3, 100.00), 
--(234, 28, 4, 120.00), 
--(235, 29, 6, 200.00), 
--(236, 29, 7, 270.00);

---- Abril 2023
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2023-04-03', 2, 7, 1, 3, 160),
--('2023-04-08', 4, 14, 4, 2, 210),
--('2023-04-13', 1, 5, 2, 1, 280),
--('2023-04-17', 3, 18, 5, 4, 230),
--('2023-04-22', 5, 9, 3, 1, 150),
--('2023-04-27', 1, 16, 4, 5, 190),
--('2023-04-18', 2, 11, 2, 3, 200),
--('2023-04-25', 4, 20, 1, 4, 140);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(237, 21, 2, 150.00), 
--(238, 21, 3, 100.00), 
--(238, 21, 4, 120.00), 
--(238, 21, 6, 200.00), 
--(239, 23, 7, 270.00), 
--(240, 23, 8, 120.00), 
--(240, 23, 6, 200.00), 
--(241, 25, 4, 270.00), 
--(242, 26, 5, 270.00), 
--(243, 27, 6, 180.00), 
--(243, 27, 5, 270.00), 
--(244, 27, 4, 180.00);

---- Mayo 2023
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2023-05-03', 2, 7, 1, 3, 170),
--('2023-05-08', 4, 14, 4, 2, 250),
--('2023-05-13', 1, 5, 2, 1, 140),
--('2023-05-17', 3, 18, 5, 4, 190);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(245, 21, 2, 150.00), 
--(245, 21, 3, 100.00), 
--(245, 21, 4, 120.00), 
--(245, 21, 6, 200.00), 
--(246, 23, 7, 270.00), 
--(246, 23, 8, 120.00), 
--(247, 24, 6, 200.00), 
--(248, 25, 4, 270.00), 
--(248, 25, 5, 270.00), 
--(248, 25, 6, 180.00);

---- Junio 2023
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2023-06-03', 2, 7, 1, 3, 270),
--('2023-06-08', 4, 14, 4, 2, 200),
--('2023-06-13', 1, 5, 2, 1, 220),
--('2023-06-17', 3, 18, 5, 4, 180),
--('2023-06-22', 5, 9, 3, 1, 160),
--('2023-06-27', 1, 16, 4, 5, 190),
--('2023-06-18', 2, 11, 2, 3, 210),
--('2023-06-25', 4, 20, 1, 4, 230);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(249, 29, 2, 150.00), 
--(250, 29, 3, 100.00), 
--(251, 28, 4, 120.00), 
--(252, 27, 6, 200.00), 
--(253, 26, 7, 270.00), 
--(254, 25, 8, 120.00), 
--(255, 24, 6, 200.00), 
--(256, 23, 4, 270.00); 


---- Julio 2023
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2023-07-03', 2, 7, 1, 3, 120),
--('2023-07-08', 4, 14, 4, 2, 190),
--('2023-07-13', 1, 5, 2, 1, 200),
--('2023-07-17', 3, 18, 5, 4, 150),
--('2023-07-22', 5, 9, 3, 1, 230),
--('2023-07-27', 1, 16, 4, 5, 140),
--('2023-07-18', 2, 11, 2, 3, 260);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(257, 26, 5, 270.00), 
--(258, 27, 6, 180.00), 
--(259, 28, 5, 270.00), 
--(260, 29, 6, 180.00), 
--(260, 29, 2, 150.00), 
--(261, 21, 1, 120.00),
--(261, 21, 2, 150.00), 
--(262, 21, 3, 100.00), 
--(262, 22, 4, 120.00), 
--(262, 23, 6, 200.00), 
--(263, 23, 7, 270.00); 

---- Agosto 2023
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2023-08-03', 2, 7, 1, 3, 260),
--('2023-08-08', 4, 14, 4, 2, 130),
--('2023-08-13', 1, 5, 2, 1, 220),
--('2023-08-17', 3, 18, 5, 4, 190),
--('2023-08-22', 5, 9, 3, 1, 200),
--('2023-08-27', 1, 16, 4, 5, 170);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(264, 23, 8, 120.00), 
--(264, 23, 6, 200.00), 
--(265, 25, 4, 270.00), 
--(266, 26, 5, 270.00), 
--(267, 27, 6, 180.00), 
--(268, 28, 5, 270.00), 
--(269, 29, 6, 180.00), 
--(269, 29, 2, 150.00), 
--(269, 29, 1, 120.00);

---- Septiembre 2023
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2023-09-02', 2, 4, 3, 2, 260),
--('2023-09-05', 3, 7, 1, 4, 120),
--('2023-09-10', 5, 13, 5, 5, 170),
--('2023-09-15', 1, 2, 2, 3, 180),
--('2023-09-22', 4, 11, 4, 1, 290);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(270, 25, 8, 120.00), 
--(271, 26, 6, 200.00), 
--(272, 27, 4, 270.00), 
--(273, 28, 5, 270.00), 
--(274, 29, 6, 180.00);

---- Octubre 2023
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2023-10-03', 2, 6, 3, 4, 240),
--('2023-10-07', 3, 8, 1, 2, 170),
--('2023-10-12', 5, 15, 5, 1, 160),
--('2023-10-18', 1, 3, 2, 5, 250),
--('2023-10-25', 4, 12, 4, 3, 130);

--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(275, 23, 8, 120.00), 
--(276, 24, 6, 200.00), 
--(277, 25, 6, 180.00), 
--(278, 26, 2, 150.00), 
--(279, 27, 1, 120.00);

---- Noviembre 2023
--INSERT INTO TICKETS (fecha, id_empleado, id_cliente, id_medio_pedido, id_promocion, total) 
--VALUES('2023-11-01', 2, 5, 3, 1, 180),
--('2023-11-08', 3, 9, 1, 5, 260),
--('2023-11-14', 5, 14, 5, 2, 140),
--('2023-11-20', 1, 4, 2, 4, 180),
--('2023-11-27', 4, 10, 4, 3, 200);


--INSERT INTO DETALLES_TICKET (id_detalle, id_ticket, id_funcion, id_butaca, precio_venta)
--VALUES
--(280, 25, 1, 120.00), 
--(280, 25, 2, 200.00),  
--(281, 25, 3, 270.00), 
--(281, 25, 4, 270.00), 
--(282, 29, 5, 180.00), 
--(283, 28, 6, 270.00), 
--(284, 27, 7, 180.00), 
--(284, 27, 8, 150.00), 
--(284, 27, 1, 120.00);

update TICKETS set estado = 1 

create proc SP_Reporte2
@desde datetime,
@hasta datetime
as
select dt.id_funcion 'Numerodefuncion', Titulo,fecha_desde 'Desde', fecha_hasta 'Hasta',sum(total) 'Gananciatotal'
from FUNCIONES f 
join DETALLES_TICKET dt on dt.id_funcion = f.id_funcion
join TICKETS t on t.id_ticket = dt.id_ticket
join PELICULAS p on p.id_pelicula = f.id_pelicula
where fecha_desde >= @desde and fecha_hasta <= @hasta
group by dt.id_funcion, titulo, fecha_desde, fecha_hasta

create proc [dbo].[SP_GENEROS]
as
begin
select count(*), g.genero
from GENEROS g join PELICULAS p on g.id_genero = p.id_genero
group by g.genero
end