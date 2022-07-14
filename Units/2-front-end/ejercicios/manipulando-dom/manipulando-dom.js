// console.log(document.body);
// console.log(document.children[0].children[0].children[1].innerHTML);

// let aguacate = document.getElementById("elemento-3");

// Escritura por consola
// console.log(aguacate.innerText);

// Escritura en el html
// aguacate.innerText = "hola que tal";

/*
setTimeout(() => {
    aguacate.innerText = "hola que tal";
}, 3000)

setInterval(() => {
    aguacate.innerText = i++;
}, 1000)
*/

// Cambiar las variables en el html desde el javascript
let elementoUno = document.getElementById("elemento-1");
let elementoDos = document.getElementById("elemento-2");
let elementoTres = document.getElementById("elemento-3");
let elementoCuatro = document.getElementById("elemento-4");

elementoUno.innerText = "1";
elementoDos.innerText = "2";
elementoTres.innerText = "3";
elementoCuatro.innerText = "4";

let listaMagica = document.getElementById("lista-magica");
listaMagica.innerHTML = "<li> lorem </li> <li> algo </li>";

listaMagica.innerHTML = `<li> lorem </li> 
                         <li> algo </li>`;

// Le añade el último por el final
listaMagica.innerHTML += `<li> Otro </li>`

// Función para introducir números en un array
function introduceNumeros(inicio, fin) {
    let arrayNumeros = [];
    for (let i=inicio; i <= fin; i++)
    {
        arrayNumeros.push(i);
    }
    return arrayNumeros;
}

let listaNumeros = document.getElementById("lista-numeros");

// Función para escribir números dentro del elemento "lista-numeros" en el html
function escribirNumeros(arrayNumeros) {
    for (i = 0; i <= 100; i++) {
        listaNumeros.innerHTML += `<li> ${arrayNumeros[i]} </li>`;
    }
}

// arrayCeroCien = introduceNumeros(0, 100);

escribirNumeros(introduceNumeros(0, 100));