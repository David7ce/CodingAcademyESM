let persona1 = {
    nombre: "Alicia",
    apellido: "Alonso",
    direccion: "Calle Falsa, 123",
    edad: 32,
    vacunado: false,
};

let persona2 = {
    nombre: "Antonio",
    apellido: "Alvariño",
    direccion: "calle Inventada, 432",
    edad: 44,
    vacunado: true,
};

/* // Por consola el resultado es este
let unDiv = `<div>
    <h2> Alicia Alonso</h2>
    <div><span>Dirección: </span> Calle Falsa, 1234</div>
    <div> <span> Edad: </span> </div>
    <div>No está vacunada</div>
</div>`
*/
function persona2html(persona) {
    let unDiv = `
<div>
    <h2>${persona1.nombre} ${persona1.apellido}</h2>
    <div><span>Dirección: </span>${persona1.direccion}</div>
    <div> <span>Edad:</span>${persona1.edad}</div>
    <div>${persona1.vacunado ? "Está vacunado" : "No está vacunado"}</div>
</div>`
    return unDiv
}

let miDiv = persona2html(persona1);

document.getElementById("contenedor").innerHTML = miDiv;