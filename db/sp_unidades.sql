use restaurante
go

create proc sp_insertar_unidades
@nombre_largo varchar(50),
@nombre_corto varchar(5),
@estado int
as
insert into unidades values(@nombre_largo,@nombre_corto,@estado)
go

create proc sp_editar_unidades
@id int,
@nombre_largo varchar(50),
@nombre_corto varchar(5),
@estado int
as
update unidades set
 nombre_largo = @nombre_largo,
 nombre_corto = @nombre_corto,
 estado = @estado
 where id=@id
go

create proc sp_eliminar_unidades
@id int
as
delete from unidades where id=@id
go

create proc sp_mostrar_unidades
as
select * from unidades
go