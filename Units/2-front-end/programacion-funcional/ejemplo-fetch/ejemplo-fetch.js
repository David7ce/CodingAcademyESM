// Dos formas de recoger los datos del json y mostrarlos por consola

/*
fetch("./assets/data/datos-personas.json")
    .then(
        respuesta => {
            respuesta.json()
                .then(
                    datos => {
                        console.log(datos);
                        //
                    }
                )
        }
    );

console.log("hola");
*/
async function obtenerDatos() {
    fetch("./assets/data/datos-personas.json")
    try {
        // Se definen como constantes para que si el valor cambie avise con un error
        const respuesta = await fetch("./assets/data/datos-personas.json");
        const datos = await respuesta.json();
        console.log(datos);

        console.log("hola");
    } catch (error) {

    }
}

async function obtenerDatos() {
    const respuesta = await fetch("./assets/data/datos-personas.json")
    if (respuesta.status !== 200)
        return null;
    const datos = await respuesta.json();
    console.log(datos);
    document.getElementsByTagName(body)[0].innerHTML +=
        datos.map(
            x => `<div> ${fitst.name} </div>`
        ).join("\n");
}

obtenerDatos();
