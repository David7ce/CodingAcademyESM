/* Crear una función que calcule porcentaje de un número
/* Se llama porcentaje
/* Va devolver un double
/* Recibe un número del que calcular su porcentaje
/* Recibe un núnero que representa  el porcentaje a calcular.
/* Ejemplo: el 20% de 300. (300 * 20)/100
 */
double calcularPorcentaje (double numero, double operador)
{
	double resultado = numero * (operador / 100);
	return resultado;
}
double valorPorcentaje = 7.0;
double numOrigen = 150.0;

Console.WriteLine("El {0}% de {1} es {2}", valorPorcentaje, numOrigen, calcularPorcentaje(valorPorcentaje, numOrigen));


// Crear una funcíón que calcule el área de un círculo
double calcularAreaCirculo (double radio)
{
	double resultado = 3.14*radio*radio;
	return resultado;
}

double radio1 = 2.0;

Console.WriteLine("EL área del círculo de radio {0} es {1}", radio1, calcularAreaCirculo(radio1));

// Crear una función que introduzca el nombre
string introduceNombre (string nombre, string apellidos)
{
	string salida = "Mi nombre es " + nombre + ", " + apellidos;
	return salida;
}

string nombre1 = "David";
string apellido1 = "Alonso";
Console.WriteLine(introduceNombre(nombre1, apellido1));


/* Función que reciba el nombre y la edad de una persona y la saluda
 * Argumentos: nombre (string), edad (int)
 * Retorno: frase final (string)
 * Ejemplo:
 * Conosole.WriteLine(saludar("Marce",38)
 * > Hola Marce, tienes 38 años.
 */
string saludarPersona(string nombre, int edad)
{
	string final = "Hola " + nombre + ", tiene " + edad + " años.";
	return final;
}
string saludo = saludarPersona("Marce", 38);
Console.WriteLine(saludo);

// Crear una función que dado un número devuelva el número multiplicado por 100
// Entradas: el número. El número es un entero (int)
// Salidas: el número multiplicado por 100
int multiplicaPor100 (int numero)
{
	//int resultado = numero * 100;
	return numero*100;
}
 Console.WriteLine(multiplicaPor100 (5));
 
/**
int suma(int num1, int num2)
{
	return num1 + num2;
}
int resultadoSuma = suma(4, 5);
Console.WriteLine(resultadoSuma);

void decirAlgo(string texto)
{
	Console.WriteLine(texto);
}
          
string prueba = "esto es un test";
decirAlgo("hola");
decirAlgo(prueba);

double areaTriangulo(double baseT, double alturaT)
{
    double resultadoFinal = (baseT * alturaT)/2;
    return resultadoFinal;
}

double triangulo1 = areaTriangulo(4.0, 6.0);
double triangulo2 = areaTriangulo(123.3, 321.3);

Console.WriteLine("El área del triángulo 1 es {0} y del trinágulo 2 es {1}", (triangulo1, triangulo2));
 **/

int cuadrado (int numero)
{
	int resultado = numero * numero;
	return resultado;
}

int num = 10;
int numCuadrado = cuadrado(num);

Console.WriteLine("El cuadrado de " + num + " es " + numCuadrado);
Console.WriteLine("El cuadrado de {0} es {1}", num, numCuadrado);
/* Crear una función que calcule porcentaje de un número
/* Se llama porcentaje
/* Va devolver un double
/* Recibe un número del que calcular su porcentaje
/* Recibe un núnero que representa  el porcentaje a calcular.
/* Ejemplo: el 20% de 300. (300 * 20)/100
 */
double calcularPorcentaje (double numero, double operador)
{
	double resultado = numero * (operador / 100);
	return resultado;
}
double valorPorcentaje = 7.0;
double numOrigen = 150.0;

Console.WriteLine("El {0}% de {1} es {2}", valorPorcentaje, numOrigen, calcularPorcentaje(valorPorcentaje, numOrigen));


// Crear una funcíón que calcule el área de un círculo
double calcularAreaCirculo (double radio)
{
	double resultado = 3.14*radio*radio;
	return resultado;
}

double radio1 = 2.0;

Console.WriteLine("EL área del círculo de radio {0} es {1}", radio1, calcularAreaCirculo(radio1));

// Crear una función que introduzca el nombre
string introduceNombre (string nombre, string apellidos)
{
	string salida = "Mi nombre es " + nombre + ", " + apellidos;
	return salida;
}

string nombre1 = "David";
string apellido1 = "Alonso";
Console.WriteLine(introduceNombre(nombre1, apellido1));


/* Función que reciba el nombre y la edad de una persona y la saluda
 * Argumentos: nombre (string), edad (int)
 * Retorno: frase final (string)
 * Ejemplo:
 * Conosole.WriteLine(saludar("Marce",38)
 * > Hola Marce, tienes 38 años.
 */
string saludarPersona(string nombre, int edad)
{
	string final = "Hola " + nombre + ", tiene " + edad + " años.";
	return final;
}
string saludo = saludarPersona("Marce", 38);
Console.WriteLine(saludo);

// Crear una función que dado un número devuelva el número multiplicado por 100
// Entradas: el número. El número es un entero (int)
// Salidas: el número multiplicado por 100
int multiplicaPor100 (int numero)
{
	//int resultado = numero * 100;
	return numero*100;
}
 Console.WriteLine(multiplicaPor100 (5));
 
/**
int suma(int num1, int num2)
{
	return num1 + num2;
}
int resultadoSuma = suma(4, 5);
Console.WriteLine(resultadoSuma);

void decirAlgo(string texto)
{
	Console.WriteLine(texto);
}
          
string prueba = "esto es un test";
decirAlgo("hola");
decirAlgo(prueba);

double areaTriangulo(double baseT, double alturaT)
{
    double resultadoFinal = (baseT * alturaT)/2;
    return resultadoFinal;
}

double triangulo1 = areaTriangulo(4.0, 6.0);
double triangulo2 = areaTriangulo(123.3, 321.3);

Console.WriteLine("El área del triángulo 1 es {0} y del trinágulo 2 es {1}", (triangulo1, triangulo2));
 **/

int cuadrado (int numero)
{
	int resultado = numero * numero;
	return resultado;
}

int num = 10;
int numCuadrado = cuadrado(num);

Console.WriteLine("El cuadrado de " + num + " es " + numCuadrado);
Console.WriteLine("El cuadrado de {0} es {1}", num, numCuadrado);
