/*DML: Data Manipulation Language, son instrucciones
que permiten manipular los registros almacenados
en las tablas de la base de datos.
Las instrucciones mas populares son:
SELECT, INSERT, UPDATE, DELETE

-> Las instrucciones DML no requieren del uso de GO, pero
   si Usted quiere separarlas por lotes puede usar GO.*/
--Importante: siempre seleccione la BD en la que va a trabajar
USE Gerardo
GO

/*Instruccion INSERT
agrega registros a una tabla, consideraciones:
1) El INSERT debe incluir todos los campos/columnas que sean NOT NULL (los obligatorios
2) Los campos NULL son opciones, Ustedes deciden si los ponen en su INSERT
3) Si hay una columna IDENTITY esas no se incluyen en el INSERT, ya que estas son
   autonumeradas por la base de datos.
*/
--INSERT que llena todas las columnas de un registro en la tabla Producto
USE Gerardo
GO

INSERT Producto(Codigo,Nombre,Costo,PrecioVenta,Existencias,Observaciones)
VALUES('CC01','Coca Cola 3L',45,65,100,'Mala para la salud')

INSERT Producto(Codigo,Nombre,Costo,PrecioVenta,Existencias,Observaciones)
VALUES('CC02','Pepsi Cola 3L',42.5,64,80,'Tambien es mala para la salud')

--INSERT no necesita mencionar las columnas en el mismo orden que estan en la tabla
INSERT Producto(Nombre,Costo,PrecioVenta,Codigo,Observaciones,Existencias)
VALUES('Mirinda Uva 2L',25,36,'CC03','Otro que es malo para la salud',15)

--INSERT sin incluir el campo opcional llamado Observaciones (admite NULL)
INSERT Producto(Codigo,Nombre,Costo,PrecioVenta,Existencias)
VALUES('CH01','Ranchita pequeña',10,14,50)

--INSERT Multiregistro:
INSERT Producto(Codigo,Nombre,Costo,PrecioVenta,Existencias,Observaciones)
VALUES
('FR99','Pera Unidad',6.25,8,100,'Buena para la salud'),
('FR43','Manzana Unidad',7.36,9,200,'Muy buena para la salud'),
('HR01','Lechuga Romana Unidad',15.67,23,90,'Buena para la ensalada'),
('CH99','Doritos Flaming Hot Grande',32,48,90,NULL),
('CH46','Taqueritos Fuego Grande',24,50.26,45,NULL),
('CC90','Bolsa con Agua Arroyo',2.5,4,500,'El agua es buena para la salud')

USE Gerardo
GO

/*Instruccion SELECT
Consulta los registros almacenados en una tabla.
Su resultado va a depender de la clausulas que le coloquemos.*/

--Muestra todos los registros y todas las columnas de una tabla
SELECT * FROM Producto
/*Importante: a nivel de produccion, el uso de SELECT * no se considera
una buena práctica.
Cuando ya dedica crear consultas que van a usarse en entorno de produccion lo mas
recomendado es colocar los nombres de las columnas que desea en su consulta.
El usar * en SELECT lo que hace es ponerle mas trabajo al servidor de BD
porque lo obliga a ir a revisar el catalogo de columnas de la tabla.*/

--El produccion debe Usted desglosar las columnas que necesita en la consulta:
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Observaciones
FROM Producto

--Si solo necesita ciertas columnas, entonces solo las coloca
SELECT Codigo, Nombre, PrecioVenta
FROM Producto

--Mostrar todas las columnas para el producto que tenga codigo CC03
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Observaciones
FROM Producto
WHERE Codigo = 'CC03'

--Mostrar todas las columnas para el producto con ProductoID igual a 7
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Observaciones
FROM Producto
WHERE ProductoID = 7

--Listas de seleccion
----Mostrar todas las columnas para los productos con codigo CC01, CH01, FR43
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Observaciones
FROM Producto
WHERE Codigo IN('CC01','CH01','FR43')

----Mostrar todas las columnas para los productos cuyo ProductoID sea 1,5,4,8,10
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Observaciones
FROM Producto
WHERE ProductoID IN(1,5,4,8,10)

--Listas de exclusion
--Son como una lista de seleccion pero INVERSA
----Mostrar todas las columnas para los productos cuyo codigo NO SEA CH1 y CC03
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Observaciones
FROM Producto
WHERE Codigo NOT IN('CH01','CC03')

