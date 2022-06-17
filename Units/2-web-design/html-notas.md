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