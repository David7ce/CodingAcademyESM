## Javascript

- Empezamos con JavaScript

## Variables
- Las variables no llevan tipo
- Las constantes se escriben como const
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

const PI = 3.141592653589793;

console.log(emojis);
```

## Funciones para añadir o quitar elementos dentro de un array
- shift() elimina el primer elemento de un array
```js
const fruits = ["Banana", "Orange", "Apple", "Mango"];
fruits.shift();
```

- unshift() añade un elemento al principio del array
```js
const fruits = ["Banana", "Orange", "Apple", "Mango"];
fruits.shift();
```

- pop() elimina el último elemento del array
```js
const fruits = ["Banana", "Orange", "Apple", "Mango"];
fruits.pop();
```

- push() añade un elemento al final del array
```js
const fruits = ["Banana", "Orange", "Apple", "Mango"];
fruits.push("Kiwi");
```

## Herramientas del DOM

- Formas para llamar a los elementos del HTML en el DOM
```js
document.getElementById("botonera");
document.getElementsByClassName("clase-persona");
document.querySelectorAll(h1)  // Se usa css
```

_Para activar pulsar teclas por pantalla: "Screencast Mode" en VS Code_

## Programación funcional
- La programación funcioanl, de más alto nivel más fácil para las personas. La idea que es que los programas están compuestos de funciones, la función entra o sale algo y no muta. JS lenguaje de programación multiparadigma, programación funcional, programación imperativa. Las variables no se mutan, no se les cambia el valor, el valor es siempre el mismo
Funciones de primera clase y usar callback.

- Función pura, la misma entrada da siempre tiene la misma salida, es decir es prescindible, no tiene efectos secundarios, es más fácil de comprobar si hacen bien su trabajo. Entrada de la función es los argumentos, y la salida es el return.

- [Función flecha](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Functions/Arrow_functions)
```js
(x => { return a})

const materials = [ 'Hydrogen', 'Helium', 'Lithium', 'Beryllium' ];

console.log(materials.map( material => material.length ));
// expected output: Array [8, 6, 7, 9]


// 1. Remove the word "function" and place arrow between the argument and opening body bracket
(a) => {
  return a + 100;
}

// 2. Remove the body braces and word "return" — the return is implied.
(a) => a + 100;
(a, b) => a + b + 100;


// 3. Remove the argument parentheses
a => a + 100;

// Traditional Anonymous Function
(function (a, b) {
  return a + b + 100;
})

// Arrow Function (no arguments)
const a = 4;
const b = 2;
() => a + b + 100;

// Traditional Anonymous Function (no arguments)
const a = 4;
const b = 2;
(function () {
  return a + b + 100;
})

```
- Función map viene integrada (.map)
```js
 array.map(function(currentValue, index, arr), thisValue)
```

- ForEach
```js
const fruits = ["apple", "orange", "cherry"];
fruits.forEach(myFunction);
```

- "".toLocaleLowerCase minúsculaes según el tipo de tecaldo en local
```js
const fruits = ["apple", "orange", "cherry"];
fruits.forEach(myFunction);
```

## API

- Funciones asíncronas

- Buscar datos con fetch

## Clase de instalación de nodejs, eslint extensión y eslint (2022-07-26)

Para instalar el linter de JavaScript, es decir el corrector de sintaxis y código debemos hacer los siguientes pasos:

1. Insalar [nodejs](https://nodejs.org/en/) en el ordenador
  - Mediante un [instalador de paquetes](https://nodejs.org/en/download/package-manager/#windows-1)
    - Linux: `pacman -S nodejs-lts-fermium nodejs-lts-gallium`
    - Mac: `brew install node`
    - WIndows: instalar archivo .exe `winget nodejs` o `choco install nodejs.install`
  - Con el instalador o compilando y ejecutando los archivos de nodejs  

2. Instalar eslint via npm (node package manager) y como extensión de VSCode
    1. `npm install eslint --save-dev`
    2. Configurar el eslint: 
	    - Inicializar `npm init @eslint/config`
		- Eslint: (check syntax) | check syntax and find problems| check syntax find problems enforce code style
		- Modules: (esm) | js modules | common js
		- Project's framework: (none) | React | Vue.js
		- Typescrypt: (no) | yes
		- Code runs on: (browser) | node
		- Style for project: (guide) |
		- Style to follow: (google) | airbnb | standard
		- Format of config file: (JSON) | JS | YAML
  	3. Instalar la extensión Eslint en VS Code
  	4. Si subimos los cambios a GitHub, se recomienda excluir las dependencias en el gitignore y añadirlas ejecutando el comando `npm install` que instala las dependencias listadas en el eslintrc.json.

Además podemos instalar la herramienta de JavaScript Vite JS con el instalador de paquetes de node (npm)
1. Usamos npm: `npm init @eslint/config`
	- Project name: vite-project 
	- Select a framework: "vanilla | vue | react | preact | lit | svelte"
	- Select a variant: vanilla | vanilla-ts
2. Seguir las instrucciones:
	```sh
	cd vite-project
	npm install
	npm run dev
	```

