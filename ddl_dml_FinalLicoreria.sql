CREATE DATABASE FinalLicoreria;
GO
USE [master]
GO
CREATE LOGIN [usrfinallicoreria] WITH PASSWORD = N'123456',
 DEFAULT_DATABASE = [FinalLicoreria],
 CHECK_EXPIRATION = OFF,
 CHECK_POLICY = ON
GO
USE [FinalLicoreria]
GO
CREATE USER [usrfinallicoreria] FOR LOGIN [usrfinallicoreria]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrfinallicoreria]
GO


DROP TABLE Empleado;
DROP TABLE DetalleVenta;
DROP TABLE Venta;
DROP TABLE DetalleCompra;
DROP TABLE Producto;
DROP TABLE Categoria;
DROP TABLE Compra;
DROP TABLE Usuario;
DROP TABLE Cliente;
DROP TABLE Proveedor;


CREATE TABLE Empleado(
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  cedulaIdentidad VARCHAR(12) NOT NULL,
  nombres VARCHAR(30) NOT NULL,
  primerApellido VARCHAR(30) NULL,
  segundoApellido VARCHAR(30) NULL,
  direccion VARCHAR(250) NOT NULL,
  celular BIGINT NOT NULL,
  cargo VARCHAR(50) NOT NULL
);

CREATE TABLE Proveedor (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  documento VARCHAR(50) NOT NULL,
  razonSocial VARCHAR(50) NOT NULL,
  email VARCHAR(20) NOT NULL,
  telefono VARCHAR(8) NOT NULL,
);  

CREATE TABLE Cliente (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  documento VARCHAR(50) NOT NULL,
  nombreCompleto VARCHAR(50) NOT NULL,
  email VARCHAR(20) NOT NULL,
  telefono VARCHAR(8) NOT NULL,
); 

CREATE TABLE Usuario (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idEmpleado INT NOT NULL,
  usuario VARCHAR(15) NOT NULL,
  clave VARCHAR(250) NOT NULL,
  CONSTRAINT fk_Usuario_Empleado FOREIGN KEY (idEmpleado) REFERENCES Empleado(id)
); 


CREATE TABLE Compra (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idProveedor INT NOT NULL,
  tipoDocumento VARCHAR(50) NOT NULL,
  numeroDocumento VARCHAR(50) NOT NULL,
  montoTotal DECIMAL(10,2) NOT NULL,
  CONSTRAINT fk_Compra_Proveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor(id)
); 

CREATE TABLE Categoria (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  descripcion VARCHAR(100) NOT NULL,
);

CREATE TABLE Producto (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCategoria INT NOT NULL,
  codigo VARCHAR(50) NOT NULL,
  nombre VARCHAR(50) NOT NULL,
  descripcion VARCHAR(100) NOT NULL,
  stock INT NOT NULL DEFAULT 0,
  precioCompra DECIMAL(10,2) DEFAULT 0,
  precioVenta DECIMAL(10,2) DEFAULT 0,
  CONSTRAINT fk_Producto_Categoria FOREIGN KEY (idCategoria) REFERENCES Categoria(id)
);


CREATE TABLE DetalleCompra (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCompra INT NOT NULL,
  idProducto INT NOT NULL,
  precioCompra DECIMAL(10,2) DEFAULT 0,
  precioVenta DECIMAL(10,2) DEFAULT 0,
  cantidad INT NOT NULL,
  total DECIMAL(10,2) NOT NULL,
  CONSTRAINT fk_DetalleCompra_Compra FOREIGN KEY (idCompra) REFERENCES Compra(id),
  CONSTRAINT fk_DetalleCompra_Producto FOREIGN KEY (idProducto) REFERENCES Producto(id)
); 

CREATE TABLE Venta (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  tipoDocumento VARCHAR(50) NOT NULL,
  numeroDocumento VARCHAR(50) NOT NULL,
  documentoCliente VARCHAR(50) NOT NULL,
  nombreCliente VARCHAR(100) NOT NULL,
  montoPago DECIMAL(10,2) NOT NULL,
  montoCambio DECIMAL(10,2) NOT NULL,
  montoTotal DECIMAL(10,2) NOT NULL,
); 

