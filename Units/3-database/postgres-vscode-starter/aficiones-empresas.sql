--  @block
DROP TABLE IF EXISTS aficion_persona;
DROP TABLE IF EXISTS personas;
DROP TABLE IF EXISTS aficiones;

CREATE TABLE personas (
    id_persona SERIAL NOT NULL PRIMARY KEY,
    nombre VARCHAR(30)
);

CREATE TABLE aficiones (
    id_aficion SERIAL NOT NULL PRIMARY KEY,
    nombre VARCHAR(30)
);

CREATE TABLE aficion_persona (
    id_aficion INTEGER,
    id_persona INTEGER,
    CONSTRAINT aficion_persona_aficion_fk
        FOREIGN KEY (id_aficion)
        REFERENCES aficiones(id_aficion),
    CONSTRAINT aficion_persona_persona_fk
        FOREIGN KEY (id_persona)
        REFERENCES personas(id_persona)
)

-- @block Añadir los datos
INSERT INTO aficiones (nombre)
VALUES
    ('Padel'),
    ('Senderismo'),
    ('Pintar'),
    ('Ajedrez'),
    ('Música'),
    ('Series'),
    ('Escalada');

INSERT INTO personas (nombre)
VALUES
    ('ALicia'),
    ('Bernanrdo'),
    ('Carmen'),
    ('Darío'),
    ('Elisa');

-- @block Insertar pares afición-persona
INSERT INTO aficion_persona (id_persona, id_aficion)
VALUES
    (1, 1),
    (1, 3),
    (1, 4),
    (2, 2),
    (2, 4),
    (3, 1),
    (3, 2),
    (4, 3),
    (5, 7)

-- @block mal hecho
INSERT INTO aficion_persona (id_persona, id_aficion)
VALUES 
    (7, 1);

-- @block Consulta
SELECT 
    personas.nombre AS "persona",
    aficiones.nombre AS "afición"
FROM personas INNER JOIN aficion_persona
ON personas.id_persona = aficion_persona.id_persona
INNER JOIN aficiones
ON aficion_persona.id_aficion = aficiones.id_aficion;


-- @block

