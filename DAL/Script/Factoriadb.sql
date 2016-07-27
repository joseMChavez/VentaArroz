use [C:\Users\jose\Documents\Visual Studio 2015\Projects\FactoriaForm\FactoriaForm\DataBase\FactoriasDb.mdf]

go

CREATE TABLE [dbo].[Cliente] (
    [ClienteId] INT          IDENTITY (1, 1) NOT NULL,
    [Nombre]    VARCHAR (30) NOT NULL,
    [Apellidos] VARCHAR (30) NOT NULL,
    [Cedula]    VARCHAR (15) NOT NULL,
    [Telefono]  VARCHAR (15) NOT NULL,
    [Email]     VARCHAR (30) NULL,
    [Direccion] VARCHAR (70) NOT NULL,
    [Fecha]     DATETIME     DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([ClienteId] ASC)
)
go
CREATE TABLE [dbo].[Factura] (
    [FactId]   INT         IDENTITY (1, 1) NOT NULL,
    [Cantidad] INT         NULL,
    [Peso]     VARCHAR (7) NULL,
    [Precio]   FLOAT (53)  NULL,
    [VentaId]  INT         NULL,
    PRIMARY KEY CLUSTERED ([FactId] ASC),
    FOREIGN KEY ([VentaId]) REFERENCES [dbo].[Venta] ([VentaId])
)
go
CREATE TABLE [dbo].[Venta] (
    [VentaId]     INT          IDENTITY (1, 1) NOT NULL,
    [Cliente]     VARCHAR (50) NULL,
    [TipoFactura] VARCHAR (10) NULL,
    [Fecha]       Date default(getDate()),
    [Total]       FLOAT (53)   NULL,
    PRIMARY KEY CLUSTERED ([VentaId] ASC)
)