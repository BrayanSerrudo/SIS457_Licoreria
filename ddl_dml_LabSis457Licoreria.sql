CREATE DATABASE Labsis457licoreria;
GO
USE [master]
GO
CREATE LOGIN [usrlicoreria] WITH PASSWORD = N'123456',
 DEFAULT_DATABASE = [Labsis457licoreria],
 CHECK_EXPIRATION = OFF,
 CHECK_POLICY = ON
GO
USE [Labsis457licoreria]
GO
CREATE USER [usrlicoreria] FOR LOGIN [usrlicoreria]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrlicoreria]
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
DROP TABLE DetalleNegocio;

CREATE TABLE DetalleNegocio (
    Id INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100),
    direccion NVARCHAR(200),
    nit NVARCHAR(50)  
);


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
  idUsuario INT NOT NULL,
  idProveedor INT NOT NULL,
  tipoDocumento VARCHAR(50) NOT NULL,
  numeroDocumento VARCHAR(50) NOT NULL,
  montoTotal DECIMAL(10,2) NOT NULL,
  CONSTRAINT fk_Compra_Usuario FOREIGN KEY (idUsuario) REFERENCES Usuario(id),
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
  idUsuario INT NOT NULL,
  tipoDocumento VARCHAR(50) NOT NULL,
  numeroDocumento VARCHAR(50) NOT NULL,
  documentoCliente VARCHAR(50) NOT NULL,
  nombreCliente VARCHAR(100) NOT NULL,
  montoPago DECIMAL(10,2) NOT NULL,
  montoCambio DECIMAL(10,2) NOT NULL,
  montoTotal DECIMAL(10,2) NOT NULL,
  CONSTRAINT fk_Venta_Usuario FOREIGN KEY (idUsuario) REFERENCES Usuario(id)
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




ALTER TABLE DetalleNegocio ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE DetalleNegocio ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE DetalleNegocio ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

select* from Detallecompra;
INSERT INTO DetalleCompra(idCompra, idProducto,precioCompra,precioVenta,cantidad,total)
VALUES (5,2,2,2,4,10);
ALTER TABLE Compra
DROP COLUMN numeroFactura;
select * from Compra;


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

-- Para proveedores
-- PROCEDIMIENTO ALMACENADO PARA LISTAR PROVEEDOR
ALTER PROC paProveedorListar @parametro VARCHAR(100)
AS
  SELECT * FROM Proveedor
  WHERE estado<>-1 AND razonSocial LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
GO

EXEC paProveedorListar 'cerveza';

INSERT INTO Proveedor(documento, razonSocial, email, telefono)
VALUES ('7246542','vendo vinos','vinos@gmail.com','77199626');

INSERT INTO Proveedor(documento, razonSocial, email, telefono)
VALUES ('5056344','vendo singanis','singani@gmail.com','71703909');

INSERT INTO Proveedor(documento, razonSocial, email, telefono)
VALUES ('45453455','vendo licor','licor@gmail.com','77895396');

INSERT INTO Proveedor(documento, razonSocial, email, telefono)
VALUES ('454533232','vendo cerveza','cbn@gmail.com','77895377');

select*from Proveedor;
SELECT * FROM Proveedor WHERE razonSocial LIKE '%cerveza%'; -- cerveza

-- CLIENTE
INSERT INTO Cliente(documento, nombreCompleto, email, telefono)
VALUES ('xxxxxxxxx','Grover Anave LLampa', 'grover@gmail.com', '22222222' );
INSERT INTO Cliente(documento, nombreCompleto, email, telefono)
VALUES ('zzzzzzzzz','Maribel Anave Llampa', 'Mary@gmail.com', '3333333' );
INSERT INTO Cliente(documento, nombreCompleto, email, telefono)
VALUES ('********','Shirley Acapa Fulguera', 'Shirley@gmail.com', '4444444' );
GO

ALTER PROC paClienteListar
    @parametro VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM Cliente
    WHERE estado <> -1 AND (
        documento LIKE '%' + REPLACE(@parametro, ' ', '%') + '%' OR
        nombreCompleto LIKE '%' + REPLACE(@parametro, ' ', '%') + '%' OR
        telefono LIKE '%' + REPLACE(@parametro, ' ', '%') + '%' OR
        email LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    );
