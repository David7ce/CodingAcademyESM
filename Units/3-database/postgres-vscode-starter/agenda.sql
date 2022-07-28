DROP TABLE IF EXISTS agenda;

CREATE TABLE agenda (
    nombre              VARCHAR(30),
    apellidos           VARCHAR(59),
    edad                INTEGER,
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
    18,
    '2004-12-12',
    'Estudiante',
    'Fútubol, toros, votar',
    'aliciaperez@gmail.com',
    '+34612334455'
);

-- null --
INSERT INTO agenda (nombre) values ('Bernardo')
