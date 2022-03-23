Create Database DB_TasaCambio
use DB_TasaCambio

Create Table TasaCambio
(
	idTasa Integer  IDENTITY(1,1) NOT NULL,
	valor float,
	fecha datetime
)

Create procedure Agregar_Tasa
@valor float,
@fecha datetime
as
begin
	declare @validarfecha int
	set @validarfecha  = (select count(fecha) from TasaCambio where fecha = @fecha)
	if(@validarfecha = 0)
	begin
		insert into TasaCambio (valor, fecha)  values (@valor,@fecha) 
	end	
end
go


