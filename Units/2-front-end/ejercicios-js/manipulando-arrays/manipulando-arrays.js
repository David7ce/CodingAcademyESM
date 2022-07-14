/*
let ejemplo = ["a", "b", "c", "d", "e", true];

console.log(ejemplo.join());
console.log(ejemplo.join(", "));
console.log(ejemplo.join("\n"));

console.log(ejemplo.reverse());
console.log(ejemplo.reverse().join());

console.log(ejemplo.indexOf("b"));
console.log(ejemplo.indexOf("aguacate")); // Si no lo encuentra -1

let dias = ["lunes", "martes", "miércoles", "jueves", "viernes", "sábado", "domingo"];

console.log(dias.indexOf("sábado"));
console.log(dias[3]);

console.log(dias);
dias.splice(6, 2, "hola", "adios");
console.log(dias);

console.log(dias.slice(0, 5))

let x = [1, 2, 3, 4, 5];
let y = [6, 7, 8, 9, 10];

let z = [...x, ...y]; // Deconstrucción de un array (...x lo convierte en una lista)
let Z = [x, y];      // Array de dos arrays

let copiaX = [...x];

console.log(z);
console.log(Z);

console.log([...dias.slice(0, 2), "hola", "adios", ...dias.slice(4, 6)]);
*/

// Split
// let textoDias = "Lunes martes miercoles jueves viernes sabadao domingo";
// let dias = textoDias.split(" ");
// console.log(dias);

// Programa que tome una frase y la escriba del revés
/*
let frase = "Me gusta mucho el javascript";
//reverse()
//split()
//join()
let fraseInvertida = "javasrcipt el mucho gusta Me";
*/

/*
let frase = "Me gusta mucho el javascript";
let fraseRepetida = "Me gusta mucho el javascript";

console.log(frase.split(" ").reverse().join(" "));

console.log(fraseRepetida.split("").reverse().join(""));

let frase2 = frase.split(" ").reverse().join(" ")
*/
/*
let a = "Hola";

console.log(a.repeat(5));

// Substring

// Trim
let saludo = "        hola     ";
console.log(saludo.trim());
*/

/* 
  Ejercicio.
  Crear una función que reciba un string y devuelva el string, 
  pero con todas las letras en mninuscula, excepto la primera de cada palabra
*/

/*
function mayusculasDeTitulo(frase) {
    palabrasMinusculas = frase.toLowerCase().split(" ");

    let palabrasProcesadas = [];
    for (let contador = 0; contador <= palabrasMinusculas.length; contador++)
    {
        palabrasProcesadas[contador]  palabrasMinusculas[contador].toUpperCase();
    }
    return palabrasMinusculas;
}

console.log(mayusculasDeTitulo(frasePrueba));
*/

let frasePrueba = "texto SIN FORmato de ningún tipo";

function mayusculasDeTitulo(frase) {
    let frasEnMinusculas = frase.toLowerCase();
    let listaPalabras = frasEnMinusculas.split(" ");
    let listaProcesada = [];

    for (let i = 0; i < listaPalabras.length; i++)
    {
        let palabra = listaPalabras[i];
        let primeraLetra = palabra[0].toUpperCase();
        let resto = palabra.substring(1);
        let palabraProcesada = primeraLetra + resto;
        listaProcesada.push(palabraProcesada);
    }
    return listaProcesada.join(" ");
}

console.log(mayusculasDeTitulo(frasePrueba));