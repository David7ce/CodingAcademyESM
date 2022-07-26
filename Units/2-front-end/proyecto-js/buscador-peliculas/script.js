import {buscarPeliculas, obtenerConfiguracion} from './tmdb.js';

/*
// Antes era necesario llamar a la función,
// ahora se puede hacer desde el nivel superior
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

/**
 * Maneja el cambio en un input
 * @param {event} event
 * @return {null}
 */
async function manejarCambio(event) {
  const query = event.target.value;
  if (query === '') {
    return null;
  }
  // eslint-disable-next-line max-len
  const datos = await buscarPeliculas(query, 1, 'es-ES'); // obtiene los datos de buscarPeliculas
  const configuracion = await obtenerConfiguracion();

  const imagenBaseURL = configuracion.images.secure_base_url;
  const posterSize = configuracion.images.poster_sizes[2];

  const cajaResultados = document.getElementById('caja-resultados');

  if (datos.results.length === 0) {
    cajaResultados.innerHTML = 'No hay resultados';
    return null;
  }

  console.log(datos.results[0].release_date); // Preguntar duda

  cajaResultados.innerHTML = [...datos.results]
      .sort(function(a, b) {
        if (a.release_date > b.release_date) {
          return -1;
        };
        if (a.release_date < b.release_date) {
          return 1;
        };
        return 0;
      }).map(
          (pelicula) => `<div class="pelicula">
                        <img src="${imagenBaseURL + posterSize +
                          pelicula.poster_path}" 
                        alt="poster de ${pelicula.title}">
                        <h4> ${pelicula.title} (${pelicula.release_date}) </h4>
                        <div> ${pelicula.vote_average} </div>
                     </div>`,
      ).join('\n');

  // eslint-disable-next-line max-len
  console.log(`El tamaño de los pósteres es de ${posterSize} y el url de la imagen es ${imagenBaseURL}`);
}

// Con change (pulsando enter), con keyup es al levanatr una tecla
// eslint-disable-next-line max-len
document.getElementById('caja-busqueda').addEventListener('keyup', manejarCambio);

console.log(await obtenerConfiguracion());
