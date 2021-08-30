use restaurante
go

create proc sp_insertar_departamentos
@descripcion varchar(50),
@colorfondo varchar(50),
@colortexto varchar(50)
as
insert into departamentos 
values(@descripcion,@colorfondo,@colortexto,1)
go

create proc sp_editar_departamentos
@id int,
@descripcion varchar(50),
@colorfondo varchar(50),
@colortexto varchar(50)
as
update departamentos set
descripcion = @descripcion,
colorfondo = @colorfondo,
colortexto = @colortexto
where id=@id
go

create proc sp_mostrar_departamentos
as
select * from departamentos
go