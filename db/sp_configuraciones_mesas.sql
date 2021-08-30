use restaurante
go

create proc sp_aumentar_tamanio_mesa
as
update configuraciones_mesas set
tamanio_mesa = (tamanio_mesa + 2)
go

create proc sp_disminuir_tamanio_mesa
as
update configuraciones_mesas set
tamanio_mesa = (tamanio_mesa - 2)
go

create proc sp_aumentar_tamanio_fuente
as
update configuraciones_mesas set
tamanio_fuente = (tamanio_fuente + 1)
go

create proc sp_disminuir_tamanio_fuente
as
update configuraciones_mesas set
tamanio_fuente = (tamanio_fuente - 1)
go