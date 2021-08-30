use dbrest
go

create proc sp_articulos_insertar
@depto_id int,
@seccion_id int,
@marca_id int,
@codigo varchar(50),
@descripcion varchar(50),
@presentacion_id int,
@precio_venta decimal(18,2),
@precio_compra decimal(18,2),
@inventariable int,
@stock_inicial numeric(18,2),
@hay numeric(18,2),
@stock_minimo numeric(18,2),
@vence varchar(50),
@imagen image,
@estado int
as
if exists(select codigo from articulos where codigo=@codigo)
raiserror('Ya existe un articulo con este codigo',16,1)
else
insert into articulos values(
	@depto_id,
	@seccion_id,
	@marca_id,
	@codigo,
	@descripcion,
	@presentacion_id,
	@precio_venta,
	@precio_compra,
	@inventariable,
	@stock_inicial,
	@hay,
	@stock_minimo,
	@vence,
	@imagen,
	@estado
)
go

create proc sp_articulos_editar
@id int,
@depto_id int,
@seccion_id int,
@marca_id int,
@codigo varchar(50),
@descripcion varchar(50),
@presentacion_id int,
@precio_venta decimal(18,2),
@precio_compra decimal(18,2),
@inventariable int,
@stock_inicial numeric(18,2),
@stock_minimo numeric(18,2),
@vence varchar(50),
@imagen image,
@estado int
as
if exists(select codigo from articulos where codigo=@codigo and id<>@id)
raiserror('Ya existe un articulo con este codigo',16,1)
else
update articulos set
	depto_id = @depto_id,
	seccion_id = @seccion_id,
	marca_id = @marca_id,
	codigo = @codigo,
	descripcion = @descripcion,
	presentacion_id = @presentacion_id,
	precio_venta = @precio_venta,
	precio_compra = @precio_compra,
	inventariable = @inventariable,
	stock_inicial = @stock_inicial,
	stock_minimo= @stock_minimo,
	imagen = @imagen,
	estado = @estado
where id=@id
go

create proc sp_articulos_eliminar
@id int
as
delete from articulos where id=@id
go

create view v_articulos
as
select 
	a.id,
	a.codigo,
	a.descripcion as articulos,
	d.id as depto_id,
	d.descripcion as depto,
	s.id as seccion_id,
	s.descripcion as seccion,
	m.id as marca_id,
	m.nombre as marcas,	
	p.id as presentacion_id,
	p.nombre_corto as unidad,
	a.precio_venta as pventa,
	a.precio_compra as pcompra,
	a.inventariable,
	a.stock_inicial,
	a.hay,
	a.stock_minimo,
	a.vence,
	a.imagen,
	a.estado
from articulos as a
inner join departamentos as d
on a.depto_id = d.id
inner join secciones as s
on a.seccion_id = s.id
inner join marcas as m
on a.marca_id = m.id
inner join presentaciones as p
on a.presentacion_id = p.id
go

create proc sp_articulos_mostrar
@estado int,
@buscar varchar(20)
as
select * from v_articulos as va 
where va.estado=@estado and va.articulos like '%'+@buscar+'%'
order by va.articulos desc
go