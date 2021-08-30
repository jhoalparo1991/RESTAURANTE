use restaurante
go

create proc sp_insertar_mesas
as
declare @salon_id int
set @salon_id = (select max(salon_id) from salones)
insert into mesas values('NULO',@salon_id,'LIBRE','DISPONIBLE','MESA')
go

create proc sp_editar_mesa
@mesa_id int,
@mesa varchar(50),
@tipo varchar(50)
as
update mesas set mesa=@mesa,tipo=@tipo where mesa_id = @mesa_id
go

create view v_mesas_salones
as
select 
	m.mesa_id,
	m.mesa,
	s.salon_id,
	s.nombre,
	m.estado,
	m.disponible,
	m.tipo
from mesas m inner join salones s
on m.salon_id = s.salon_id
go

create proc sp_mostrar_mesas_por_salon
@salon_id int
as
select * from v_mesas_salones vm 
cross join configuraciones_mesas cm
where vm.salon_id = @salon_id

go