-- Borrar tabl si existe --
DROP TABLE IF EXISTS productos;
DROP TABLE IF EXISTS tienda;

--Crear la tabla de productos--
-- Debería tener al menos: nombre, precio --

CREATE TABLE productos (
    nombre      VARCHAR(25),
    precio      DECIMAL(6, 2),
    impuesto    DECIMAL(5, 2)
);

-- Añadir varios artículos a la tienda --
INSERT INTO productos (
    nombre,
    precio,
    impuesto
) VALUES (
    'Bebida',
    2.30,
    7
), (
    'Pan',
    0.50,
    2
), (
    'Queso',
    1.20,
    7
);
