use dbrest
go

create proc sp_presentaciones_insertar
@nombre_largo varchar(50),
@nombre_corto nchar(10),
@estado int
as
if exists(select nombre_largo from presentaciones where nombre_largo=@nombre_largo)
raiserror('Este nombre ya existe',16,1)
else if exists(select nombre_corto from presentaciones where nombre_corto=@nombre_corto)
raiserror('Este nombre corto ya existe',16,1)
else
insert into presentaciones values(@nombre_largo,@nombre_corto,@estado)
go

create proc sp_presentaciones_editar
@id int,
@nombre_largo varchar(50),
@nombre_corto nchar(10),
@estado int
as
if exists(select nombre_largo from presentaciones where nombre_largo=@nombre_largo and id<>@id)
raiserror('Este nombre ya existe',16,1)
else if exists(select nombre_corto from presentaciones where nombre_corto=@nombre_corto and id<>@id)
raiserror('Este nombre corto ya existe',16,1)
else
update presentaciones set
	nombre_largo = @nombre_largo,
	nombre_corto = @nombre_corto,
	estado = @estado
	where id=@id
go

create proc sp_presentaciones_eliminar
@id int
as
delete from presentaciones where id=@id
go

create proc sp_presentaciones_mostrar
@estado int
as
select * from presentaciones where estado=@estado
go