CREATE TABLE DetalleVenta (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idVenta INT NOT NULL,
  idProducto INT NOT NULL,
  precioVenta DECIMAL(10,2),
  cantidad INT NOT NULL,
  subTotal DECIMAL(10,2) NOT NULL,
  CONSTRAINT fk_DetalleVenta_Venta FOREIGN KEY (idVenta) REFERENCES Venta(id),
  CONSTRAINT fk_DetalleVenta_Producto FOREIGN KEY (idProducto) REFERENCES Producto(id)
); 
  

ALTER TABLE DetalleVenta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE DetalleVenta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE DetalleVenta ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Venta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Venta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Venta ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE DetalleCompra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE DetalleCompra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE DetalleCompra ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Categoria ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Categoria ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Categoria ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Compra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Compra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Compra ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Cliente ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cliente ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cliente ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Proveedor ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Proveedor ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Proveedor ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo
GO

--INFORMACION PARA INTRODUCIR MANUALMENTE Detalle de  Negocio (Informacion )


INSERT INTO Empleado(cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES('7246545','Cristhian Vico', 'Anave', 'Llampa', 'calle Junin N°54', 77199626, 'Propietario'),
('7777777','Brayan Daniel', 'Serrudo', 'Lopez', 'san juanillo', 54656565, 'Propietario');
-- Usuario general para la defenza
INSERT INTO Empleado(cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES('11111111','Sis457', '------', '------', '------', 33333333, 'Propietario');

INSERT INTO Usuario(idEmpleado, usuario, clave)
VALUES(1, 'Vico96', 'i0hcoO/nssY6WOs9pOp5Xw=='),
(2, 'BrayanS', 'i0hcoO/nssY6WOs9pOp5Xw==');
INSERT INTO Usuario(idEmpleado, usuario, clave)
VALUES(3, 'Sis457', 'i0hcoO/nssY6WOs9pOp5Xw==');

select *from Usuario
-- Datos CATEGORIA
INSERT INTO Categoria(descripcion)
VALUES('Vinos'),
('Licores'),
('Cervezas'),
('Gaseosas'),
('Accesorios'),
('Snack'),
('Bebidas Sin Alcohol'),
('Energizantes');
-- agregue nuevos productos desde la aplicacion
--agregue nuevos clientes desde la aplicacion
--agregue nuevos proveedores desde la aplicacion

CREATE TABLE Cliente (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  documento VARCHAR(50) NOT NULL,
  nombreCompleto VARCHAR(50) NOT NULL,
  email VARCHAR(20) NOT NULL,
  telefono VARCHAR(8) NOT NULL,
); 

INSERT INTO Cliente(documento,nombreCompleto,email,telefono)
VALUES(12397423, 'Adrian Vargas Ana Rosario', 'VargasAna@gmail.com',71923957),
(12577828, 'Cabrera Medina Brandon Yamil', 'Yamil95@gmail.com', 79129291),
(12900391, 'Cruz Castro Victoria Noelia', 'Victoria@gmail.com', 70533791),
(13252264, 'Hinostroza Urquizu Kristel Evelyn', 'Evelyn@gmail.com', 71282246);

INSERT INTO Proveedor(documento,razonSocial,email,telefono)
VALUES(12418453, 'Coca Cola Ltd.', 'CocaCola@gmail.com',71503408),
(13198142, 'CBN Cerveceria Boliviana Nacional', 'CBN@gmail.com', 72018341),
(14365195, 'Vital Ltd.', 'Vital@gmail.com', 76719161),
(10357583, 'Proveedor Monsters', 'monsters@gmail.com', 70597694);

INSERT INTO Producto(documento,razonSocial,email,telefono)
VALUES(12418453, 'Coca Cola Ltd.', 'CocaCola@gmail.com',71503408),
(13198142, 'CBN Cerveceria Boliviana Nacional', 'CBN@gmail.com', 72018341),
(14365195, 'Vital Ltd.', 'Vital@gmail.com', 76719161),
(10357583, 'Proveedor Monsters', 'monsters@gmail.com', 70597694);

select *from Producto 