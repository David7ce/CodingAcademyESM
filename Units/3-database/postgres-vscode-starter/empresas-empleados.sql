-- @block Crear las tablas
DROP TABLE IF EXISTS empleados;
DROP TABLE IF EXISTS empresas;

CREATE TABLE empresas (
    id_empresa SERIAL NOT NULL PRIMARY KEY,
    nombre VARCHAR(30) NOT NULL,
    sede VARCHAR(40) NOT NULL,
    sector VARCHAR(40) NOT NULL
);

CREATE TABLE empleados (
    id_empleado SERIAL NOT NULL PRIMARY KEY,
    nombre VARCHAR(20) NOT NULL,
    apellido VARCHAR(40) NOT NULL,
    id_empresa INTEGER NOT NULL,
    CONSTRAINT empleado_empresa_id_fk
        FOREIGN KEY (id_empresa)
        REFERENCES empresas(id_empresa)
);

-- @block Añadir los datos
INSERT INTO empresas (nombre, sede, sector)
VALUES
    ('City Network', 'S/C de Tenerife', 'Diseño de interiores'),
    ('KFT Innovación', 'S/C de Tenerife', 'Publicidad'),
    ('Praxis Consulting', 'Las Palmas', 'Contabilidad y Finanzas'),
    ('Robody', 'S/C de Tenerife', 'Publicidad');


INSERT INTO empleados (nombre, apellido, id_empresa)
VALUES 
    ('Roque', 'Salcedo', 1),
    ('María Estrella', 'Sabater', 1),
    ('Elder', 'Serrano', 2),
    ('Rufina', 'Bilbao', 3),
    ('Regina', 'Puente', 4);

-- @block
SELECT * FROM empleados;
SELECT * FROM empresas;

-- @block join
SELECT 
    empleados.nombre, empleados.apellido, empresas.nombre AS "Empresa"
FROM 
    empleados INNER JOIN empresas
ON
    empleados.id_empresa = empresas.id_empresa;

