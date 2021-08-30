use dbrest
go

create proc sp_departamentos_insertar
@descripcion varchar(50),
@colorfondo varchar(50),
@colortexto varchar(50),
@estado int
as
if exists(select descripcion from departamentos where descripcion=@descripcion)
raiserror('Ya existe un departamento con este nombre',16,1)
else
insert into departamentos values(
@descripcion,@colorfondo,@colortexto,@estado)
go

create proc sp_departamentos_editar
@id int,
@descripcion varchar(50),
@colorfondo varchar(50),
@colortexto varchar(50),
@estado int
as
if exists(select descripcion from departamentos 
where descripcion=@descripcion and id<>@id)
raiserror('Ya existe un departamento con este nombre',16,1)
else
update departamentos set
	descripcion = @descripcion,
	colorfondo = @colorfondo,
	colortexto = @colortexto,
	estado = @estado
	where id=@id
go

create proc  sp_departamentos_eliminar
@id int
as
delete from departamentos where id=@id
go

create proc sp_departamentos_mostrar
@estado int
as
select * from departamentos where estado=@estado
go