/* EJERCICIO 1.
 * Crear un programa que nos pregunte por consola un número.
 * Escribir por consola si el número es mayor o no que su número aribitrario, por ejemplo 6.
 */

/*
Console.WriteLine("Escribe un número por consola.");
int num = Convert.ToInt32(Console.ReadLine());

int arbitrario = 6;

if (num > arbitrario)
{
    Console.WriteLine("El número escrito por consola {0} es mayor que {1}.", num, arbitrario);          
}
else
{
    if (num == 6)
    {
        Console.WriteLine("El número escrito por consola {0} es igual a {1}.", num, arbitrario);
    }
    else
    {
        if (num < 6)
        {
            Console.WriteLine("El número escrito por consola {0} es menor que {1}.", num, arbitrario);
        }
    }
}
*/

/* EJERCICIO 2.
 * Crear un programa.
 * Pedir al usuario un primer número.
 * Pedir al usuario un segundo número.
 * Escribir por consola cual de los dos números es mayor.
 */

/*
Console.WriteLine("Escribe un número por consola");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribe un segundo número por consola");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("El número {0} es mayor que {1}", num1, num2);
}
else
{
    Console.WriteLine("El número {0} es mayor que {1}", num2, num1);
}
*/

// BUCLES.
/*
int n = 0;

// Con un número mientras n sea menor que diez se ejecuta
while (n < 10)
{
    Console.WriteLine(n);
    n++;
}
*/

// Crear un juego.
/*
//Configuración
string secreto = "Banana";

// Juego
Console.Write("Adivina la fruta: ");
string intento = Console.ReadLine();

while (intento != secreto)
{
    Console.WriteLine("Te has equivocado.");
    Console.Write("Adivina la fruta: ");
    intento = Console.ReadLine();
}

Console.WriteLine("¡Ganaste!");
*/

/* EJERCICIO 3.
 * Crear un programa que escriba por consola los números del 1 al 100.
 */

/*
Console.WriteLine("Bucle for con los números del 1 al 100.");

int numInicio = 1;
int numFinal = 100;
for (int i = numInicio; i <= numFinal; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Bucle while con los números del 1 al 100.");

int n = 1;
while (n <= numFinal)
{
    Console.WriteLine(n);
    n++;
}
*/

/* EJERCICIO 4.
 * Crear un programa que cuente en la consola desde el 1 hasta el 25, y luego desde el 25 hasta wl 1.
 */
/*
int contador = 1;
int inicio = 1;
int final = 25;

while (contador <= final)
{
    Console.WriteLine(contador);  // Console.WriteLine(contador++);
    contador++;
}

contador = contador - 1;

while (contador >= inicio)
{
    Console.WriteLine(contador);
    contador--;
}

// Martes y 13
string dia = "martes";
int numero = 1;

while (dia == "martes" & numero == 13) // & (y), | (o)
{
    Console.WriteLine("¡Mala suerte!");
}

// true = 0000 0001) , false = 0000 0000

int x = 1;

while (x < 1)
{
    Console.WriteLine(x);
    x++;
}

// do while realiza la condición al final
do
{
    Console.WriteLine(x);
    x++;
} while (x < 1);

int numeroX = 0;

while (numeroX < 100)
{
    Console.WriteLine(numeroX);
    numeroX += numeroX + 2;
}

for (int cuenta = 0; cuenta < 100; cuenta++)
{
    Console.WriteLine(cuenta);
}

string texto = "En un lugar de la mancha de cuyo nombre no quiero acordarme...";

for (int i = 0; i < texto.Length + 1; i++)
{
    Console.WriteLine(texto.Substring(0, i));
}

int masUno = 1;
masUno += 1;
int otroUno = 1;
int masOtrouno = ++otroUno;

if (masUno == variable)
{
    Console.WriteLine("masUno es igual a masOtrouno, " + masUno + " " + masOtrouno);
}
*/

int[] secuencia = { 10, 15, 99, -9, 7 };

int suma = 0;

for (int i = 0; i < secuencia.Length; i++)
{
    suma = suma + secuencia[i];
}

Console.WriteLine(suma);
