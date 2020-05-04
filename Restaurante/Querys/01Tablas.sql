/*Base de datos para Restaurante especialidades Las Marias #3*/

IF EXISTS(SELECT * FROM DBO.SYSDATABASES WHERE NAME = 'DBRestauranteMarias')
    BEGIN
		USE MASTER
        DROP DATABASE DBRestauranteMarias 
    END
GO

CREATE DATABASE DBRestauranteMarias
GO

USE DBRestauranteMarias
GO

CREATE SCHEMA Restaurante --contiene todas las tablas del sistemas
GO

CREATE SCHEMA Utilidad --contiene las funciones que realizaremos
GO

CREATE SCHEMA Acceso --Contiene la informacion de acceso de los usuarios
GO

/*
	contiene todos los usuarios que manejaran el sistema en las diferentes
	areas del restaurante, teniendo acceso solo a lo pertinente segun sea
	es tipo de idArea de esa seccion

	esta tabla es manejada solo por el administrador principal
*/
IF OBJECT_ID('Acceso.Usuarios')	IS NOT NULL
	DROP TABLE Acceso.Usuarios
ELSE
	BEGIN
		CREATE TABLE Acceso.Usuarios(
			id  INT IDENTITY (1,1) NOT NULL, --index de los usuarios
			nombre NVARCHAR(25) NOT NULL,	--primer nombre del usuario
			apellido NVARCHAR(25) NOT NULL, --primer apellido del usuario
			usuario NVARCHAR(26) NOT NULL,	--Primera letra del nombre en mayusculas más el apellido
									--eje: Pedro Picapiedra (PPicapiedra)
			clave NVARCHAR(20) NOT NULL, --clave de acceso
			idRol INT  NOT NULL,--codigo del area de trabajo a la cual pertenece
			estado BIT DEFAULT 1
		);
	END
GO

/*
	esta tabla controlara los modulos que seran disponibles por cada departamento
*/
IF OBJECT_ID('Acceso.Roles')	IS NOT NULL
	DROP TABLE Acceso.Roles
ELSE
	BEGIN
		CREATE TABLE Acceso.Roles(
			id INT IDENTITY (1,1) NOT NULL,
			nombreRol NVARCHAR(20),
			agregarUsuario BIT,
			modificarUsuario BIT,
			eliminarUsuario BIT,
			consultarUsario BIT,
			agregarProveedor BIT,
			modificarProveedor BIT,
			eliminarProveedor BIT,
			consultarProveedor BIT,
			agregarMesero BIT,
			modificarMesero BIT,
			eliminarMesero BIT,
			consultarMesero BIT,
			anularFactura BIT,
			aperturaCaja BIT,
			cierreCaja BIT
			

			/*
				falta colorcar los campos de los modulos a los cuales tendra acceso
			*/
		);
	END
GO



/*
	cada area tiene relacionadas cierta cantidad de mesas que 
	van insertadas en esta tabla
*/
IF OBJECT_ID('Restaurante.Mesas')	IS NOT NULL
	DROP TABLE Restaurante.Mesas
ELSE
	BEGIN
		CREATE TABLE Restaurante.Mesas(
			id INT IDENTITY (1, 1) NOT NULL, --index de las mesas
			estado NVARCHAR(21) NOT NULL --estados que puede tener una mesa
								--libre, ocupado, reservado, saliendo
		);
	END
GO





/*
	contiene la informacion de las personas que serviran la comida
*/
IF OBJECT_ID('Restaurante.Meseros')	IS NOT NULL
	DROP TABLE Restaurante.Meseros
ELSE
	BEGIN
		CREATE TABLE Restaurante.Meseros(
			id INT IDENTITY(1,10) NOT NULL,		--index del mesero
			identidad NVARCHAR(15) NOT NULL,	--identidad del mesero con formato (9999-9999-99999)	
			nombre NVARCHAR (25) NOT NULL,			--primer nombre
			apellido NVARCHAR (25) NOT NULL,			--primer apellido
			estado BIT DEFAULT 1
		);
	END
GO

/*
	contienen los pedidos que se van generando,
	a que mesa se dirige el pedido y el mesero que 
	los esta atendiendo
*/
IF OBJECT_ID('Restaurante.Pedidos')	IS NOT NULL
	DROP TABLE Restaurante.Pedidos
