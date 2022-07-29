DROP TABLE IF EXISTS agenda;

CREATE TABLE agenda (
    nombre              VARCHAR(30) NOT NULL,
    apellidos           VARCHAR(59),
    edad                INTEGER CHECK (edad > 18),
    fecha_nacimiento    DATE,
    profesion           VARCHAR(90),
    aficiones           TEXT,
    email               VARCHAR(50),
    telefono            VARCHAR(15)
);

INSERT INTO agenda (
    nombre,
    apellidos,
    edad,
    fecha_nacimiento,
    profesion,
    aficiones,
    email,
    telefono
) VALUES (
    'Alicia',
    'Pérez',
    21,
    '2004-12-12',
    'Estudiante',
    'Fútubol, toros, votar',
    'aliciaperez@gmail.com',
    '+34612334455'
);

-- null --
INSERT INTO agenda (nombre) values ('Bernardo')
