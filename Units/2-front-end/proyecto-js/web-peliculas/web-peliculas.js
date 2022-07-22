
// Definimos como constantes lo archivos json provenientes de un URL
const peliculasURL = "https://nohaywebs.com/esm/peliculas-populares.json";
const configuracionURL = "https://nohaywebs.com/esm/configuration.json";

// Creamos la función asíncrona que obtiene los datos del servidor y los retorna como json
async function fetchJSON(URL) {
    const respuesta = await fetch (URL);
    const datos = await respuesta.json();
    return datos;
}

async function obtenerDatos() {
    const peliculas = await fetchJSON(peliculasURL);
    const configuracion = await fetchJSON(configuracionURL);

    const baseURL = configuracion.images.base_url;
    const posterSize = configuracion.images.poster_sizes[6];
    const poster = peliculas.results[3].poster_path;

    console.log(baseURL + posterSize + poster);
}




/*
async function obtenerDatos() {
    try {
        const respuestaPeliculas = await fetch(peliculasURL);
        const datosURL = await respuestaPeliculas.json();
        console.log(datosURL);

        const respuestaConfig = await fetch(configuracionURL);
        const datosConfig = await respuestaConfig.json();
        console.log(datosConfig);

    } catch (error) {
        console.log("Error, no se han podido descargar los datos.")
    }
}
*/

obtenerDatos();
