// Lista de tareas es un array de objetos, con nombre, descripción y estado de tarea (completada o no)
let listaTareas = [
    {
        nombre: "Sacar al gato a paser",
        descripcion: "descripción de scar al gato a pasear",
        completada: false,
    },
    {
        nombre: "Tender la ropa",
        descripcion: "tender la ropa en el tendedero",
        completada: false,
    },
    {
        nombre: "Fregar el suelo",
        descripcion: "fregar el suelo con la fregona",
        completada: false,
    },
    {
        nombre: "Limpiar el baño",
        descripcion: "limpiar el baño de la casa",
        completada: false,
    },
];

// Definir una tarea, es un objeto con tres variables
let tarea = {
    nombre: "Fregar la losa",
    descripcion: "hay que fregar todos los platos de la casa",
    completada: false, // "completada" "no completada"
};

let tarea2 = {
    nombre: "Tirar la basura",
    descripcion: "",
    completada: false, // "completada" "no completada" 
};


// Funciones
function tareaATexto(tarea) {
    return `[${tarea.completada ? "x" : " "}] ${tarea.nombre} (${tarea.descripcion})`;
}

function mostrarLista(lista) {
    for (let i = 0; i < lista.length; i++) {
        console.log(tareaATexto(lista[i]));
    }
}

function añadirTarea(lista, tarea) {
    if (tarea.nombre !== undefined && tarea.descripcion !== undefined && tarea.completada !== undefined) {
        lista.push(tarea);
    }
    else {
        console.log("ERROR: La tarea no tiene las propiedades correctas.");
    }
}

function completar(lista, nombreTarea) {
    for (let i = 0; i < lista.length; i++) {
        if(lista[i].nombre === nombreTarea) {
            lista[i].completada = true;
        }
    }
}


añadirTarea(listaTareas, tarea);
// añadirTarea(listaTareas, tarea2);
añadirTarea(listaTareas, {
    nombre: "Tarea  sin variables, es un objeto metido directamente",
    descripcion: "funciona igual que las demás",
    completada: "",
});

console.log("<!-- Antes de completar -->");
mostrarLista(listaTareas);

completar(listaTareas, "Tender la ropa");

console.log("<!-- Después de completar -->");
mostrarLista(listaTareas);

