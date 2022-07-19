- Empezamos con JavaScript

```js
console.log("Hello world!");

var CONSTANTES = 10;

let b = 10;

```

- Las variables no llevan tipo
- Las constantes
- JavaScript auto-convierte los números, si no es texto saldría NaN (Not a Number)
- El parámetro de una función puede ser un número, texto u otra función
- Solo hay un tipo de número (enteros y dobles son lo mismo), 
- Solo hay números con decimales

```js
var v = true;
var v2 = false;
var n1 = -5;
var vacio = [];
var emojis = [👍, 👎, 🤙, 🖐];
var numeros = [1, 2, 3, 4, 5];
var letras = [a, b , c, d]; // array de letras
var cosas = [true, 4, "adiso"];
var listas = [vacio, emojis, numeros, letras, cosas];

let variable = [];

console.log(emojis);

/*
shift()
unshift()

pop()
push()
*/
```

## Funciones para añadir o quitar elementos dentro de un array

- shift() elimina el primer elemento de un array
- unshift() añade un elemento al principio del array

- pop() elimina el último elemento del array
- push() añade un elemento al final del array

---

## Plantilla literal

---

## Herramientas del DOM
```js
document.getElementById("");
document.getElementsByClassName("");
document.querySelectorAll()
```

---

Activar pulsar teclas por pantalla:
"Screencast Mode" en VS Code

---

## Ejercicios

## 19/07/2022
active-tab

## Programación funcional
- Prgramación funcioanl, de más alto nivel más fácil para las personas.

- La idea que es que los programas están compuestos de funciones, la función entra o sale algo y no muta.

- JS lenguaje de programación multiparadigma, programación funcional, programación imperativa.

- Las variables no se mutan, no se les cambia el valor, el valor es siempre el mismo
- Funciones de primera clase
- Y usar callback

- Función pura, la misma entrada da siempre la misma salida, es decir es predecible, no tiene efectos secundarios, más fácil de comprobar si hacen bien su trabajo.

Entrada de la función es los argumentos, y la salida es el return.

Una función no modifica nada que no sea su retorno.

