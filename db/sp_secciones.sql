use restaurante
go

create proc sp_insertar_secciones
@departamento_id int,
@descripcion varchar(50)
as
insert into secciones values(@departamento_id,@descripcion,1)
go

create proc sp_editar_secciones
@id int,
@departamento_id int,
@descripcion varchar(50)
as
update secciones  set
departamento_id = @departamento_id,
descripcion = @descripcion
where id = @id
go


create view v_secciones_depto
as
select 
	s.id,
	d.id as depto_id,
	d.descripcion as depto,
	s.descripcion as seccion,
	s.estado
from secciones s inner join departamentos d
on s.departamento_id = d.id
go

create proc sp_mostrar_secciones
as
select * from v_secciones_depto vsd order by vsd.id asc
go

