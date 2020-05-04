USE DBRestauranteMarias
GO
--Insercion de los principales datos
--Agregando Roles
insert into Acceso.Roles
	(
		nombreRol, 
		agregarUsuario,
		modificarUsuario, 
		eliminarUsuario,
		consultarUsario,
		agregarProveedor,
		modificarProveedor,
		eliminarProveedor,
		consultarProveedor,
		agregarMesero,
		modificarMesero,
		eliminarMesero,
		consultarMesero,
		anularFactura,
		aperturaCaja,
		cierreCaja  
		)
	VALUES
		(	'Administrador',
			1, 1, 1,1,1,1,1,1,1,1,1,1,1,1,1
			);
GO
INSERT INTO Acceso.Roles
	(
		nombreRol, 
		agregarUsuario,
		modificarUsuario, 
		eliminarUsuario,
		consultarUsario,
		agregarProveedor,
		modificarProveedor,
		eliminarProveedor,
		consultarProveedor,
		agregarMesero,
		modificarMesero,
		eliminarMesero,
		consultarMesero,
		anularFactura,
		aperturaCaja,
		cierreCaja  
		)
	VALUES
		(	'Usuario',
			0, 0, 0,0,1,1,1,1,0,0,0,1,0,0,0
			);

--SP_InsertarUsuario(nombre, apellido, usuario, clave, tipoArea)
EXEC SP_InsertarUsuario 'eduardo','calix','nose', 1
--Agregar Categorias 

EXEC SP_AgregarCategoriaProducto 'Licores'
EXEC SP_AgregarCategoriaProducto 'Bebidas'
EXEC SP_AgregarCategoriaProducto 'Comidas'
--Agregar Tipo productos
EXEC SP_InsertarTipoProducto 'Elaborado'
EXEC SP_InsertarTipoProducto 'Artificial'
--EXEC SP_InsertarTipoProducto 'Dieciocho'
--Agregar mesas
EXEC SP_AgregarMesa 'Mesa 1'
EXEC SP_AgregarMesa 'Mesa 2'
EXEC SP_AgregarMesa 'Mesa 3'
EXEC SP_AgregarMesa 'Mesa 4'
EXEC SP_AgregarMesa 'Mesa 5'
EXEC SP_AgregarMesa 'Mesa 6'
EXEC SP_AgregarMesa 'Mesa 7'
EXEC SP_AgregarMesa 'Mesa 8'
EXEC SP_AgregarMesa 'Mesa 9'
EXEC SP_AgregarMesa 'Mesa 10'
EXEC SP_AgregarMesa 'Mesa 11'
EXEC SP_AgregarMesa 'Mesa 12'
EXEC SP_AgregarMesa 'Mesa 13'
EXEC SP_AgregarMesa 'Mesa 14'
EXEC SP_AgregarMesa 'Mesa 15'
EXEC SP_AgregarMesa 'Mesa 16'
EXEC SP_AgregarMesa 'Mesa 17'
EXEC SP_AgregarMesa 'Mesa 18'
EXEC SP_AgregarMesa 'Mesa 19'
EXEC SP_AgregarMesa 'Mesa 20'
EXEC SP_AgregarMesa 'Mesa 21'
EXEC SP_AgregarMesa 'Mesa 22'
EXEC SP_AgregarMesa 'Mesa 23'
EXEC SP_AgregarMesa 'Mesa 24'
EXEC SP_AgregarMesa 'Mesa 25'
EXEC SP_AgregarMesa 'Mesa 26'
EXEC SP_AgregarMesa 'Mesa 27'
EXEC SP_AgregarMesa 'Mesa 28'
EXEC SP_AgregarMesa 'Mesa 29'
EXEC SP_AgregarMesa 'Mesa 30'
EXEC SP_AgregarMesa 'Mesa 31'
EXEC SP_AgregarMesa 'Mesa 32'
EXEC SP_AgregarMesa 'Mesa 33'
EXEC SP_AgregarMesa 'Mesa 34'
EXEC SP_AgregarMesa 'Mesa 35'
EXEC SP_AgregarMesa 'Mesa 36'
EXEC SP_AgregarMesa 'Mesa 37'
EXEC SP_AgregarMesa 'Mesa 38'
EXEC SP_AgregarMesa 'Mesa 39'
EXEC SP_AgregarMesa 'Mesa 40'
EXEC SP_AgregarMesa 'Mesa 41'
EXEC SP_AgregarMesa 'Mesa 42'
EXEC SP_AgregarMesa 'Mesa 43'
EXEC SP_AgregarMesa 'Mesa 44'
EXEC SP_AgregarMesa 'Mesa 45'
EXEC SP_AgregarMesa 'Mesa 46'
EXEC SP_AgregarMesa 'Mesa 47'
EXEC SP_AgregarMesa 'Mesa 48'
EXEC SP_AgregarMesa 'Mesa 49'
EXEC SP_AgregarMesa 'Mesa 50'
EXEC SP_AgregarMesa 'Mesa 51'

--SP_AgregarMesero(identidad,nombre, apellido)
EXEC SP_AgregarMesero '1111-1111-11111','Pedro','Picapiedra'
--SP_AgregarProveedor(nombre,telefono,direccion)
EXEC SP_AgregarProveedor 'Pablo Marmol','9999-9999','Piedra Dura'
-- SP_InsertarTipoUnidad(descripcion)
EXEC SP_InsertarTipoUnidad 'Libras'
EXEC SP_InsertarTipoUnidad 'Unidades'
EXEC SP_InsertarTipoUnidad 'Docena'
--SP_AgregarInsumo(nombre,costo,idTipoUnidad, descripcion,proveedor)
EXEC SP_AgregarInsumo 'tomate',10,5,1,1,'para condimentar',1
EXEC SP_AgregarInsumo 'Pescado',50,15,3,2,'de 100 lempiras',1
--SP_AgregarInventario(	descripcion,costo,precioVenta ,cantidad,cantidadMinima,idCategoria,idTipoProducto,idProveedor )

EXEC SP_AgregarInventario 'Pescado', 60, 100, 3, 1, 1, 1, 1
EXEC SP_AgregarInventario 'Fresco', 15, 20, 3, 1, 3, 2, 1
EXEC SP_AgregarInventario 'Pollo', 50, 70, 3, 1, 1, 1, 1
EXEC SP_AgregarInventario 'Chuleta', 55, 80, 3, 1, 1, 1, 1
--SP_AgregarPedido(fecha, idMesa, RTN, NombreCliente, idMesero)
--EXEC SP_AgregarPedido '28/11/2018', 5, '03181998011792', 'Norman', 1
----SP_AgregarDetallePedido(idPedido, idInventario, cantidad)
--EXEC SP_AgregarDetallePedido 1, 1, 2
----SP_AgregarFactura(idPedido, idUsuario, subTotal, descuento, exento, iva15, iva18, total)
--EXEC SP_AgregarFactura 1, 1, 1, 100, 0, 0, 10, 0, 110