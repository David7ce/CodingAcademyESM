let contador = document.getElementById("contador");

function incremento() {
    let valor = Number(contador.innerText)
    contador.innerText = valor + 1;
}

function decremento() {
    let valor = Number(contador.innerText)
    valor = valor - 1;
    contador.innerText = valor;
}
