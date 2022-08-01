-- @block Crear tabla cuentas
create table cuentas (
    nombre TEXT,
    saldo TEXT
)

-- @block Insertar datos
INSERT INTO cuentas (nombre, saldo)
VALUES ('Andrés', '140€'), ('Blanca', '321€'), ('Carlos', '246€'), ('Diana', '500€');

-- @block Nos acabamos de dar cuenta que el saldo debería ser NUMERIC(9,2)
ALTER TABLE cuentas
ALTER COLUMN saldo TYPE NUMERIC(9,2);

-- @block Cambiar el nombre a un VARCHAR(20)
ALTER TABLE cuentas
ALTER COLUMN nombre TYPE VARCHAR(20)

-- @block Añadir columna apellido VARCHAR(10)
ALTER TABLE cuentas
ADD COLUMN apellido VARCHAR(10);

-- @block nombre y saldo no deberían ser nulos
ALTER TABLE cuentas
ALTER COLUMN nombre SET NOT NULL;

-- @block Deberíamos tener una columna para el DNI... perdón. No nula y sin repeticiones.
-- DNI: 
-- Andrés, 32264900N
-- Blanca, 21424292E
-- Carlos, 69541154X
-- Diana, 34493683P

ALTER TABLE cuentas
ADD COLUMN DNI VARCHAR(9)

UPDATE cuentas
SET DNI = CASE nombre
    WHEN 'Andrés' THEN 32264900N
    WHEN 'Blanca' THEN 21424292E
    WHEN 'Carlos' THEN 69541154X
    WHEN 'Diana' THEN 34493683P    

ALTER TABLE cuentas
ALTER COLUMN DNI SET NOT NULL;