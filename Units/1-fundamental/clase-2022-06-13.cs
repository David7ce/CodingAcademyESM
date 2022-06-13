// Último día de clase de C#
// recursividad

int sumarHastaFor(int n)
{
    int acumulado = 0;

    for (int i = 0; i <= n; i++)
    {
        acumulado += i;
    }
    return acumulado;
}

int sumarHastaRecursividad(int n)
{
    if (n == 0)
        return 0;
    return sumarHastaRecursividad(n - 1) + n;
}

Console.WriteLine("sumar hasta for de 10 " + sumarHastaFor(10));
Console.WriteLine("sumar hasta for de 10 " + sumarHastaRecursividad(10));

int factorial(int n)
{
    if (n < 0)
    {
        return -1;
    }
    if (n == 0)
    {
        Console.WriteLine("El factorial de 0 es 1.");
        return 1;
    }
    Console.WriteLine("El factorial de " + n + " es " + (n-1) + "! * " + n);
    return factorial(n - 1) * n;
}

Console.WriteLine(factorial(6));

void saludar(int n)
{
    Console.WriteLine("Hola" + n);
    saludar(n + 1);
}

// saludar(1);

// --------------------------------------------------------
// Se alternan las funciones
/*
void flip()
{
    Console.WriteLine("Flip");
    flop();
}

void flop()
{
    Console.WriteLine("Flop");
    flip();
}

flip();
*/

/*
using System;
using System.Collections.Generic;
namespace Ejemplo_listas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> listaEnteros = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                listaEnteros.Add("hola");
            }
            Console.WriteLine(listaEnteros.Count);     // Cuantos elementos hay
            Console.WriteLine(listaEnteros.Capacity);  // Cuantos cabe
        }

    }
}
*/

/*
using System;
using System.Collections.Generic;
namespace Ejemplo_listas
{
    public class Program
    {
        static void pintar(char[,] t)
        {
            for (int x = 0; x < t.GetLength(0); x++)
            {
                for (int y = 0; y < t.GetLength(0); y++)
                {
                    Console.WriteLine(t[x, y]);
                }
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            char[,] tablero = new char[8, 8];

            for(int x= 0; x < tablero.GetLength(0); x++)
            {
                for(int y = 0; y < tablero.GetLength(1); y++)
                {
                    tablero[x, y] = '#';
                }
            }
            pintar(tablero);
        }

    }
}
*/