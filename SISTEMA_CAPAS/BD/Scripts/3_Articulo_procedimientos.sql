--------------------------------------------------------
--SCRIPT DE CREACION DE STORE PROCEDURE'S PARA USO DE TABLA "categoria" y "articulo"
--------------------------------------------------------
USE PROYECTO_BDSISTEMA
--------------------------------------------------------
--Procedimiento Listar
--El sp relaciona las tablas "articulo" y "categoria"
create proc articulo_listar
as
select a.idarticulo as ID,a.idcategoria,c.nombre as Categoria,
a.codigo as Codigo,a.nombre as Nombre,a.precio_venta as Precio_Venta,
a.stock as Stock,a.descripcion as Descripcion,a.imagen as Imagen,
a.estado as Estado
from articulo a inner join categoria c on a.idcategoria=c.idcategoria
order by a.idarticulo desc
--------------------------------------------------------
GO
--------------------------------------------------------
--Procedimiento Buscar
--El sp relaciona las tablas "articulo" y "categoria"
--Con el where y like se busca el registro indicado
create proc articulo_buscar
@valor varchar(50)
as
select a.idarticulo as ID,a.idcategoria,c.nombre as Categoria,
a.codigo as Codigo,a.nombre as Nombre,a.precio_venta as Precio_Venta,
a.stock as Stock,a.descripcion as Descripcion,a.imagen as Imagen,
a.estado as Estado
from articulo a inner join categoria c on a.idcategoria=c.idcategoria
where a.nombre like '%' +@valor + '%' Or a.descripcion like '%' +@valor + '%'
order by a.nombre asc
--------------------------------------------------------
GO
--------------------------------------------------------
--Procedimiento Insertar
create proc articulo_insertar
@idcategoria integer,
@codigo varchar(50),
@nombre varchar(100),
@precio_venta decimal(11,2),
@stock integer,
@descripcion varchar(255),
@imagen varchar(20)
as
insert into articulo (idcategoria,codigo,nombre,precio_venta,stock,descripcion,imagen)
values (@idcategoria,@codigo,@nombre,@precio_venta,@stock,@descripcion,@imagen)
--------------------------------------------------------
GO
--------------------------------------------------------
--Procedimiento Actualizar
create proc articulo_actualizar
@idarticulo integer,
@idcategoria integer,
@codigo varchar(50),
@nombre varchar(50),
@precio_venta decimal(11,2),
@stock integer,
@descripcion varchar(255),
@imagen varchar(20)
as
update articulo set idcategoria=@idcategoria,codigo=@codigo,
nombre=@nombre,precio_venta=@precio_venta,stock=@stock,
descripcion=@descripcion,imagen=@imagen
where idarticulo=@idarticulo
--------------------------------------------------------
GO
--------------------------------------------------------
--Procedimiento Eliminar
create proc articulo_eliminar
@idarticulo integer
as
delete from articulo
where idarticulo=@idarticulo
--------------------------------------------------------
GO
--------------------------------------------------------
--Procedimiento Desactivar
create proc articulo_desactivar
@idarticulo integer
as
update articulo set estado=0
where idarticulo=@idarticulo
--------------------------------------------------------
GO
--------------------------------------------------------
--Procedimiento Activar
create proc articulo_activar
@idarticulo integer
as
update articulo set estado=1
where idarticulo=@idarticulo
--------------------------------------------------------
GO
--------------------------------------------------------
-- Procedimiento existe
create proc articulo_existe
@valor varchar(100),
@existe bit output
as
if exists (select nombre from articulo where nombre = ltrim(rtrim(@valor)))
	begin
		set @existe=1
	end
else
	begin
		set @existe=0
	end
go








