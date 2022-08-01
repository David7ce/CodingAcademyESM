# Setup Básico de Postgres con Visual Studio Code
En este repositorio se encuentran varios archivos que nos ayudarán a configurar VS Code para trabajar con Postgres.

## Software
Para crear un servicio de base de datos con Postgres tenemos distintas opciones. Podemos instalar Postgres con el [instalador oficial](https://www.postgresql.org/download/) o utilizar un stack de desarrollo como el paquete [WAPP](https://bitnami.com/stack/wapp) de Bitnami.

La forma que yo considero más cómoda y multiplataforma es utilizar Docker.

Usar docker lleva un proceso de aprendizaje, pero vamos a tomar un atajo. Debemos instalar (Siguiendo las guías de instalación enlazadas) el siguiente software:
- [Visual Studio Code](https://code.visualstudio.com/download) ya deberíamos tenerlo de antes.
- [Docker Destop](https://www.docker.com/products/docker-desktop/) si queremos un interfaz gráfico en Windows, Mac o Linux.
- [Docker Engine](https://docs.docker.com/engine/install/) si solo queremos el interfaz de linea de comandos. (También podemos usar VSCODE como interfaz) USAREMOS SOLO UNO O EL OTRO.
- [Docker Compose](https://docs.docker.com/compose/install/) para configurar nuestros servicios y automatizar su desliegue.

## Extensiones
Para intentar facilitar al máximo el proceso vamos a utilizar dos extensiones en VS Code.
- [Docker](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-docker)
- [sql-tools](https://marketplace.visualstudio.com/items?itemName=mtxr.sqltools)

## Configuración del espacio de trabajo.
Para crear un servicio de Postgres con Docker vamos a utilizar el fichero [docker-compose.yml](https://github.com/cmo7/postgres-vscode-starter/blob/master/docker-compose.yml). Este fichero contiene la configuración de nuestro servicio de base de datos.

```yaml
version: '3.8'
services:
  db:
    image: postgres:14.1-alpine
    restart: always
    environment:
      - POSTGRES_USER=postgres
      - POSTGRES_PASSWORD=postgres
    ports:
      - '5432:5432'
    volumes: 
      - db:/var/lib/postgresql/data
volumes:
  db:
    driver: local
```

## Lanzar el servicio con Docker Compose
Si hemos instalado todas las extensiones y tenemos este fichero en nuestro espacio de trabajo de VS Code podemos utilizar el menú del botón derecho para lanzar el servicio. Solo tenemos que buscar "Compose Up" y pulsarlo.

Si todo va bien se abrirá una consola donde nos informarán de que Docker se ha descargado la imágen de Postgres y ha lanzado el servicio con éxito.

Como podemos ver en el documento docker-compose.yml el servicio está configurado con los siguientes valores:

```yaml
	host: `localhost`
    puerto: `5432`
    base de datos: `postgres`
    usuario: `postgres`
    password: `postgres`
```

## Conectar con el servicio
Podemos utilizar éstos valores para conectarnos a la base de datos con cualquier cliente, incluido el clinte integrado en VS Code que hemos instalado.

Este repositorio ya incluye una conexión con el cliente integrado, configurada para conectarse con el mismo servicio que hemos lanzado.

Si cambiamos alguno de los valores de docker-compose.yml puede que tengamos que cambiar ésta configuración.

## Ejecutar consultas
Para ejecutar consultas podemos crear archivos temrinados en la extensióin .sql. La extensión nos permitirá ejecutarlos en la conexión actual.

Añadiendo algo más de código podremos ejecutar consultas en otras conexiones (por ejempo si usamos varias bases de datos diferentes a la vez).