use dbrest
go

create proc sp_marcas_mostrar
@estado int
as
select * from marcas where estado=@estado
go

create proc sp_marcas_insertar
@nombre varchar(50),
@estado int
as
if exists (select nombre from marcas where nombre=@nombre)
raiserror('Y existe una marca con este nombre',16,1)
else
insert into marcas values(@nombre,@estado)
go

create proc sp_marcas_editar
@id int,
@nombre varchar(50),
@estado int
as
if exists (select nombre from marcas where nombre=@nombre and id<>@id)
raiserror('Y existe una marca con este nombre',16,1)
else
update marcas set 
	nombre = @nombre,
	estado = @estado
	where id=@id
go

create proc sp_marcas_eliminar
@id int
as
delete from marcas where id=@id
go