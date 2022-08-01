-- @block Comprobar la tabla
SELECT * FROM tabla_clientes;

-- SELECT nombre FROM clientes; --

--SELECT telefono, primer_apellido FROM clientes;--

-- La extensión de SQL Tools permite separar en bloques con @block

--@block Seleccionar todo
/*
SELECT 
    nombre,
    primer_apellido,
    segundo_apellido,
    telefono
FROM clientes
WHERE nombre LIKE '%a' AND primer_apellido LIKE 'A%' AND segundo_apellido LIKE '%d';
    --importe_total_de_pedidos < 1000 AND nombre = 'Kendal'; --
*/

---

-- @block Seleccionar solo los nombres
SELECT * FROM tabla_clientes;

-- @block Seleccionar los teléfonos que son "Remposable de Ventas" o "Comercial"
SELECT
    telefono
FROM
    tabla_clientes
WHERE
    cargo = 'Responsable de Ventas' OR cargo = 'Comercial';

-- @block clientes que pertenezcan a la empresa syer
-- y no han sido contactados desde el 1 de junio de 2019
SELECT 
    *
FROM
    tabla_clientes
WHERE
    empresa = 'syer' AND
    ultima_vez_contactado < '2019-06-01';

-- @block clientes cuya provincia es Mardid o Barcelona
SELECT 
    *
FROM
    tabla_clientes
WHERE
    provincia = 'Madrid' OR
    provincia = 'Barcelona';

-- @block Obtener el teléfono de un cliente. Creo que el nombre empezaba por C 
-- y su dirección contiene "Rosas"
SELECT
    nombre, telefono
FROM
    tabla_clientes
WHERE
    nombre LIKE 'C%' AND
    direccion LIKE '%Rosas%';

-- @block Clientes con nombre o apellido empezando por la letra L
SELECT
    *
FROM
    tabla_clientes
WHERE
    nombre LIKE 'L%' OR
    primer_apellido LIKE 'L%' OR
    segundo_apellido LIKE 'L%';

-- @block por la letra L y que han pedido menos de 500.00€
SELECT
    *
FROM
    tabla_clientes
WHERE
    (nombre LIKE 'L%' OR
    primer_apellido LIKE 'L%' OR
    segundo_apellido LIKE 'L%') AND
    importe_total_de_pedidos < 500.00;

-- @block Obtener los primeros 5 clientes ordenados por nombre
SELECT
    *
FROM
    tabla_clientes
ORDER BY nombre
LIMIT 5
OFFSET 0;

-- @block Todas las empresas
SELECT DISTINCT empresa FROM tabla_clientes;

-- @block Todas las provincias con clientes
SELECT DISTINCT
    provincia
FROM
    tabla_clientes
WHERE
    importe_total_de_pedidos > 5000;

-- @block 10 personas con mayor importe de pedidos
SELECT
    *
FROM
    tabla_clientes
ORDER BY importe_total_de_pedidos DESC
LIMIT 10;

-- @block 10 epersonas con mayor importe de pedidos
SELECT
    concat(
        nombre, ' ', primer_apellido, ' ', segundo_apellido
    ) AS "Nombre completo",
    importe_total_de_pedidos
FROM
    tabla_clientes
ORDER BY importe_total_de_pedidos DESC
LIMIT 10;

-- @block número de clientes en cada provincia
SELECT
    provincia,
    COUNT(*)
FROM
    tabla_clientes
GROUP BY provincia;

-- @block Media de gasto por provincia
SELECT
    provincia,
    COUNT(*),
    AVG(importe_total_de_pedidos)
FROM
    tabla_clientes
GROUP BY provincia;


-- @block 
SELECT
    provincia AS "Provincias totales",
    sum(importe_total_de_pedidos) as "Pedidos totales",
    CAST(AVG(importe_total_de_pedidos) AS NUMERIC(8, 2)) AS "Media de pedidos"
FROM
    tabla_clientes
GROUP BY provincia;

-- @block
SELECT
    concat(nombre, ' ', primer_apellido, ' ', segundo_apellido, ' ' ) AS "Nombre completo",
    importe_total_de_pedidos / pedidos AS "Media del improte"
FROM
    tabla_clientes;

-- @block
SELECT
    AGE(current_date, fecha_de_nacimiento) AS "Edad"
FROM
    tabla_clientes;

-- @block Buscar a la persona que hace más tiempo que no se contacta
-- y mostrar el tiempo y su corre electrónico
SELECT 
    nombre, 
    correo_electronico,
    AGE(current_date, ultima_vez_contactado) AS "Tiempo desde último contacto"
FROM
    tabla_clientes
ORDER BY ultima_vez_contactado ASC
LIMIT 1;    

-- @block Calcular una comisión del 10% para cada cliente sobre los pedidos totales
SELECT
    nombre,
    importe_total_de_pedidos,
    ROUND(importe_total_de_pedidos * 0.1, 2) AS "Comisión del 10%"