ELSE
	BEGIN
		CREATE TABLE Restaurante.Pedidos(
			id INT IDENTITY (1, 1) NOT NULL,					--index del pedido
			Fecha NVARCHAR(19) NOT NULL,						--fecha y hora en la que se realizo el pedido 
			idMesa INT NOT NULL,							--identificador de la mesa donde se entregara el pedido
			RTN NVARCHAR(14),							--RTN del cliente
			NombreCliente NVARCHAR (50),					--nombre de la persona que realizo el pedido
			idMesero INT NOT NULL,							--identificador del mesero que atendera la mesa
			estado INT DEFAULT 1
		);
	END
GO

IF OBJECT_ID('Restaurante.Facturas')	IS NOT NULL
	DROP TABLE Restaurante.Facturas
ELSE
	BEGIN
		CREATE TABLE Restaurante.Facturas(
			idFactura INT IDENTITY(1,1) NOT NULL,
			idCaja INT NOT NULL,
			idPedido INT NOT NULL,
			idUsuario INT NOT NULL,
			descuento DECIMAL(6,2),
			exento DECIMAL(6,2),
			iva15 DECIMAL(6,2),
			iva18 DECIMAL(6,2),
			total DECIMAL (8,2)NOT NULL,
			estado INT DEFAULT 1,
			tipoPago INT NOT NULL,
			subTotal DECIMAL (8,2)
		);
	END
GO

IF OBJECT_ID('Restaurante.DetallePedidos')	IS NOT NULL
	DROP TABLE Restaurante.DetallePedidos
ELSE
	BEGIN
		CREATE TABLE Restaurante.DetallePedidos(
			idDetallePedido INT IDENTITY (1,1) NOT NULL,
			idPedido INT NOT NULL,
			idInventario INT NOT NULL,
			cantidad INT NOT NULL,
			subTotal DECIMAL(6,2) NOT NULL,
			estado int DEFAULT 1

		);
	END
GO

IF OBJECT_ID('Restaurante.Inventario')	IS NOT NULL
	DROP TABLE Restaurante.Inventario
ELSE
	BEGIN
		CREATE TABLE Restaurante.Inventario(
			idInventario INT IDENTITY NOT NULL,
			descripcion	NVARCHAR(100) NOT NULL,
			costo DECIMAL(8,2) NOT NULL,
			precioVenta DECIMAL(8,2) NOT NULL,
			cantidad DECIMAL(8,2) NOT NULL,
			cantidadMinima DECIMAL(8,2) NOT NULL,
			idCategoria INT NOT NULL,
			idTipoProducto INT NOT NULL,
			idProveedor INT NULL,
			estado BIT DEFAULT 1
		);
	END
GO

IF OBJECT_ID('Restaurante.Insumos')	IS NOT NULL
	DROP TABLE Restaurante.Insumos
ELSE
	BEGIN
		CREATE TABLE Restaurante.Insumos(
			idInsumo INT IDENTITY NOT NULL,
			nombre NVARCHAR(100) NOT NULL,
			costo DECIMAL(8,2) NOT NULL,
			cantidad DECIMAL(8,2) NOT NULL,
			cantidadMinima DECIMAL(8,2) NOT NULL,
			idTipoUnidad INT NOT NULL,
			descripcion NVARCHAR(200) NOT NULL,
			idProveedor INT,
			estado BIT DEFAULT 1
		);
	END
GO

IF OBJECT_ID('Restaurante.Proveedores')	IS NOT NULL
	DROP TABLE Restaurante.Proveedores
ELSE
	BEGIN
		CREATE TABLE Restaurante.Proveedores(
			idProveedor INT IDENTITY NOT NULL,
			nombre NVARCHAR(100) NOT NULL,
			telefono NVARCHAR(9) NOT NULL,
			direccion NVARCHAR(300),
			estado BIT DEFAULT 1
		);
	END
GO

IF OBJECT_ID('Restaurante.TipoUnidad')	IS NOT NULL
	DROP TABLE Restaurante.TipoUnidad
