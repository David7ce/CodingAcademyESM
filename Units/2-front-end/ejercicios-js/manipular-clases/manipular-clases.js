let caja1 = document.getElementById("caja-1");
console.log("Obtener elemento con la caja 1.");
console.log(caja1);

let listaCajas = document.getElementsByClassName("box");
console.log("Obtener elementos con la clase box.");
console.log(listaCajas);

let seleccionCaja1 = document.querySelector("div#caja1");
console.log("Seleccionar el primer elemento que sea div con la caja-1.");
console.log(seleccionCaja1);

let seleccionCajas = document.querySelectorAll("div.box");
console.log("Seleccionar todos los elementos que sean div y tengan clase box.");
console.log(seleccionCajas);

function mostrarClases(event) {
    // event.target.classList.add("clicked");
    event.target.classList.remove("roja");
    event.target.classList.toggle("clicked"); /* alterna */
}

// ¿Cómo hacer para seleccionar con shift? Es más complicado y se necesitan más cosas
