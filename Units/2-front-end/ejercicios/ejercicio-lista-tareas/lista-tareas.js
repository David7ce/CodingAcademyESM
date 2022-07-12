let tarea = {
    nombre: "Fregar la losa",
    estado: false, // "completada" "no completada"
    descripcion: "Algo",
};

// Lista de tareas es un array

console.log(tarea);
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
        nombre: "SLimpiar los platos",
        descripcion: "",
        completada: false,
    }
];

// let listaTareas = [];
console.log(listaTareas);
listaTareas.push(tarea);
console.log(listaTareas);


/*
function addTarea(tarea) {
    let listaTareas = [];
    listaTareas.push(tarea);
    return listaTareas;
}
*/