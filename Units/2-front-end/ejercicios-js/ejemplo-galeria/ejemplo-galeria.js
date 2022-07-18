/* nueva foto */

let contadorFotos = 1;
let contenedor = document.getElementById("contenedor-fotos");

function nuevaFoto() {
    contenedor.innerHTML += `<img onclick="marcarFoto(event)" src="https://picsum.photos/200/200?random=${contadorFotos++}" >`;
}

function masFotos() {
    for (let i = 0; i < 5; i++) {
        nuevaFoto();
    }
}

function marcarFoto(event) {
    event.target.classList.toggle("marcada-para-borrar");
}

function borrarFotos() {
    let fotosParaBorrar = document.getElementsByClassName("marcada-para-borrar");
    // let fotosParaBorrar = document.querySelectorAll(".marcada-para-borrar");
    // console.log(fotosParaBorrar);
    for (let i = fotosParaBorrar.length - 1; i >= 0; i--) {
        fotosParaBorrar[i].remove();
    }
}

function deseleccionarFotos() {
    let deseleccion = document.getElementsByClassName("marcada-para-borrar");

    // Si está marcada, quitar selección
        for (let i = deseleccion.length - 1; i >= 0; i--) {
            deseleccion[i].classList.remove("marcada-para-borrar");
        }
}
