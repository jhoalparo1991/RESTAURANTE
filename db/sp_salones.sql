use restaurante
go

create proc sp_insertar_salones
@nombre varchar(50)
as
insert into salones values(@nombre)
go

create proc sp_editar_salones
@salon_id int,
@nombre varchar(50)
as
update salones set
	nombre = @nombre
	where salon_id=@salon_id
go

create proc sp_eliminar_salon
@salon_id int
as
begin
	begin try
		begin tran
			delete from salones where salon_id=@salon_id
			delete from mesas where salon_id = @salon_id
		commit
	end try
	begin catch
		rollback tran
	end catch
end

go

create proc mostrar_salones
as
select * from salones
go