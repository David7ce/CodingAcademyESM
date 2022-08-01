-- @block borra la tabla si existe
DROP TABLE IF EXISTS alumnos;

-- @block crear la tabla
CREATE TABLE alumnos(
    id SERIAL            NOT NULL PRIMARY KEY,
    nombre VARCHAR(15)   NOT NULL,
    matematicas INTEGER  NOT NULL, CHECK (matematicas >= 0), CHECK (matematicas <= 10),
    lengua INTEGER       NOT NULL, CHECK (lengua >= 0), CHECK (lengua <= 10),
    fisica INTEGER       NOT NULL, CHECK (fisica >= 0), CHECK (fisica <= 10)
);

-- @block insertar datos
INSERT INTO
    alumnos (nombre, matematicas, lengua, fisica)
VALUES
    ('Alicia', 7, 2, 5),
    ('Bernardo', 8, 9, 6),
    ('Carmen', 8, 3, 6),
    ('Dario', 5, 5, 9),
    ('Esther', 3, 7, 6),
    ('Fernando', 4, 8, 10),
    ('Gloria', 1, 4, 6);

-- @block comprobación
SELECT * FROM alumnos;

-- @block Reperar matemáticas para Gloria. Aquí se borra su registro!
DELETE FROM alumnos WHERE nombre = 'Gloria';
INSERT INTO alumnos (nombre, matematicas, lengua, fisica) VALUES ('Gloria', 8, 4, 6);

-- @block Recuperar matematicas con UPDATE
UPDATE alumnos SET matematicas = 8 WHERE nombre = 'Gloria';

-- @block borra todos los alumnos que han suspendido matematicas
DELETE FROM alumnos
WHERE matematicas < 5;

-- @block Poner un 10 en física a los que tengan aprovadas matematicas
UPDATE alumnos SET fisica = 10
WHERE matematicas >= 5;

-- @block aprobado general en lengua
UPDATE alumnos
SET lengua = 5
WHERE lengua < 5;


-- @block Añadir columna educación física
ALTER TABLE alumnos
ADD COLUMN educacion_fisica INTEGER

-- @block Insertar notas de educación física
UPDATE alumnos
SET educacion_fisica = CASE nombre
        WHEN 'Alicia' THEN 8
        WHEN 'Bernardo' THEN 7
        WHEN 'Carmen' THEN 9
        WHEN 'Dario' THEN 3
        WHEN 'Esther' THEN 7
        WHEN 'Fernando' THEN 5
        WHEN 'Gloria' THEN 7
    END;

-- @block Restricción No Nulo en columna nueva
ALTER TABLE alumnos
ALTER COLUMN educacion_fisica SET NOT NULL;


-- @block Borrar la columna lengua
ALTER TABLE alumnos
DROP COLUMN lengua;

-- @block cambiar nombre
ALTER TABLE alumnos
RENAME TO notas_alumnos;