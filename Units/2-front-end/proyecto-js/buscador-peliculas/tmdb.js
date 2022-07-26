// API de The Movie Database: https://www.themoviedb.org/documentation/api
// Descomponemos la url total https://api.themoviedb.org/3/movie/10003?api_key=58b9272eeaa5596edd32340af66c22b9&language=es-ES en trozos

import {apiKey} from './secreto.js';
const urlBase = `https://api.themoviedb.org/3/`;
// const lang = `es-ES`;
// El idioma de la API por defecto es inglés

/**
 * @param {string} url
 * @return {object} Película
 */
async function fetchJSON(url) {
  const tiempoInicial = performance.now();
  const respuesta = await fetch(url);
  const datos = await respuesta.json();
  const tiempoFinal = performance.now();
  console.log(`Petición a API completada en: 
    ${tiempoFinal - tiempoInicial} ms`);
  return datos;
}

// Documentation of string
// eslint-disable-next-line valid-jsdoc
/**
 * Retorna el objeto que representa a una película con la id proporcionada
 * @param {number} id Es la id de la película
 * @param {string} lang El idioma de la información, es español por defecto
 * @return {object} json
 */
export async function obtenerPelicula(id, lang = 'es-ES') {
  const url = `${urlBase}movie/${id}?api_key=${apiKey}&language=${lang}`;
  return await fetchJSON(url);
}

/**
 * Busca películas usando la cadena de búsqueda
 * @param {string} query Cadena de búsqueda
 * @param {number} page Página de los resultados, 1 por defecto
 * @param {string} lang El idioma de la información, español por defecto
 * @return {object} pelicula
 */
export async function buscarPeliculas(query, page = 1, lang = 'es-ES') {
  // eslint-disable-next-line max-len
  const url = `${urlBase}search/movie?api_key=${apiKey}&language=${lang}&query=${query}&page=${page}`;
  return await fetchJSON(url);
}

/**
 * Función que obtiene la configuración y devuelve un objeto
 * @return {fetchJSON}
 */
export async function obtenerConfiguracion() {
  const url = `${urlBase}configuration?api_key=${apiKey}`;
  return await fetchJSON(url);
}
