/*
  Script de referencia — Facturacion_Cliente_Servidor
  Tablas alineadas con la segunda entrega (CRUD clientes, productos, categorías).
  Ejecutar en SQL Server Management Studio sobre la base correcta.
  Si las tablas ya existen, revisar columnas y FK antes de ejecutar bloques CREATE.
*/

SET NOCOUNT ON;

/* --- TBLCATEGORIA_PROD --- */
IF OBJECT_ID(N'dbo.TBLCATEGORIA_PROD', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.TBLCATEGORIA_PROD (
        IdCategoria        INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        StrDescripcion     VARCHAR(200) NOT NULL,
        DtmFechaModifica   DATETIME NULL,
        StrUsuarioModifico VARCHAR(100) NULL
    );
END
GO

/* --- TBLCLIENTES --- */
IF OBJECT_ID(N'dbo.TBLCLIENTES', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.TBLCLIENTES (
        IdCliente            INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        StrNombre            VARCHAR(200) NOT NULL,
        NumDocumento         BIGINT NOT NULL,
        StrDireccion         VARCHAR(300) NULL,
        StrTelefono          VARCHAR(50) NULL,
        StrEmail             VARCHAR(200) NULL,
        DtmFechaModifica     DATETIME NULL,
        StrUsuarioModifica   VARCHAR(100) NULL
    );
END
GO

/* --- TBLPRODUCTO --- */
IF OBJECT_ID(N'dbo.TBLPRODUCTO', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.TBLPRODUCTO (
        IdProducto           INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        StrNombre            VARCHAR(200) NOT NULL,
        StrCodigo            VARCHAR(50) NOT NULL,
        NumPrecioCompra      FLOAT NOT NULL DEFAULT 0,
        NumPrecioVenta       FLOAT NOT NULL DEFAULT 0,
        IdCategoria          INT NOT NULL,
        StrDetalle           VARCHAR(500) NULL,
        strFoto              VARCHAR(500) NULL,
        NumStock             INT NOT NULL DEFAULT 0,
        DtmFechaModifica     DATETIME NULL,
        StrUsuarioModifica   VARCHAR(100) NULL,
        CONSTRAINT FK_TBLPRODUCTO_CATEGORIA
            FOREIGN KEY (IdCategoria) REFERENCES dbo.TBLCATEGORIA_PROD (IdCategoria)
    );
END
GO

PRINT 'Listo. Si las tablas ya existían, no se modificaron; ajuste manualmente columnas faltantes si aplica.';
