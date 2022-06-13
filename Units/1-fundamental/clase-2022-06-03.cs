/* Viernes 3 de juion 2022. 
 * Ejercicio 1. 
 * Palíndromo un texto que se lea igual por delante que por detrás.
 * Dividir el ejercicio en dos partes.
 * 1. Dar la vuelta al texto.
 * 2. Comprobar si la frase es palíndromo.
 */

string darVueltaTexto(string entradaTexto)
{
    string respuesta = "";
    for (int i = entradaTexto.Length - 1; i >= 0; i--)
    {
        respuesta += entradaTexto[i];
    }
    return respuesta;
}

Console.WriteLine(darVueltaTexto("Hola mundo"));

bool comprobarPalindromo(string texto)
{
    return texto == darVueltaTexto(texto);
}

Console.WriteLine(comprobarPalindromo("ABB BBA"));


/* Ejercicio 2.
 * Crear un programa que muestre por consola todos los números de la sucesión de Fibonacci menores que 2000.
 */

void sucesionFibonacci()
{
    int prePreNum = 0;  // Número previo al previo, anterior al anterior
    int preNum = 1; // Número previo, número anterior
    int actual = 0;

    while (preNum < 2000)
    {
        Console.WriteLine(prePreNum); // (prePreNum + ", " + preNum);
        actual = prePreNum + preNum;
        prePreNum = preNum;
        preNum = actual;
    }
}

sucesionFibonacci();

// Intercambiar números
int a = 10;
int b = 52;

int c = a;  // Variable de paso para mantener el valor de a en otra variable

a = b;
b = c;

// Si fuese a = b = 52; b = a = 52; a != 10;


// Generar números aleatorios
void Aleatorios()
{
    var random = new Random();
    string texto = "abcdef"; // la longitud de texto es de 6 elementos. (texto.Length = 6)

    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine(random.Next() % texto.Length); // % 99 Genera un número entre 0 y 99, debido al resto de dividr entre 100
    }
}

Aleatorios();


/* Crear un programa con un array de 100 números vacíos.
 * Utilizar un bucle while para llenar el array, en todas las posiciones escribir un número aleatorio.
 * Recorrer el array y escribir por consola cada índice:
 *  · El ínidice 0 es igual 218356520
 *  · El índice 1 es igual a 1736126118
 *  · etc.
 * ¡No mostrar los valores directamente, guardarlos en un array primero!
 */

void arrayAleatorio()
{
    var aleatorio = new Random();
    int[] arrayNum = new int[100];
    int num = 0;

    while (num < arrayNum.Length)
    {
        arrayNum[num] = aleatorio.Next();
        num++;
    }

    for (int i = 0; i < arrayNum.Length; i++)
    {
        Console.WriteLine(arrayNum[i]);
    }
}

arrayAleatorio();