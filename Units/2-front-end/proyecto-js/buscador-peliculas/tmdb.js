// Descomponemos la url total en trozos: https://api.themoviedb.org/3/movie/10003?api_key=58b9272eeaa5596edd32340af66c22b9&language=es-ES

import { apiKey } from "./secreto.js"
const urlBase= `https://api.themoviedb.org/3/`;
// const lang = `es-ES`;  // sin idioma la API lo hace en inglés por defecto

async function fetchJSON(url) {
    const tiempoInicial = performance.now();
    const respuesta = await fetch(url);
    const datos = await respuesta.json();
    const tiempoFinal = performance.now();
    console.log(`Petición a API completada en: ${tiempoFinal - tiempoInicial} ms`);
    return datos;
}

// Documentation of string
/**
 * Retorna el objeto que representa a una película con la id proporcionada
 * @param {number} id Es la id de la película
 * @param {string} lang El idioma de la información, es español por defecto
 * @returns  object
 */

export async function obtenerPelicula(id, lang = 'es-ES') {
    const url = `${urlBase}movie/${id}?api_key=${apiKey}&language=${lang}`;
    return await fetchJSON(url);
}

/**
 * Busca películas usando la cadena de búsqueda
 * @param {*} query Cadena ed búsqueda
 * @param {*} page Página de los resultados, 1 por defecto
 * @param {*} lang El idioma de la información, español por defecto
 * @returns objeto pelicula
 */
export async function buscarPeliculas(query, page = 1, lang = 'es-ES') {
    const url = `${urlBase}search/movie?api_key=${apiKey}&language=${lang}&query=${query}&page=${page}`;
    return await fetchJSON(url);
}

export async function obtenerConfiguracion() {
    const url = `${urlBase}configuration?api_key=${apiKey}`;
    return await fetchJSON(url);
}