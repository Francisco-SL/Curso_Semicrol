CREATE TABLE [Factura] (
	Numero int NOT NULL,
	Concepto nvarchar(25) NOT NULL,
  CONSTRAINT [PK_FACTURA] PRIMARY KEY CLUSTERED
  (
  [Numero] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [LineasFactura] (
	Numero int NOT NULL,
	Factura_numero int NOT NULL,
	Producto_Numero nvarchar NOT NULL,
	Unidades int NOT NULL,
  CONSTRAINT [PK_LINEASFACTURA] PRIMARY KEY CLUSTERED
  (
  [Numero] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Producto] (
	Numero nvarchar NOT NULL,
	Nombre nvarchar(25) NOT NULL,
	Importe float NOT NULL,
	Categoria nvarchar(25) NOT NULL,
  CONSTRAINT [PK_PRODUCTO] PRIMARY KEY CLUSTERED
  (
  [Numero] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

ALTER TABLE [LineasFactura] WITH CHECK ADD CONSTRAINT [LineasFactura_fk0] FOREIGN KEY ([Factura_numero]) REFERENCES [Factura]([Numero])
ON UPDATE CASCADE
GO
ALTER TABLE [LineasFactura] CHECK CONSTRAINT [LineasFactura_fk0]
GO
ALTER TABLE [LineasFactura] WITH CHECK ADD CONSTRAINT [LineasFactura_fk1] FOREIGN KEY ([Producto_Numero]) REFERENCES [Producto]([Numero])
ON UPDATE CASCADE
GO
ALTER TABLE [LineasFactura] CHECK CONSTRAINT [LineasFactura_fk1]
GO


