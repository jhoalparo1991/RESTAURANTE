use dbrest
go

create proc sp_vendedores_insertar
@nombres varchar(50),
@apellidos varchar(50),
@documento varchar(20),
@nombre_corto varchar(20),
@sexo varchar(20),
@ciudad varchar(50),
@direccion varchar(50),
@barrio varchar(50),
@telefono varchar(20),
@celular varchar(20),
@correo varchar(100),
@foto image,
@clave varchar(50),
@fecha_nac nchar(10),
@salario_base money,
@comision money,
@estado int,
@login int,
@rol_id int
as
if exists(select documento from vendedores where documento=@documento)
raiserror('Ya existe un vendedor con este documento',16,1)
else
insert into vendedores values
(
@nombres,
@apellidos,
@documento,
@nombre_corto,
@sexo,
@ciudad,
@direccion,
@barrio,
@telefono,
@celular,
@correo,
@foto,
@clave,
@fecha_nac,
@salario_base,
@comision,
@estado,
@login,
@rol_id
)
go

create proc sp_vendedores_editar
@id int,
@nombres varchar(50),
@apellidos varchar(50),
@documento varchar(20),
@nombre_corto varchar(20),
@sexo varchar(20),
@ciudad varchar(50),
@direccion varchar(50),
@barrio varchar(50),
@telefono varchar(20),
@celular varchar(20),
@correo varchar(100),
@foto image,
@clave varchar(50),
@fecha_nac nchar(10),
@salario_base money,
@comision money,
@estado int,
@rol_id int
as
if exists(select documento from vendedores 
where documento=@documento and id<>@id)
raiserror('Ya existe un vendedor con este documento',16,1)
else
update vendedores
set
nombres=@nombres,
apellidos=@apellidos,
documento=@documento,
nombre_corto=@nombre_corto,
sexo=@sexo,
ciudad=@ciudad,
direccion=@direccion,
barrio=@barrio,
telefono=@telefono,
celular=@celular,
correo=@correo,
foto=@foto,
clave=@clave,
fecha_nac=@fecha_nac,
salario_base=@salario_base,
comision=@comision,
estado=@estado,
rol_id=@rol_id

go

create view v_vendedores
as
select 
	v.id,
	v.nombres,
	v.apellidos,
	v.documento,
	v.nombre_corto,
	v.sexo,
	v.ciudad,
	v.direccion,
	v.barrio,
	v.telefono,
	v.celular,
	v.correo,
	v.foto,
	v.clave,
	v.fecha_nac,
	v.salario_base,
	v.comision,
	v.salario_neto,
	v.estado,
	v.login,
	r.id as rol_id,
	r.descripcion as roles
from vendedores as v inner join roles as r
on v.rol_id = r.id
go

create proc sp_vendedores_mostrar
@estado int,
@buscar varchar(20)
as
select * from v_vendedores as vv 
where vv.estado = @estado and vv.nombres+vv.apellidos like
 '%'+@buscar+'%'

go

create proc sp_vendedores_eliminar
@id int
as
delete from vendedores where id=@id

go

