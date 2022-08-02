-- Borra tabla si existe --
DROP TABLE IF EXISTS lista_dulces;

-- Crea la tabla con las columnas. Primero se crean las columnas y después las filas --
CREATE TABLE lista_dulces (
    nombre_dulce text,
    descripcion_dulce text,
    precio_dulce text
);

-- Insertar datos en la tabla --
-- Filas = entradas = registros = records --
INSERT INTO lista_dulces (
        nombre_dulce,
        descripcion_dulce,
        precio_dulce
    )
VALUES (
        'Dulce de crema',
        'Dulce cson exquisita crema pastelera',
        '1.50 €'
    ), (
        'Donut',
        'Dulce con agujero',
        '1.30 €'
    ), (
        'Berlina',
        'Hojaldre con relleno de crema',
        '2.00 €'
    );

