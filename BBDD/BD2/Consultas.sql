SELECT Factura.Numero AS 'Nº Fac', Factura.Concepto, LineasFactura.Numero AS 'Linea Factura', Producto.Nombre, Producto.Categoria, Producto.Importe, LineasFactura.Unidades
FROM Factura
INNER JOIN LineasFactura ON LineasFactura.Factura_numero = Factura.Numero
INNER JOIN Producto ON LineasFactura.Producto_Numero = Producto.Numero
ORDER BY Factura.Numero, LineasFactura.Numero ASC;

SELECT SUM(Importe) AS 'Suma', AVG(Importe) AS 'Media', max(Importe) AS 'Max', min(Importe) AS 'Min'
FROM Factura
INNER JOIN LineasFactura ON LineasFactura.Factura_numero = Factura.Numero
INNER JOIN Producto ON LineasFactura.Producto_Numero = Producto.Numero;

SELECT ROUND(SUM(LineasFactura.Unidades*Producto.Importe), 2) AS 'Importe Total', ROUND(AVG(LineasFactura.Unidades*Producto.Importe), 2) AS 'Media', ROUND(max(LineasFactura.Unidades*Producto.Importe), 2) AS 'Max', ROUND(min(LineasFactura.Unidades*Producto.Importe), 2) AS 'Min'
FROM Factura
INNER JOIN LineasFactura ON LineasFactura.Factura_numero = Factura.Numero
INNER JOIN Producto ON LineasFactura.Producto_Numero = Producto.Numero;

SELECT ROUND(SUM(Producto.Importe*LineasFactura.Unidades), 2) AS 'Importe_Total', Producto.Categoria 
FROM Factura
INNER JOIN LineasFactura ON LineasFactura.Factura_numero = Factura.Numero
INNER JOIN Producto ON LineasFactura.Producto_Numero = Producto.Numero
GROUP BY Producto.Categoria 
HAVING Producto.Categoria = 'Golosina'
AND SUM(Producto.Importe*LineasFactura.Unidades) > 10;

SELECT Factura.Numero AS 'Nº Factura', COUNT(*) AS 'Nº Linea'
FROM Factura
INNER JOIN LineasFactura ON Factura.Numero = LineasFactura.Factura_numero
INNER JOIN Producto ON Producto.Numero = LineasFactura.Producto_Numero 
GROUP BY Factura.Numero;

DROP Factura