/*
function esDivisible(numero, divisor) {
    return numero % divisor === 0;
}

for (let i = 1; i <= 100; i++) {
    if (esDivisible(i, 3) && esDivisible(i, 5)) {
        console.log("FizzBuzz");
    }
    else if (esDivisible(i, 3)) {
        console.log("Fizz");
    }
    else if (esDivisible(i, 5)) {
        console.log("Buzz");
    }
    else {
        console.log(i);
    }
}
*/

function esDivisible(numero, divisor) {
    return numero % divisor === 0;
}

let lista = document.getElementById("resultado-fizzbuzz");

for (let i = 1; i <= 100; i++) {
    if (esDivisible(i, 3) && esDivisible(i, 5)) {
        lista.innerHTML += `<li> FizzBuzz </li>`
    }
    else if (esDivisible(i, 3)) {
        lista.innerHTML += `<li> Fizz </li>`
    }
    else if (esDivisible(i, 5)) {
        lista.innerHTML += `<li> Buzz </li>`
    }
    else {
        lista.innerHTML += `<li> ${i} </li>`;
    }
}
