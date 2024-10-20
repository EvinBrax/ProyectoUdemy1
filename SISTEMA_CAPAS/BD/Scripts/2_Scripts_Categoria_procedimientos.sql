--------------------------------------------------------
--SCRIPT DE CREACION DE STORE PROCEDURE'S PARA USO DE TABLA "categoria"
--------------------------------------------------------
USE PROYECTO_BDSISTEMA
--------------------------------------------------------
--Procedimiento Listar
create proc categoria_listar
as
select idcategoria as ID,nombre as Nombre,descripcion as Descripcion,estado as Estado
from categoria
order by idcategoria desc
--------------------------------------------------------
GO
--------------------------------------------------------
--Procedimiento Buscar
create proc categoria_buscar
@valor varchar(50)
as
select idcategoria as ID,nombre as Nombre,descripcion as Descripcion,estado as Estado
from categoria
where nombre like '%' + @valor + '%' Or descripcion like '%' + @valor + '%'
order by nombre asc
--------------------------------------------------------
GO
--------------------------------------------------------
--Procedimiento Insertar
create proc categoria_insertar
@nombre varchar(50),
@descripcion varchar(255)
as
insert into categoria (nombre,descripcion) values (@nombre,@descripcion)
--------------------------------------------------------
GO
--------------------------------------------------------
--Procedimiento Actualizar
create proc categoria_actualizar
@idcategoria int,
@nombre varchar(50),
@descripcion varchar(255)
as
update categoria set nombre=@nombre,descripcion=@descripcion
where idcategoria=@idcategoria
--------------------------------------------------------
GO
--------------------------------------------------------
--Procedimiento Eliminar
create proc categoria_eliminar
@idcategoria int
as
delete from categoria
where idcategoria=@idcategoria
--------------------------------------------------------
GO
--------------------------------------------------------
--Procedimiento Desactivar
create proc categoria_desactivar
@idcategoria int
as
update categoria set estado=0
where idcategoria=@idcategoria
--------------------------------------------------------
GO
--------------------------------------------------------
--Procedimiento Activar
create proc categoria_activar
@idcategoria int
as
update categoria set estado=1
where idcategoria=@idcategoria
--------------------------------------------------------
GO
--------------------------------------------------------
--Procedimiento validar categoria existente
create procedure categoria_existe
@valor varchar(100),
@existe bit output -- parametro de salida
as
	if exists(select nombre from categoria where nombre = LTRIM(RTRIM(@valor))) -- se utiliza LTRIM,RTRIM para poder eliminar espacios a la izquierda o derecha
		begin
			set @existe = 1
		end
	else
		begin
			set @existe = 0
		end
--------------------------------------------------------


--------------------------------------------------------
--------------------------------------------------------
--------------------------------------------------------
-----SECCION 6 - 29_CAPA_PRES_ListarCategoriasEnComboBox
create procedure categoria_seleccionar
as
select idcategoria,nombre from categoria
where estado = 1
go