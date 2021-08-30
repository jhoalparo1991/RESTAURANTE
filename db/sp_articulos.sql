use restaurante
go

create proc sp_insertar_articulos
@depto_id int,
@seccion_id int,
@marca_id int,
@codigo nchar(10),
@nombre varchar(50),
@descripcion text,
@unidad_id int,
@precio_venta real,
@precio_compra real,
@inventariable int,
@tiene_stock int,
@stock int,
@oferta int,
@precio_oferta real,
@favorito int,
@imagen image
as
insert into articulos 
(
	depto_id,
	seccion_id,
	marca_id,
	codigo,
	nombre,
	descripcion,
	unidad_id,
	precio_venta,
	precio_compra,
	inventariable,
	tiene_stock,
	stock,
	oferta,
	precio_oferta,
	estado,
	favorito,
	imagen,
	fecha_creado,
	fecha_modificado
)
values 
(
	@depto_id,
	@seccion_id,
	@marca_id,
	@codigo,
	@nombre,
	@descripcion,
	@unidad_id,
	@precio_venta,
	@precio_compra,
	@inventariable,
	@tiene_stock,
	@stock,
	@oferta,
	@precio_oferta,
	1,
	@favorito,
	@imagen,
	getdate(),
	getdate()
)

go

create proc sp_editar_articulos
@id int,
@depto_id int,
@seccion_id int,
@marca_id int,
@codigo nchar(10),
@nombre varchar(50),
@descripcion text,
@unidad_id int,
@precio_venta real,
@precio_compra real,
@inventariable int,
@tiene_stock int,
@oferta int,
@precio_oferta real,
@favorito int,
@imagen image
as
update articulos set 
	depto_id = @depto_id,
	seccion_id = @seccion_id,
	marca_id = @marca_id,
	codigo = @codigo,
	nombre = @nombre,
	descripcion = @descripcion,
	unidad_id = @unidad_id,
	precio_venta = @precio_venta,
	precio_compra = @precio_compra,
	inventariable = @inventariable,
	tiene_stock = @tiene_stock,
	oferta = @oferta,
	precio_oferta = @precio_oferta,
	favorito = @favorito,
	imagen = @imagen,
	fecha_modificado = getdate()
where id=@id
go

create view v_articulos_secciones_depto_marca_unidades
as
select 
	a.id,
	d.id as depto_id,
	d.descripcion as depto,
	s.id as seccion_id,
	s.descripcion as seccion,
	m.id as marca_id,
	m.nombre as marca,
	a.codigo,
	a.nombre as articulo,
	a.descripcion,
	u.id as unidad_id,
	u.nombre_corto as unidad,
	a.precio_venta,
	a.precio_compra,
	a.inventariable,
	a.tiene_stock,
	a.stock,
	a.oferta,
	a.precio_oferta,
	a.estado,
	a.favorito,
	a.imagen,
	a.fecha_creado,
	a.fecha_modificado
from articulos a inner join departamentos d
on a.depto_id = d.id
inner join secciones s
on a.seccion_id = s.id
inner join marcas m 
on a.marca_id = m.id
inner join unidades u
on a.unidad_id = u.id

go
create proc sp_mostrar_articulos_activos
as
select * from v_articulos_secciones_depto_marca_unidades v
where v.estado = 1
go

create proc sp_mostrar_articulos_inactivos
as
select * from v_articulos_secciones_depto_marca_unidades v
where v.estado = 0
go

create proc sp_buscar_articulos
@buscar varchar(30)
as
select * from v_articulos_secciones_depto_marca_unidades v
where 
v.articulo like '%'+@buscar+'%' or
v.depto like '%'+@buscar+'%' or
v.seccion like '%'+@buscar+'%' or
v.codigo like '%'+@buscar+'%' or
v.marca like '%'+@buscar+'%'
go