ELSE
	BEGIN
		CREATE TABLE Restaurante.TipoUnidad(
			idTipoUnidad INT IDENTITY NOT NULL,
			descripcion NVARCHAR(100),
			estado BIT DEFAULT 1
		);
	END
GO

IF OBJECT_ID('Restaurante.TipoProducto')	IS NOT NULL
	DROP TABLE Restaurante.TipoProducto
ELSE
	BEGIN
		CREATE TABLE Restaurante.TipoProducto(
			idTipoProducto INT IDENTITY NOT NULL,
			nombre NVARCHAR(100),
			estado BIT DEFAULT 1
		);
	END
GO

IF OBJECT_ID('Restaurante.InsumosProductos')	IS NOT NULL
	DROP TABLE Restaurante.InsumosProductos
ELSE
	BEGIN
		CREATE TABLE Restaurante.InsumosProductos(
			idInsumoProducto INT IDENTITY(1,1) NOT NULL,
			idInsumo INT NOT NULL,
			idInventario INT NOT NULL,
			cantidad DECIMAL(8,2) NOT NULL,
			estado BIT DEFAULT 1
		);
	END
GO

IF OBJECT_ID('Restaurante.CategoriaProducto')	IS NOT NULL
	DROP TABLE Restaurante.CategoriaProducto
ELSE
	BEGIN
		CREATE TABLE Restaurante.CategoriaProducto(
			idCategoria INT IDENTITY NOT NULL,
			descripcion NVARCHAR(100),
			estado BIT DEFAULT 1

		);
	END
GO

IF OBJECT_ID('Restaurante.Caja')	IS NOT NULL
	DROP TABLE Restaurante.Caja
ELSE
	BEGIN
		CREATE TABLE Restaurante.Caja(
			id INT IDENTITY NOT NULL,
			dolares DECIMAL NOT NULL,
			POS DECIMAL NOT NULL,
			quinientos INT NOT NULL,
			cien INT NOT NULL,
			cincuenta INT NOT NULL,
			veinte INT NOT NULL,
			diez INT NOT NULL,
			cinco  INT NOT NULL,
			dos INT NOT NULL, 
			uno INT NOT NULL,
			fecha DATETIME NOT NULL,
			idDetalleCaja INT NOT NULL,
			Monto DECIMAL NOT NULL,
			Usuario NVARCHAR(20) NOT NULL
		);
	END
GO

IF OBJECT_ID('Restaurante.ServicioPublico')	IS NOT NULL
	DROP TABLE Restaurante.ServicioPublico
ELSE
	BEGIN
		CREATE TABLE Restaurante.ServicioPublico
		(
			id INT IDENTITY(1,1) NOT NULL,
			Descripcion NVARCHAR(30) NOT NULL
		)
	END
GO

IF OBJECT_ID('Restaurante.DetalleServicioPublico')	IS NOT NULL
	DROP TABLE Restaurante.DetalleServicioPublico
ELSE
	BEGIN
		CREATE TABLE Restaurante.DetalleServicioPublico
		(
			id INT IDENTITY(1,1) NOT NULL,
			Monto DECIMAL(18,0) NOT NULL,
			Fecha DATETIME NOT NULL,
			Usuario NVARCHAR(20) NOT NULL,
			idServicioPublico INT NOT NULL
		);
	END
GO

IF OBJECT_ID('Restaurante.OtrasSalidas')	IS NOT NULL
	DROP TABLE Restaurante.OtrasSalidas
ELSE
	BEGIN
		CREATE TABLE Restaurante.OtrasSalidas
		(
			id INT IDENTITY(1,1) NOT NULL,
			Descripcion NVARCHAR(30) NOT NULL,
			Monto NVARCHAR(200) NOT NULL,
			Fecha DATETIME NOT NULL,
			Usuario NVARCHAR(20) NOT NULL
		)
	END
GO

IF OBJECT_ID('Restaurante.DetalleCaja')	IS NOT NULL
	DROP TABLE Restaurante.DetalleCaja
ELSE
	BEGIN
		CREATE TABLE Restaurante.DetalleCaja
		(
			id int IDENTITY(1,1) NOT NULL,
			Descripcion varchar(20) NOT NULL
		)
	END
GO