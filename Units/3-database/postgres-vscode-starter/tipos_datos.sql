DROP TABLE IF EXISTS agenda;
CREATE TABLE agenda (
  nombre                VARCHAR (20),
  apellidos             VARCHAR (30),
  edad                  INTEGER,
  fecha_de_nacimiento   DATE,
  profesion             VARCHAR (30),
  aficiones             VARCHAR (150),
  email                 VARCHAR (30),
  teléfono              VARCHAR (15)
);
INSERT INTO agenda(
    nombre,
    apellidos,
    edad,
    fecha_de_nacimiento,
    profesion,
    aficiones,
    email,
    teléfono
) VALUES (
    'Marce',
    'Concepción Barandela',
    37,
    '1984-08-07',
    'Buscavidas',
    'Cine, Podcasts, Videojuegos, Leer',
    'marcelinocb@gmail.com',
    '+34 666 666 666'
);

INSERT INTO agenda VALUES (
    'Alicia',
    'Escudero',
    23,
    '1997-02-01',
    'Abogada',
    'Música, Series, Voleibol',
    'aescudero@test.com',
    '+34 666 666 666'
);

INSERT INTO agenda(
    nombre
) VALUES (
    'Bernardo'
);

CREATE TABLE agenda (
  nombre                VARCHAR (20) NOT NULL,
  apellidos             VARCHAR (30),
  edad                  INTEGER,
  fecha_de_nacimiento   DATE,
  profesion             VARCHAR (30),
  aficiones             VARCHAR (150),
  email                 VARCHAR (30),
  teléfono              VARCHAR (15) NOT NULL UNIQUE 
);

CREATE TABLE agenda (
  nombre                VARCHAR (20) NOT NULL,
  apellidos             VARCHAR (30),
  edad                  INTEGER, CHECK(edad > 18),
  fecha_de_nacimiento   DATE,
  profesion             VARCHAR (30),
  aficiones             VARCHAR (150),
  email                 VARCHAR (30),
  teléfono              VARCHAR (15) NOT NULL UNIQUE 
);


SELECT * FROM agenda;