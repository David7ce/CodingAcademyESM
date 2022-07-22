
// Definimos como constantes lo archivos json provenientes de un URL
const peliculasURL = "https://nohaywebs.com/esm/peliculas-populares.json";
const configuracionURL = "https://nohaywebs.com/esm/configuration.json";

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

// Creamos la función asíncrona que obtiene los datos del servidor y los retorna como json
async function fetchJSON(URL) {
    const respuesta = await fetch(URL);
    const datos = await respuesta.json();
    return datos;
}

async function obtenerDatos() {
    const peliculas = await fetchJSON(peliculasURL);
    const configuracion = await fetchJSON(configuracionURL);

    const baseURL = configuracion.images.base_url;
    const posterSize = configuracion.images.poster_sizes[2];
    // const poster = peliculas.results[2].poster_path;
    // console.log(baseURL + posterSize + poster);

    document.getElementById("contenedor").innerHTML =
        peliculas.results
            .map(peli => `<div class="ficha-pelicula">
                            <div> <img src="${baseURL + posterSize + peli.poster_path}" alt=""> </img> </div>
                            <h2> ${peli.title} </h2>
                            <p><span>Año de lanzamiento:</span> ${peli.release_date.substring(0, 4)} </p>
                            <p>${peli.overview}</p>
                        </div>`)
            .join("\n");

    // .map(peli => {return ``}).join("\n");
}

let body = document.getElementsByName("body")[0];

/*
let div = document.createElement("div");
let h2 = document.createElement("h2");
let text = document.createTextNode("Nombre de la peli");
h2.appendChild(text);
div.appendChild(h2);
*/

obtenerDatos();
