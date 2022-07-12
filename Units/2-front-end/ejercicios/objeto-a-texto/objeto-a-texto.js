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


"Alicia Alonso vive en Calle Falsa, 124, tiene 32 años y no tiene vacuna"

function persona2texto(persona) {
    return persona.nombre + " " + persona.apellido + " " + persona.direccion + " tiene " + persona.edad + " años y " + (persona.vacunado ? "tiene vacuna" : "no tiene vacuna"); 
}

function persona2textoB(p) {
    return `${p.nombre} ${p.apellido} vive en  ${p.direccion} tiene ${p.edad} años ${p.vacunado ? " tiene vacuna" : " no tiene vacuna"}`;
}

console.log(persona2texto(persona1));
console.log(persona2texto(persona2));

console.log(persona2textoB(persona1));
console.log(persona2textoB(persona2));

let x = 10;
let y = 20;
console.log(`x vale ${x} y la y vale ${y}`); // Plantillas literales
console.log("x vale" + x + ", mientras y vale " + y );