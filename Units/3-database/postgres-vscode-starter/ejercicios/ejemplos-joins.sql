--@block Borrar y crear las tablas, añadir datos
DROP TABLE IF EXISTS cesta_a;
DROP TABLE IF EXISTS cesta_b;


CREATE TABLE cesta_a(
    id_a SERIAL PRIMARY KEY,
    fruta_a VARCHAR(50)
);

CREATE TABLE cesta_b(
    id_b SERIAL PRIMARY KEY,
    fruta_b VARCHAR(50)
);

INSERT INTO cesta_a (fruta_a)
VALUES
    ('Manzana'),
    ('Naranja'),
    ('Plátano'),
    ('Pepino');


INSERT INTO cesta_b (fruta_b)
VALUES
    ('Naranja'),
    ('Manzana'),
    ('Sandía'),
    ('Pera');


--@block INNER JOIN.
SELECT * FROM cesta_a INNER JOIN cesta_b ON fruta_a = fruta_b;

/*
|id_a|fruta_a|id_b|fruta_b|
|----|-------|----|-------|
|1   |Manzana|2   |Manzana|
|2   |Naranja|1   |Naranja|

Tenemos todas las filas que existen tanto en cesta_a como en cesta_b,
atendiendo a que las columnas fruta_a y fruta_b sean iguales.
*/

--@block LEFT JOIN
SELECT * FROM cesta_a LEFT JOIN cesta_b ON fruta_a = fruta_b;

/*
|id_a|fruta_a|id_b|fruta_b|
|----|-------|----|-------|
|1   |Manzana|2   |Manzana|
|2   |Naranja|1   |Naranja|
|3   |Plátano|null|null   |
|4   |Pepino |null|null   |

Tenemos todas las filas que existen en la tabla IZQUIERDA (cesta_a) que
en un LEFT JOIN es la dominante.

Si hay filas que se correspondan en la tabla DERECHA (cesta_b) se unen al
registro correspondiente. Si no se pone un valor nulo.

*/

--@block RIGHT JOIN
SELECT * FROM cesta_a RIGHT JOIN cesta_b ON fruta_a = fruta_b;

/* 
|id_a|fruta_a|id_b|fruta_b|
|----|-------|----|-------|
|2   |Naranja|1   |Naranja|
|1   |Manzana|2   |Manzana|
|null|null   |3   |Sandía |
|null|null   |4   |Pera   |

Tenemos todas las filas que existen en la tabla DERECHA (cesta_b) que
en un RIGHT JOIN es la dominante.

Si hay filas que se correspondan en la tabla IZQUIERDA (cesta_a) se unen al
registro correspondiente. Si no se pone un valor nulo.

 */