console.log("Inicio");

let numero = 5;

// Función con efectos secundarios, depende del valor de i y escribe en la consola

function decirNumero() {
    console.log(numero+1);
}

decirNumero(); // aquí vale numero
decirNumero(); // aquí vale numero más uno

// Al imprimir en el console.log:
// con numero++ me sale (5, 6) 
// con numero+1 (6, 6)
// con numero = numero+1 (6, 7)
// con numero = ++numero (6, 7);  

// Función pura, su valor es conocido
function duplicar(n) {
    return n*2;
}

let a = duplicar(4);

// A todo lo que se modifica se le llama estado

// Funciones de primera clase
function saludar(siguiente) {
    console.log("hola");
    siguiente();
}

// Funciones de paso
function despedirse() {
    console.log("adios");
}

function pedirDinero() {
    console.log("dame un euro bro");
}

saludar(despedirse);
saludar(pedirDinero);

// setTimeout(pedirDinero, 1000);
// setInterval(decirNumero, 2 * 1000);

function sumar2(n) {
    return n+2;
}

function operar(operacion, numero) {
    return operacion(numero);
}

console.log(operar(duplicar, 5));
console.log(operar(sumar2, 5));

// Función map
function map(operacion, lista) {
    let resultado = [];
    for (let i = 0; i < lista.length; i++) {
        resultado.push(operacion(lista[i]));
    }
    return resultado;
}

let l = [1, 2, 3, 4, 5];
console.log(map(duplicar, l));
console.log(map(sumar2, l));

let palabras = ["hola", "adios", "buenos dias"];

function mayus(s) {
    return s.toUpperCase();
}

console.log(map(mayus, palabras));
console.log(palabras.map(mayus));  // viene por defecto en 

console.log(l.map(duplicar));

let menu = ["home", "sobre nosotros", "carrito"];

function meterEnLi(elemento) {
    return `<li> ${elemento} </li>`
}

console.log(menu);
console.log(menu.map(meterEnLi).join("\n"));

// --------------------------------------------------------- //

function meterEnDiv(elemento) {
    return `<div>${elemento}</div>$`
}

let abecedario = "abcdefghijklmnñopqrstuvwxyz"; 
let arrAbecedario = abecedario.split("");

console.log(arrAbecedario);

let divAbecedario = arrAbecedario.map(meterEnDiv);

 console.log(divAbecedario.join("\n"));

console.log(
    abecedario.split("").map(
        meterEnDiv)
        .join("\n")
)
/*
console.log(
    abecedario.split("")
    .map(function (x) {
        return `<div> ${x} </div>`
    }
    .join("\n")
)
*/

console.log( 
    l.map(function(x) {return x*3})
)

console.log( 
    l.map(function(x) {return Math.sqrt(x)})
)

console.log( 
    l.map(function(x) {return "aguacate"})
)

console.log(
    l.map( x => x * 5)
)

const triple = x => x + 3;

/*
const otro =(x, y) => {
    console.log()
    return x +3;
}
*/

console.log(
    abecedario.split("")
    .map(x => '<div> ${x} </div>')
    .join("")
)

operar (function (x) {return x / 2}, 6)

setTimeout( () => {console.log("timeout")}, 1000);