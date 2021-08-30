use restaurante
go

create proc sp_insertar_marcas
@nombre as varchar(50)
as
insert into marcas values(@nombre,1)
go

create proc sp_editar_marcas
@id int,
@nombre as varchar(50)
as
update marcas set nombre = @nombre where id=@id
go

create proc sp_eliminar_marcas
@id int
as
delete from marcas where id=@id
go

create proc sp_mostrar_marcas
as
select * from marcas
go