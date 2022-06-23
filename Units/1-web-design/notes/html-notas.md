# HTML notas

- Para las negritas se usa <span> </span> en lugar de <strong> </strong>

- Centrar imágenes con una caja externa  (div, pictrure) o creando un bloque en css display:block;

- Con un div para ajusta el ancho.
```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
		body {
			padding: 0;
			margin: 0;
			background-color:  rgb(255, 0, 0);
		}
		img {
			width: 100%;
			height: auto;
		}
		.avatar {
			display: block;
			width:  100px;
			border-radius:  50%;
		}
		.transparente1 {
			background-image:  url("avatar.jpp");
			background-size:  cover;
			height:  400px;
			width:  400px;
			filter:  opacity(0.5) grayscale(0.3);
		}

		.transparente1:hover {
			filter:  grayscale(0);
			transition:  filter 2s;
		}

	</style>
</head>
<body>
	<div class="trasnparente1"> </div>

    <picture class="avatar">
        <img src="./avatar.jpg" alt="">
    </picture>
</body>
</html>
```

- Poner dos columnas.

- Layout dos columnas.

- Justify content (en vertical)

- Allign content (en horizontal)

---

Clase 2022-06-14
# Lenguaje de marcs (HTML y CSS)

## Etiquetas HTML

## Introducción a HTML
- Encabezados  (h1, h2, h3...)
- Párrafos  <p> <br>
- Hyperlinks <ol> <ul> <li>
- Listas <little>
- Head y body <head> <body>

## Introducción a CSS

## Clase del miércoles 15 de Junio de 2022
Se empezó con CSS.

## Clase del jueves 16 de Junio de 2022
Se empezó a hacer un curriculum en HTML

# Clase del viernes 17 de Junio de 2022
- Se practicó CSS y HTML trabajando sobre un curriculum modificando el contenido.

<!-- Centrar imagen como bloque o centrando un un div-->
´´´css
img {
    display:block;
    margin-left: auto;
    margin-rigth: auto;
}
´´´
---

Clase 2022-06-14

## Aprender a usar Git
- Instalar git, configurar y usar comandos.
- Crear HTML con comandos de git

´´´css
* {
    box-sizing: border box;
}
´´´

Cuando no pones wrap como el flex es flesible se estrecha.
Si no caben ponlas debajo.

Para hacer un banner responsivo con un flex

´´´css
flex-wrap: wrap;
flex-wrap: wrap-reverse;
flex-direction: row;
´´´

- [Cambio de tamaño de cajas](./web-pages/html-test/box-sizing.html)

- Se puede usar calc()