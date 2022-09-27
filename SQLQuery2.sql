select * from Clientes
select * from Transacciones

alter table Clientes alter column Id int primary key not null identity(1,1)


-- total que se repite el cliente
select 
	idCliente,
	Count(idCliente) as total
from Transacciones
group by idCliente
having Count(*)> 1


-- datos negativos
select * from Transacciones where Transacciones.Cantidad_de_Productos <0

-- creando tercera table (falto el foreign key xd falta modificar la tabla Clientes para asignarle su primary key se me paso agregarla al importar)
create table DatosClientes(
	id int not null primary key identity,
	idCliente int not null,
	anioTrans date not null,
	totalTrans int not null,
	valorTrans decimal(18,2) not null
);

-- eliminar tercera tabla
drop table DatosClientes