--@block Borrar, Crear, Añadir datos.
DROP TABLE IF EXISTS empleados;
CREATE TABLE empleados(
    id INTEGER PRIMARY KEY,
    nombre VARCHAR(20),
    supervisor INTEGER
);
INSERT INTO empleados
VALUES (1, 'Alicia', NULL),
    (2, 'Bernardo', 1),
    (3, 'Carmen', 1),
    (4, 'David', 2),
    (5, 'Esther', 2),
    (6, 'Fernando', 3);
--@block SELF JOIN para obtener una tabla con el nombre del supervisor.
SELECT empleados.nombre,
    supervisores.nombre AS "Supervisor"
FROM empleados
    LEFT JOIN empleados supervisores --Alicia no aparece en caso de INNER JOIN.
    ON empleados.supervisor = supervisores.id;