function mostrarConsola() {
    let entrada = document.getElementById("entrada");
    let valor = entrada.value;
    console.log(valor);
}

function mostrarValor() {
    let entrada = document.getElementById("rango");
    let valor = entrada.value; 
    // console.log(valor); // mostrar el valor por consola
    let indicador = document.getElementById("valor-rango");
    indicador.innerText = valor;  // mostrar texto en el documento HTML, dentro del id="valor-rango"
}
mostrarValor();

function actualizarPalabra() {
    let entrada = document.getElementById("palabra");
    let valor = entrada.value;
    let valorPalabra = document.getElementById("valor-palabra");
    valorPalabra.innerText = valor;
}

function tieneNumeros(password) {
    let numeros = "1234567890".split("");
    for (let i = 0; i < numeros.length; i++) {
        if (password.includes(numeros[i])) {
            return true;
        }
    }
    return false;
}

function validarPassword() {
    let password = document.getElementById("password").value;
    let mensaje = document.getElementById("mensaje-password");
    console.log(password.length);

    if (password.length < 8 || !tieneNumeros(password)) {
        mensaje.innerText = "Contraseña poco segura (menor a 8 caracteres o no contiene números).";
    }
    else {
        mensaje.innerText = "Contraseña segura."; // no funciona
        console.log("hola");
    }
}

// Tutorial mover carpetas arrastrándolas
