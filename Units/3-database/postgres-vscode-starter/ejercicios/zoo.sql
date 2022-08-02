/*
    # Práctica de modelado de datos 1: Base de datos de un zoo.

    Estamos en 2045 y nos encontramos con el primer Zoo ético del mundo, donde los animales son robots hiper-realistas peluditos y achuchables.

    Es imprescindible tener un control exhaustivo.

    ## Requisitos

    1.- Necesitamos guardar la información de los animales
        Nombre
        Especie
        Sexo
        Edad
        Hábitat en el que vive
    
    2.- Necesitamos guardar la información de las especies de animales
        Nombre
        Peso máximo
        Esperanza de vida
        Peligrosidad (Baja / Media / Alta) <- Y NINGUN OTRO VALOR
        Dieta (carnívoro, piscívoro, herbívoro, omnívoro) <- Y NINGUN OTRO VALOR

    3.- Hábitats
        Nombre
        Tipo (Acuático, Selva, Sabana, Montaña, Desierto) <- Y NINGUN OTRO VALOR
        Tamaño (en metros cuadrados)

    4.- Visitantes
        Identificador (son anónimos)
        Edad
        Género (Masculino, Femenino, Otro) <- Y NINGUN OTRO VALOR

    5.- Visitas
        Visitante
        Hábitats visitados
        Duración de la visita

    6.- Queremos poder obtener de forma sencilla cuantas veces ha sido visitado cada animal.

    7.- Queremos poder comprobar si un visitante ha visitado a un animal concreto.

    8.- Queremos una lista de los 10 hábitats más populares.

    9- Queremos saber cual es el animal más popular entre visitantes menores de edad.

    10.- Queremos una lista de los animales ancianos (su edad es mayor que su esperanza de vida) para cuidarlos con más mimo.

    11.- Queremos una lista de los animales de especies peligrosas.

    12.- Queremos saber cual es el animal más popular entre personas de género femenino.

    13.- Queremos saber el tamaño total del zoo en metros cuadrados.

    14.- Queremos saber el porcentaje de animales de sexo masculino.

    15.- Queremos saber el porcentaje de carnívoros en cada hábitat.
*/

--@block Borrar todas las tablas de la base de datos si ya existen.

--@block Crear las tablas necesarias para la base de datos

--@block Crear las vistas necesarias para simplificar búsquedas futuras.

--@block Hacer la entrada inicial de información

--@block Crear tantos bloques como hagan falta para realizar las acciones solicitadas