let datos = [{
    "nombre": "Bel",
    "color": "Crimson",
    "tamaño": "muy grande",
    "vacunado": false
}, {
    "nombre": "Leanor",
    "color": "Yellow",
    "tamaño": "mediano",
    "vacunado": false
}, {
    "nombre": "Trudi",
    "color": "Fuscia",
    "tamaño": "muy grande",
    "vacunado": true
}, {
    "nombre": "Blinnie",
    "color": "Khaki",
    "tamaño": "muy grande",
    "vacunado": true
}, {
    "nombre": "Dene",
    "color": "Khaki",
    "tamaño": "pequeño",
    "vacunado": false
}, {
    "nombre": "Elberta",
    "color": "Violet",
    "tamaño": "grande",
    "vacunado": false
}, {
    "nombre": "Agnella",
    "color": "Pink",
    "tamaño": "grande",
    "vacunado": false
}, {
    "nombre": "Lula",
    "color": "Mauv",
    "tamaño": "grande",
    "vacunado": true
}, {
    "nombre": "Eugenie",
    "color": "Pink",
    "tamaño": "muy grande",
    "vacunado": true
}, {
    "nombre": "Jessamine",
    "color": "Indigo",
    "tamaño": "grande",
    "vacunado": true
}, {
    "nombre": "Luella",
    "color": "Green",
    "tamaño": "mediano",
    "vacunado": false
}, {
    "nombre": "Reinold",
    "color": "Mauv",
    "tamaño": "grande",
    "vacunado": true
}, {
    "nombre": "Abby",
    "color": "Khaki",
    "tamaño": "pequeño",
    "vacunado": true
}, {
    "nombre": "Ag",
    "color": "Green",
    "tamaño": "pequeño",
    "vacunado": false
}, {
    "nombre": "Eric",
    "color": "Indigo",
    "tamaño": "mediano",
    "vacunado": false
}, {
    "nombre": "Phebe",
    "color": "Indigo",
    "tamaño": "pequeño",
    "vacunado": true
}, {
    "nombre": "Bond",
    "color": "Green",
    "tamaño": "grande",
    "vacunado": false
}, {
    "nombre": "Mireielle",
    "color": "Mauv",
    "tamaño": "grande",
    "vacunado": true
}, {
    "nombre": "Mikkel",
    "color": "Pink",
    "tamaño": "muy grande",
    "vacunado": false
}, {
    "nombre": "Dulce",
    "color": "Puce",
    "tamaño": "pequeño",
    "vacunado": true
}];

function peroObjeto2String(perro) {
    return `
    <div>
        <h2>${perro.nombre}</h2>
        <ul>
            <li><span>Color: </span>${perro.color}</li>
            <li><span>Tamaño: </span>${perro.tamaño}</li>
            <li><span>Vacunado: </span>${perro.vacunado ? "si" : "no"}</li>
        </ul>
    </div>`
}