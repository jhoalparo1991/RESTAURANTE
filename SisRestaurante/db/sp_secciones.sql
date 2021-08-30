use dbrest
go

create proc sp_secciones_insertar
@depto_id int,
@descripcion varchar(50),
@estado int
as
if exists (select descripcion from secciones where descripcion=@descripcion)
raiserror('Ya existe una seccion con este nombre',16,1)
else
insert into secciones values(@depto_id,@descripcion,@estado)
go

create proc sp_secciones_editar
@id int,
@depto_id int,
@descripcion varchar(50),
@estado int
as
if exists (select descripcion from secciones 
where descripcion=@descripcion and id<>@id)
raiserror('Ya existe una seccion con este nombre',16,1)
else
update secciones set
	depto_id = @depto_id,
	descripcion = @descripcion,
	estado = @estado
	where id=@id
go

create view v_secciones
as
select 
	s.id,
	s.descripcion,
	d.id as depto_id,
	d.descripcion as departamento,
	s.estado
from secciones as s
inner join departamentos as d
on s.depto_id = d.id
go

create proc sp_secciones_mostrar
@estado int 
as
select * from v_secciones as vs
where vs.estado=@estado
go

create proc sp_secciones_eliminar
@id int
as
delete from secciones where id=@id
go

create proc sp_mostrar_secciones_por_departamento
@depto_id int
as
select * from v_secciones as vs where vs.depto_id=@depto_id 
and vs.estado = 0
go