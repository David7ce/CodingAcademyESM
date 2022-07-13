// Definir una tarea, es un objeto con tres variables
let tarea = {
    nombre: "Fregar la losa",
    descripcion: "Hay que fregar todos los platos de la casa",
    completada: false, // "completada" "no completada"
};

// Lista de tareas es un array de objetos
let listaTareas = [
    {
        nombre: "Sacar al gato a paser",
        descripcion: "",
        completada: false,
    },
    {
        nombre: "Sacar la ropa",
        descripcion: "",
        completada: true,
    },
    {
        nombre: "Limpiar los platos",
        descripcion: "",
        completada: false,
    }
];

function mostrarTarea(tarea) {
    return `[${tarea.completada ? "x" : " "}] ${tarea.nombre} (${tarea.descripcion})`
}

function mostrarLista(lista) {
    for (let i = 0; i < lista.length; i++) {
        console.log(mostrarTarea(lista[i]))
    }
}

mostrarLista(listaTareas);
console.log(mostrarTarea(tarea));