--puede tambien usar los operadores de comparacion de toda la vida
-- >= > <= <
-- = (igual) <> (distinto de)
----Mostrar todas las columnas para los productos con costo menor o igual a 20
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Observaciones
FROM Producto
WHERE Costo <= 20

----Mostrar todas las columnas para los productos con existencias mayores a 100
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Observaciones
FROM Producto
WHERE Existencias > 100

--Tambien existen los operadores AND OR
----Mostrar todas las columnas para los productos con costo <= 30 Y Existencias >= 100
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Observaciones
FROM Producto
WHERE Costo <= 30 AND Existencias >= 100

----Mostrar todas las columnas para los productos con codigo CC01 Ó CC02
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Observaciones
FROM Producto
WHERE Codigo = 'CC01' OR Codigo = 'CC02'

--existen gran cantidad de clausulas y modificadores para SELECT; pero eso
--lo va a estudiar mas a fondo en sus clases de Base de Datos
--por ejemplo el operador BETWEEN, que permite obtener valores dentro de un
--rango similar a usar AND
--Mostrar todas las columnas para los productos con PrecioVenta mayor o igual a 30
-- Y con PrecioVenta menor o igual a 100
SELECT ProductoID, Codigo, Nombre, Costo, PrecioVenta, Existencias, Observaciones
FROM Producto
WHERE PrecioVenta BETWEEN 30 AND 100

/*Instruccion DELETE
Elimina uno o varios registros de una tabla dependiendo de la clausula WHERE utilizada.
Consideraciones:
1) DELETE no altera la numeracion del campo IDENTITY
2) Se recomienda antes de lanzar DELETE realizar un SELECT para hacer una vista
   previa de los registros que pretende borrar.
3) Si alguno de los registros a eliminar esta asociado con otra tabla por medio
   de una llave FORANEA entonces este no será eliminado.*/

--Borrar todos los registros de una tabla
--A diferencia de TRUNCATE, DELETE no les va a reiniciar el campo IDENTITY
USE Gerardo --importante seleccione la BD
GO

SELECT * FROM Producto --Vista Previa
DELETE FROM Producto --Eliminar todos los registros de la tabla

--TRUNCATE: vacia la tabla y reinicia el campo IDENTITY
TRUNCATE TABLE Producto
GO

--Eliminar todos los productos cuyo Costo sea menor o igual a 15
--Vista previa:
SELECT *
FROM Producto
WHERE Costo <= 15
--Eliminacion
USE Gerardo
GO
DELETE FROM Producto
WHERE Costo <= 15

--El WHERE usando en DELETE es el mismo WHERE usando en SELECT

--Elimnar el producto con Codigo CC02
--Vista Previa
SELECT *
FROM Producto
WHERE Codigo = 'CC02'
--Eliminacion
USE Gerardo
GO
DELETE FROM Producto
WHERE Codigo = 'CC02'

/*Instruccion UPDATE
Modifica uno o varios registros de una tabla.
Consideraciones:
1) Se recomienda combinarlo con WHERE
2) Al igual que con DELETE se recomienda hacer una vista previa antes de realizar los cambios*/

--Colocar en CERO las existencias para el producto con Codigo HR01
--Vista Previa
SELECT *
FROM Producto
WHERE Codigo =  'HR01'
--Actualizacion:
USE Gerardo
GO
UPDATE Producto
SET Existencias = 0
WHERE Codigo =  'HR01'

--Colocar en 500 las existencias para los productos con codigo CC01 y HR01
--Vista Previa
SELECT *
FROM Producto
WHERE Codigo IN ('CC01','HR01')
--Actualizacion:
USE Gerardo
GO
UPDATE Producto
SET Existencias = 500
WHERE Codigo IN ('CC01','HR01')

--Tambien pueden afectar varias columnas a la vez
--Coloque el Costo en 10 y las existencias en 100 para todos los productos cuyo Codigo sea CH46 y CC03
--Vista Previa
SELECT *
FROM Producto
WHERE Codigo IN ('CH46','CC03')
--Actualizacion:
USE Gerardo
GO
UPDATE Producto
SET Costo = 10, Existencias = 100
WHERE Codigo IN ('CH46','CC03')

--Tambien puede aplicar formulas a su UPDATE
--Aumentar un 10% el precio de venta de todos los productos
--Vista Previa
SELECT *
FROM Producto --no lleva WHERE porque va a aplicarse a todos los productos
--Actualizacion:
USE Gerardo
GO
UPDATE Producto
SET PrecioVenta = PrecioVenta*1.10