FROM
    tabla_clientes;


-- @block Calcular el total de las comisiones del 10% para las ventas realizadas en Madrid
SELECT
    provincia,
    SUM(ROUND(importe_total_de_pedidos * 0.1, 2)) AS "Comisión del 10%"
FROM
    tabla_clientes
WHERE provincia = 'Madrid'
GROUP BY provincia;


-- @block total de ventas a serize en Baleares
SELECT
    SUM(importe_total_de_pedidos)
FROM
    tabla_clientes
WHERE
    provincia = 'Baleares' AND
    empresa = 'forize'
GROUP BY
    empresa;

-- @block número de pedidos realizados desde Canarias (Santa Cruz de Tenerife y Las Palmas)
SELECT 
    sum(pedidos)
FROM
    tabla_clientes
WHERE
    provincia = 'Santa Cruz de Tenerife' OR
    provincia = 'Las Palmas';

-- @block media de pedidos realizados por provincia
SELECT
    provincia as "Provincia", ROUND(AVG(pedidos), 2) as "Media de pedidos por provincia"
FROM
    tabla_clientes
GROUP BY provincia
ORDER BY provincia DESC

-- @block consultas para mostrar las primeras 5 páginas de 10 resultados de la tabla 
SELECT * FROM tabla_clientes LIMIT 10 OFFSET 0;

SELECT * FROM tabla_clientes LIMIT 10 OFFSET 10;

SELECT * FROM tabla_clientes LIMIT 10 OFFSET 20;

SELECT * FROM tabla_clientes LIMIT 10 OFFSET 30;

SELECT * FROM tabla_clientes LIMIT 10 OFFSET 40;

-- Esto se hacec para guradar en una variable? Por qué no se guarda direcatamente en un ARRAY

-- @block obtner la lista de clientes que vive en un ático
SELECT * FROM tabla_clientes
WHERE direccion LIKE '%Ático%';

-- @block borrar clientes que tenga N/A en clientes
DELETE FROM tabla_clientes
WHERE provincia = '#N/A';

-- @block Actualizar la fecha del último contacto de todos los clientes de la empresa laudism a CURRENT_DATE
UPDATE tabla_clientes
SET ultima_vez_contactado = current_date
WHERE empresa = 'laudism';

-- @block pemnas@susise.com ha hecho un pedido nuevo actualizar
UPDATE tabla_clientes
SET pedidos = pedidos + 1,
    importe_total_de_pedidos = importe_total_de_pedidos + 1
WHERE correo_electronico = 'pmenas@susise.com';

-- @block Ver resultado
SELECT correo_electronico, pedidos, importe_total_de_pedidos FROM tabla_clientes
WHERE correo_electronico = 'pmenas@susise.com';

-- @block Ha caído un meteorio en Soria. Borrar todos los clientes que viven en el área afectada.
delete from tabla_clientes
where provincia = 'Soria';

select nombre, provincia from tabla_clientes;

-- @block Carlos Rodrigo Falcón ha sido ascendido. Ahora es Director Comercial en sugoid. Actualizar el registro
UPDATE tabla_clientes
SET cargo = 'Director Comercial'
WHERE nombre LIKE 'Carlos' AND
      primer_apellido = 'Rodrigo' AND
      segundo_apellido = 'Falcón';

-- @block Angélica de la empresa lunise ahora trabaja en malend como Responsable de Ventas. Nos hemos enterado en un mail del día 1 de octubre de 2020.
-- Además se ha mudado a al Calle Falsa, 123, Santa Cruz de Tenerife, Santa Cruz de Tenerife.
UPDATE tabla_clientes
SET empresa = 'malend', cargo = 'Responsable de Ventas', 
    direccion = 'Calle Falsa, 123', ciudad = 'Santa Cruz de Tenerife', 
    provincia = 'Santa Cruz de Tenerife', ultima_vez_contactado = '2022-10-01'
where nombre = 'Angélica';

select nombre, empresa, cargo, direccion, ciudad, provincia, ultima_vez_contactado from tabla_clientes
where nombre = 'Angélica';


-- @block La nueva junta directiva de duxo ha decidido cambiar a una estructura horizontal. Ahora todos sus cargos son "Empleado" y todos comparten responsabilidad.
-- Además hemos contactado con todos los clientes de dicha empresa
UPDATE tabla_clientes
SET cargo = 'Empleado', ultima_vez_contactado = current_date
WHERE empresa = 'duxo'

-- @block Cambiar nombre a una columna
ALTER TABLE notas_alumnos
RENAME COLUMN matematicas TO notas_matematicas;


-- @block Cambiar las notas de matemáticas con un decimal
ALTER TABLE notas_alumnos
ALTER COLUMN notas_matematicas TYPE NUMERIC(2,1);


