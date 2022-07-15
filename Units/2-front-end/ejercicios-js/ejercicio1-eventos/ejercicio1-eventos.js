let contenido1 = `<h2>Esto es la primera pestaña</h2>`;
let contenido2 = `<h2>Esto es la segunda pestaña</h2>`;
let contenido3 = `<h2>Esto es la tercera pestaña</h2>`;

let contenedor = document.getElementById("contenedor");

function mostrarPestaña1() {
    contenedor.innerHTML = contenido1;
    //contenedor.style.backgroudColor="red";
}

function mostrarPestaña2() {
    contenedor.innerHTML = contenido2;
}

function mostrarPestaña3() {
    contenedor.innerHTML = contenido3;
}

// mostrarPestaña();