END
EXEC paClienteListar 'Acapa';

select * from Cliente;
SELECT * FROM Cliente WHERE nombreCompleto LIKE '%A%';



INSERT INTO Usuario(idEmpleado, usuario, clave)
VALUES(1, 'Jperez', 'i0hcoO/nssY6WOs9pOp5Xw==');

INSERT INTO Empleado(cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES('7246542','Juan', 'Peres', 'Lopez', 'Loa 50', 77667767, 'cajero');

SELECT * FROM Usuario;
SELECT * FROM Empleado;


-- Categoria
SELECT * FROM Categoria
INSERT INTO Categoria(descripcion)
VALUES('Licores'),
('vinos'),
('Fernets'),
('en latas'),
('Huaris');
GO
CREATE PROC paCategoriaListar @parametro VARCHAR(100)
AS
  SELECT * FROM Categoria
  WHERE estado<>-1 AND descripcion LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
GO
  EXEC paCategoriaListar 'lat';

  --producto

  SELECT*FROM Producto
  INSERT INTO Producto(codigo,idCategoria, nombre, descripcion, stock, precioCompra, precioVenta)
  VALUES('COD',2, 'leche LA LECHERA','Producto argentino',10, 50,56),
  ('COA',1, 'MONO','BOLIVIA',23, 50,5),
  ('COW',3, 'OSO','CHILE',9, 51,45);
  GO
  ALTER PROC paProductoListar @parametro VARCHAR(100)
AS
  SELECT * FROM Producto
  WHERE estado<>-1 AND nombre LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
GO
  EXEC paProductoListar 'mono';
GO
  --Empleado
  ALTER PROC paEmpleadoListar @parametro VARCHAR(50)
  AS
  SELECT e.id, e.cedulaIdentidad, nombres, ISNULL(e.primerApellido, '') AS primerApellido, 
          ISNULL(e.segundoApellido, '') AS segundoApellido , e.direccion, e.celular, e.cargo,
         ISNULL(e.usuarioRegistro, '') AS usuarioRegistro , ISNULL(e.fechaRegistro,GETDATE()) AS fechaRegistro, 
         ISNULL(u.id,0) AS idUsuario, ISNULL(u.usuario, '') as usuario
  FROM Empleado e
  LEFT JOIN Usuario u ON e.id = u.idEmpleado
  Where e.estado<>-1 
  AND e.cedulaIdentidad+e.nombres+e.primerApellido+e.segundoApellido LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
  ORDER BY e.nombres, e.primerApellido;

  EXEC paEmpleadoListar 'Juan'
  GO
  --proveedorPequeño
  ALTER PROC paProveedorPListar @parametro VARCHAR(100)
  AS SELECT p.id, p.documento, p.razonSocial FROM Proveedor p
  WHERE estado<> -1 AND p.documento LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
  ORDER BY p.razonSocial;
  GO
  EXEC paProveedorPListar '5'

  select * from Proveedor
  GO

  --productoPequeño NO VALE
  ALTER PROC paProductoPListar 
  AS SELECT pro.id, pro.codigo, pro.nombre, c.descripcion  FROM Producto pro JOIN Categoria c ON pro.idCategoria = c.id
  WHERE estado<> -1   -- p.documento LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
 -- ORDER BY p.razonSocial;
  GO

  EXEC paProductoPListar
  GO




  --procedimiento almacenado para categoria-producto                            (UTIZADO EN CRUD producto NO TOCAR)
  ALTER PROC paProductooListar @parametro VARCHAR(100)
  AS BEGIN 
  SET NOCOUNT ON;
  SELECT
        pr.id ,
        pr.codigo,
        pr.nombre,
        c.descripcion AS Categoria,
        pr.descripcion AS Descripcion,
        pr.stock,
        pr.precioCompra,
        pr.precioVenta,
        pr.usuarioRegistro,
        pr.fechaRegistro,
        pr.estado
      
  FROM Producto pr JOIN Categoria c ON pr.idCategoria = c.id
  WHERE
  pr.estado <> -1 AND (
         pr.nombre LIKE '%' + REPLACE(@parametro, ' ', '%') + '%' OR
         pr.codigo LIKE '%' + REPLACE(@parametro, ' ', '%') + '%' OR
         c.descripcion LIKE '%' + REPLACE(@parametro, ' ', '%') + '%' 
   )
END
EXEC paProductooListar 'flores'
GO






-- Formulario pequeño de Producto para compra      FUNCIONA NO TOCARRRRR
  ALTER PROC paProductoPequenoListar @parametro VARCHAR(100)    
  AS BEGIN SELECT
        pro.id ,
        pro.codigo,
        pro.nombre,
        c.descripcion AS Categoria
    
  FROM Producto pro JOIN Categoria c ON pro.idCategoria = c.id
  WHERE
  pro.estado <> -1 AND 
        (@parametro IS NULL OR pro.nombre LIKE '%' + REPLACE(@parametro, ' ', '%') + '%')
END
EXEC paProductoPequenoListar 'FLOR'
go

--- Formulario pequeño Producto v2          (FUNCIONA NO TOCARRR)
  ALTER PROC paProductoPequeListar @parametro VARCHAR(100)    
  AS SELECT prr.id, prr.codigo, prr.nombre, prr.stock, prr.precioVenta
  FROM Producto prr 
  WHERE
  prr.estado <> -1 AND prr.nombre LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
GO
EXEC paProductoPequeListar 'flor de caña' 
go

-- pequeñoCliente  funciono    NO TOCARRR
 ALTER PROC paClientePequenoListar @parametro VARCHAR(100)    
  AS SELECT cl.id, cl.documento, cl.nombreCompleto FROM Cliente cl
  WHERE estado <> -1 AND cl.nombreCompleto LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
  ORDER BY cl.nombreCompleto;
GO
EXEC paClientePequenoListar 'cristhian'
go
select * from Cliente;


select* from Compra
select*from Venta
select*from DetalleVenta





select * from usuario;
--compra

select * from DetalleCompra;
select*from Compra;
ALTER TABLE Compra
DROP CONSTRAINT fk_Compra_Usuario;

ALTER TABLE Compra
DROP Column idUsuario;


ALTER TABLE Venta
DROP Column idUsuario;
ALTER TABLE Venta
DROP CONSTRAINT fk_Venta_Usuario;



select * from DetalleNegocio
INSERT INTO DetalleNegocio(nombre, direccion, nit)
VALUES ('licoreria pedro', 'lupe', 'dsdsdasd' );
TRUNCATE TABLE DetalleNegocio;

select * from Categoria;
GO


ALTER PROCEDURE ObtenerDetallesCompras

AS
BEGIN
    SELECT 
        c.fechaRegistro,
        c.tipoDocumento,
        c.numeroDocumento,
        c.montoTotal,
        c.usuarioRegistro,
        p.documento AS documentoProveedor,
        p.razonSocial AS razonSocialProveedor,
        pr.codigo AS codigoProducto,
        pr.nombre AS nombreProducto,
        ca.descripcion AS Categoria,
        d.precioCompra,
        d.precioVenta,
        d.cantidad,
        d.total
    FROM 
        Compra c
    JOIN 
        DetalleCompra d ON c.id = d.idCompra
    JOIN 
        Proveedor p ON c.idProveedor = p.id
    JOIN 
        Producto pr ON d.idProducto = pr.id
    JOIN
        Categoria ca ON pr.idCategoria = ca.id

END
exec ObtenerDetallesCompras;


--limpieza
DELETE FROM Venta;
select * from Proveedor;

DBCC CHECKIDENT ('Producto', RESEED, 0);
DBCC CHECKIDENT ('Cliente', RESEED, 0);
DBCC CHECKIDENT ('DetalleCompra', RESEED, 0);
DBCC CHECKIDENT ('Compra', RESEED, 0);
DBCC CHECKIDENT ('Proveedor', RESEED, 0);
DBCC CHECKIDENT ('Categoria', RESEED, 0);
DBCC CHECKIDENT ('DetalleVenta', RESEED, 0);
DBCC CHECKIDENT ('Venta', RESEED, 0);


