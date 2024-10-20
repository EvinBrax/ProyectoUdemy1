--SCRIPT DE CREACION DE TABLAS PROYECTO 01
--------------------------------------------------------
--CREACIÓN DE BASE DE DATOS

Create database PROYECTO_BDSISTEMA
USE PROYECTO_BDSISTEMA

---------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------
--Tabla Categoria
CREATE TABLE categoria(
	idcategoria INTEGER primary key IDENTITY,
	nombre varchar(50) not null UNIQUE,
	descripcion varchar(255) null,
	estado bit DEFAULT(1)
);
---------------------------------------------------------------------------------------------------------
GO
---------------------------------------------------------------------------------------------------------
--Tabla artículo
CREATE TABLE articulo(
	idarticulo INTEGER primary key IDENTITY,
	idcategoria integer NOT NULL, -- Relacion con la tabla CATEGORIA
	codigo varchar(50) null,
	nombre varchar(100) not null UNIQUE,
	precio_venta decimal(11,2) not null,
	stock integer not null,
	descripcion varchar(255) null,
	imagen varchar(20) null, --Ruta de la imagen en un directorio del sistema
	estado bit DEFAULT(1),
	FOREIGN KEY (idcategoria) REFERENCES categoria(idcategoria)
);
---------------------------------------------------------------------------------------------------------
GO
---------------------------------------------------------------------------------------------------------
--Tabla persona
--SE ALMACENARAN CLIENTES Y PROVEDORES
CREATE TABLE persona(
	idpersona INTEGER primary key IDENTITY,
	tipo_persona varchar(20) not null, --permitira diferencias entre clientes y provedores
	nombre varchar(100) not null,
	tipo_documento varchar(20) null,
	numero_documento varchar(20) null,
	direccion varchar(70) null,
	telefono varchar(20) null,
	email varchar(50) null,
);
---------------------------------------------------------------------------------------------------------
GO
---------------------------------------------------------------------------------------------------------
--Tabla rol
--SE ALMACENARAN LOS ROLES QUE SERAN ASIGNADOS A UN USUARIO

CREATE TABLE rol(
	idrol INTEGER primary key IDENTITY,
	nombre varchar(30) not null,
	descripcion varchar(254) null,
	estado bit default(1)
);
---------------------------------------------------------------------------------------------------------
GO
---------------------------------------------------------------------------------------------------------
--Tabla usuario
CREATE TABLE usuario(
	idusuario INTEGER primary key IDENTITY,
	idrol integer NOT NULL, -- Relacion con la tabla rol
	nombre varchar(100) not null UNIQUE,
	tipo_documento varchar(20) null,
	numero_documento varchar(20) null,
	direccion varchar(70) null,
	telefono varchar(20) null,
	email varchar(50) not null,		-- se usara para el acceso al sistema
	clave varbinary(MAX) not null,	-- se usara para el acceso al sistema
	estado bit DEFAULT(1),
	FOREIGN KEY (idrol) REFERENCES rol(idrol) -- creacion de relacion con la tabla rol.
);
---------------------------------------------------------------------------------------------------------
GO
---------------------------------------------------------------------------------------------------------
--Tabla ingreso (COMPRAS)
CREATE TABLE ingreso(
	idingreso INTEGER primary key IDENTITY,
	idproveedor integer not null,		-- Relacion con la tabla persona, para determinar el PROVEDOR
	idusuario integer not null,			-- Relacion con la tabla usuario, para determinar el USUARIO
	tipo_comprobante varchar(20) not null,
	serie_comprobante varchar(7) not null,
	num_comprobante varchar(10) not null,
	fecha datetime not null,
	impuesto decimal(4,2) not null,
	total decimal(11,2) not null,
	estado varchar(20) not null,
	FOREIGN KEY (idproveedor) REFERENCES persona(idpersona), -- creacion de relacion con la tabla persona.
	FOREIGN KEY (idusuario) REFERENCES usuario(idusuario) -- creacion de relacion con la tabla usuario.
);
---------------------------------------------------------------------------------------------------------
GO
---------------------------------------------------------------------------------------------------------
--Tabla detalle_ingreso
CREATE TABLE detalle_ingreso(
	iddetalle_ingreso INTEGER primary key IDENTITY,
	idingreso integer not null, -- Relacion con la tabla ingreso
	idarticulo integer not null, -- Relacion con la tabla articulo
	cantidad integer not null,
	precio decimal(11,2) not null,
	FOREIGN KEY (idingreso) REFERENCES ingreso(idingreso) ON DELETE CASCADE, -- creacion de relacion con la tabla ingreso - ELIMINACION EN CASCADA: Si se elimina un ingreso , de forma automatica se elimina el detalle de ingreso
	FOREIGN KEY (idarticulo) REFERENCES articulo(idarticulo) -- creacion de relacion con la tabla articulo.
);
---------------------------------------------------------------------------------------------------------
GO
---------------------------------------------------------------------------------------------------------
--Tabla venta
CREATE TABLE venta(
	idventa INTEGER primary key IDENTITY,
	idcliente integer not null, -- Relacion con la tabla cliente
	idusuario integer not null, -- Relacion con la tabla usuario
	tipo_comprobante varchar(20) not null,
	serie_comprobante varchar(7) not null,
	num_comprobante varchar(10) not null,
	fecha datetime not null,
	impuesto decimal(4,2) not null,
	total decimal(11,2) not null,
	estado varchar(20) not null,
	FOREIGN KEY (idcliente) REFERENCES persona(idpersona), -- creacion de relacion con la tabla persona.
	FOREIGN KEY (idusuario) REFERENCES usuario(idusuario) -- creacion de relacion con la tabla usuario.
);
---------------------------------------------------------------------------------------------------------
GO
---------------------------------------------------------------------------------------------------------
--Tabla detalle_venta
CREATE TABLE detalle_venta(
	iddetalle_venta INTEGER primary key IDENTITY,
	idventa integer not null, -- Relacion con la tabla idventa
	idarticulo integer not null, -- Relacion con la tabla articulo
	cantidad integer not null,
	precio decimal(11,2) not null,
	descuento decimal (11,2) not null,
	FOREIGN KEY (idventa) REFERENCES venta(idventa) ON DELETE CASCADE, -- creacion de relacion con la tabla venta.
	FOREIGN KEY (idarticulo) REFERENCES articulo(idarticulo) -- creacion de relacion con la tabla articulo.
);





---------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------
--OTROS SCRIPTS
GO 
INSERT INTO categoria (nombre, descripcion)
VALUES ('Dispositivos Cómputo','Todos los dispositivos de Cómputo')
---------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------
SELECT * FROM categoria
---------------------------------------------------------------------------------------------------------