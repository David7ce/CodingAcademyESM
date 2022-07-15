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

function mostrarPalabra() {
    
}

mostrarValor();