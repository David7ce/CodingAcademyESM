/* Esto es un comentario de código */
/*
var hola = "Hola";

console.log(hola);
console.log("Esto es la consola de javascript");

var a = 100;
let b = 10;
a = "Prueba de texto";


for (var i = 0; i < 100; i++) {
    console.log("i vale " + i);
}

function bucleFor() {
    for (var i = 0; i < 100; i++) {
        console.log("i vale " + i);
    }
}
bucleFor();


function bucleWhile() {
    var i = 0;
    while (i < 100) {
        console.log("i vale " + i);
        i += 3;
    }
}
bucleWhile();

function cuadrado(n) {
    return n*n;
}
console.log(cuadrado("5"));

function doble(n) {
    return n+n;
}
*/
/*

console.log(doble(5));   // resultado 5
console.log(doble("5")); // resultado 55


function cinco5(cual) {
    if (cual === 5) return 5;
    if (cual === "cinco") return "cinco";
}
console.log(cinco5(5));

function decirHola() {
    console.log("¡Hola!");
}

function decirAdios() {
    console.log("¡Adiós!");
}

function saludador(otraFuncion) {
    console.log("Voy a saludar");
    // setTimeout(otraFuncion, 1000)
    otraFuncion();
    console.log("Ya he saludado");
}
saludador(decirHola);
saludador(decirAdios);
*/

// ------------------------------------------------------------------------
/*
var v = true;
var v2 = false;
var n1 = -5;
var vacio = [];
var emojis = ["👍", "😂", "😁"];
var numeros = [1, 2, 3, 4, 5];
var letras = ["a", "b", "c", "d"]; // array de letras
var cosas = [true, 4, "adios"];
var listas = [vacio, emojis, numeros, letras, cosas]

console.log(numeros[30]);

// push añade por el final
// pop quita por el final
var compra = [];
compra.push("aguacate");
compra.push("platano");
compra.push("pan");
var x = compra.pop();

console.log(compra);
console.log(x);

// shift quita elementos por el principio
// unshift añade elementos por el principio
compra.unshift("aguacate");
compra.unshift("platano");
compra.unshift("pan");
var x = compra.shift("algo");

var pedidos = [];

pedidos.push("pedidos992");
pedidos.push("pedidos252");

// LIFO las in first out
*/

// Creo un objeto en javascript
/*
var objetoEmojis = {
    sonrisa: "😁",
    "sonrisa 2": "😇",
    corazon: "♥",
    coche: "🚗"
}

console.log(objetoEmojis.sonrisa);
console.log(objetoEmojis["sonrisa 2"]);

var personas = [
    {
        nombre: "Alicia",
        edad: 34,
        // "dirección postal": "calle falsa 123",
    },
    {
        nombre: "Bernardo",
        edad: 65,
    }
];

console.log(personas[0].nombre)

console.log(5 === "5")

console.log(true ? "hola" : "adiso")

if (true) {
    respuesta = "hola";
}
else {
    respuesta = "adios";
}

console.log(respuesta);

var p = {
    vacuna: false,
    nombre: "Fulano"
}

console.log(p.vacuna ? "Está vacunado." : "No está vacunado.");
*/

/* Crear un array con los númemros entre el 1 y el 100 */
function cuentaCien(inicio, fin) {
    var arrayCien = [];
    for (i= inicio; i <= fin; i++) {
        arrayCien.push(i);
    }
    return arrayCien;
}
console.log(cuentaCien(1, 100));

/* Crear un objeto que contenga el nombre, apellidos y dirección de una persona, 
*/

var objetoPersona = {
    nombre: "Alicia",
    apellido: "Alvariño",
    direccion: "Calle Falsa, 123, Santa Cruz de Tenerife",
}

console.log(objetoPersona.nombre + " " + objetoPersona.apellido + " vive en " + objetoPersona.direccion);

/* Crear una función que calcule el área de un triángulo */
function areaTriangulo(base, altura) {
    return (base * altura / 2);
}

console.log("El área del triángulo es "+ areaTriangulo(3,3));