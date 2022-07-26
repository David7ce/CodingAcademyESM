import {obtenerPelicula, buscarPeliculas, obtenerConfiguracion} from './tmdb.js';

/*
// Antes era necesario llamar a la función, ahora se puede hacer desde el nivel superior
async function init() {
    console.log(await obtenerPelicula(5050));
}

init();

// Función flecha anónima invocada inmediatamente
(() => {
    console.log("cosas antiguas");
})()
*/

/*
console.log(await obtenerPelicula(550, 'fr-FR'));
console.log(await obtenerPelicula(550));
console.log(await buscarPeliculas('8 apellidos', 1, 'es-ES'));
*/

// No detecta a la función con el onkeyup="manejarCambio(event) en el html

async function manejarCambio(event) {
    const query = event.target.value;
    if (query === "")
        return null;
    const datos = await buscarPeliculas(query, 1, 'es-ES');
    // console.log(datos.results.map(m => m.title));  // muestra los títulos

    const cajaResultados = document.getElementById('caja-resultados');

    if (datos.results.length === 0) {
        cajaResultados.innerHTML = 'No hay resultados';
        return null; // O usar un else para que si no se cumple salga
    }

    cajaResultados.innerHTML = datos.results.map(
        pelicula => `<div class="ficha-pelicula> <h4> ${pelicula.title} </h4> </div>`
    ).join("\n");
}

// Con change (pulsando enter), con keyup es al levanatr una tecla
document.getElementById("caja-busqueda").addEventListener('keyup', manejarCambio);

console.log(await obtenerConfiguracion());

console.log("hola");
