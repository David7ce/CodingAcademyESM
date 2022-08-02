/*
    # Práctica de modelado de datos 1: Base de datos de un videoclub.

    Es el año 1996 y aunque la gente habla de Internet, el videoclub es el rey del ocio doméstico.

    El "Videoclub León 2" nos ha encargado que preparemos una aplicación para gestionar el negocio.

    ## Requisitos

    1.- Necesitamos almacenar la información de los clientes:
        Nº de Socio
        Nombre completo
        Fecha de inscripción
        Fecha de pago de la última mensualidad

    2.- Necesitamos almacenar la información de las cintas de vídeo:
        Título
        Año de lanzamiento
        Sinopsis
        Precio

    3.- Necesitamos almacenar la información de los prestamos:
        Fecha de préstamo
        Fecha límite de devolución
        Película prestada
        Socio que ha tomado el préstamo
    
    4.- Necesitamos acceder de forma rápida a la facturación a través de una vista de todos los
    prestamos con su importe.

    5.- Necesitamos poder modificar de forma sencilla los datos de un socio, sin tener que afectar a múltiples tablas.

    6.- Necesitamos poder obtener de forma sencilla la lista de socios que no están al día con sus pagos.

    7.- Necesitamos poder obtener de forma sencilla la lista de socios que tienen préstamos pasados de fecha.

    8.- Necesitamos poder ver fácilmente cuántos préstamos acumula una cinta, y si son más de 40 borrarla del sistema.
*/

--@block Borrar todas las tablas de la base de datos si ya existen.
DROP TABLE IF EXISTS prestamos;
DROP TABLE IF EXISTS clientes;
DROP TABLE IF EXISTS cintas;
-- DROP TABLE IF EXISTS cintas;

--@block Crear las tablas necesarias para la base de datos
CREATE TABLE clientes(
    numero_socio                   SERIAL NOT NULL PRIMARY KEY,
    nombre_cliente                 VARCHAR(20) NOT NULL,
    fecha_inscripcion              DATE NOT NULL,
    fecha_pago_ultima_mensualidad  DATE NOT NULL
);
CREATE TABLE cintas(
    id_cinta                       SERIAL NOT NULL PRIMARY KEY,
    cinta                          VARCHAR(40) NOT NULL,
    anio_lanzamiento               DATE NOT NULL,
    sinopsis                       TEXT NOT NULL,
    precio                         NUMERIC(5, 2) NOT NULL
);
CREATE TABLE prestamos(
    id_alquiler                    SERIAL NOT NULL PRIMARY KEY,
    fecha_prestamo                 DATE NOT NULL,
    fecha_limite_devolucion        DATE NOT NULL,
    pelicula_prestada              INTEGER NOT NULL,
    socio                          INTEGER NOT NULL,
    CONSTRAINT cinta_id_cinta_fk
        FOREIGN KEY (pelicula_prestada)
        REFERENCES cintas(id_cinta),
    CONSTRAINT clientes_numero_socio_fk
        FOREIGN KEY (socio)
        REFERENCES clientes(numero_socio)
);

--@block Crear las vistas necesarias para simplificar búsquedas futuras.

--@block Hacer la entrada inicial de información


--@block Crear tantos bloques como hagan falta para realizar las acciones solicitadas


--@block Obtener el precio de cada préstamo
SELECT
    sum(cintas.precio)
FROM
    prestamos INNER JOIN peliculas
ON
    prestamos.pelicula_prestada = cintas.id_cinta;

