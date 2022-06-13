using System;

public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();   // Crear el objeto de la clase Program
        p.ejercicioBuscar();             // Llamando al método
    }

    void ejercicioOperacionLogica()
    {
        Console.WriteLine("Expected true " + (true | true));   // Verdadero
        Console.WriteLine("Expected true " + (true | false));  // Verdadero
        Console.WriteLine("Expected false " + (false | false));  // Falso
        Console.WriteLine("Expected true " + (false | true));  // Verdadero

        Console.WriteLine("Expected true " + (true & true));  // Verdadero
        Console.WriteLine("Expected false " + (true & false));  // Falso
        Console.WriteLine("Expected false " + (false & false));  // Falso
        Console.WriteLine("Expected false " + (false & true));  // Falso
    }

    // 5. Diseñar un programa que calcule la superficie de un triángulo a partir de recoger por consola las dimensiones de su base y altura y muestre el resultado.
    void ejercicioBuscar()
    {
        int buscarIndice(string[] lista, string nombre)
        {
            int resultado = -1; // Definimos el contador a -1, como un resultado no encontrado
            int contador = 0;
            while (resultado == -1 & contador < lista.Length)
            {
                if (nombre == lista[contador])
                {
                    resultado = contador;
                }
                contador++;
            }
            return resultado;
        }

        string[] listaNombres = { "Alicia", "Bernardo", "Carmen", "Darío", "Elisa" };
        int[] saldos = { 100, 200, -10, 80, 300 };

        Console.Write("Dime un nombre que quieras buscar: ");
        string nombreSolicitado = Console.ReadLine();

        int indice = buscarIndice(listaNombres, nombreSolicitado);

        if (indice != -1)
        {
            Console.WriteLine("Saldo de la persona indicidada: " + saldos[indice]);
        }
        else
        {
            Console.WriteLine("No tenemos a este usuario.");
        }
    }

    // Ejercicio 26. Triángulos
    void ejercicioTriangulos()
    {
        string tipoTriangulo (double ladoA, double ladoB, double ladoC)
        {
            // string[] tipoTriangulo = {""}

            if (ladoA == ladoB & ladoB == ladoC)
            {
                return "Equilátero";
            }
            if (ladoA != ladoB & ladoB != ladoC & ladoA != ladoC)
            {
                return "Escaleno";
            }
            return "Isósceles";

        }

        bool esTriangulo (double ladoA, double ladoB, double ladoC)
        {
            return ladoA + ladoB > ladoC &
                ladoA + ladoC > ladoB &
                ladoB + ladoC > ladoA;
        }

        Console.Write("Escribe el priemr lado: ");
        double ladoA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escribe el segundo lado: ");
        double ladoB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escribe el tercer lado: ");
        double ladoC = Convert.ToDouble(Console.ReadLine());

        if (esTriangulo(ladoA, ladoB, ladoC))
        {
            string resultado = tipoTriangulo(ladoA, ladoB, ladoC);
            Console.WriteLine("El triángulo es " + resultado);
        }
    }

    void ejercicioTriangulosArrays()
    {
        bool esTriangulo(double[] lados)
        {
            return lados[0] + lados[1] > lados[2] &
                lados[0] + lados[2] > lados[1] &
                lados[1] + lados[2] > lados[0];
        }

        string tipoTriangulo (double[] lados)
        {
            if (lados[0] == lados[1] & lados[0] == lados[2])
            {
                return "Equilátero";
            }
            if (lados[0] != lados[1] & lados[0] != lados[2] & lados[1] != lados[2])
            {
                return "Escaleno";
            }
            return "Isósceles";
        }

        double [] candidatoTriangulo = new double[3];

        for (int i = 0; i < candidatoTriangulo.Length; i++)
        {
            Console.Write("Lado " + (i + 1) + ": ");
            candidatoTriangulo[i] = Convert.ToDouble(Console.ReadLine());
        }
        if (esTriangulo(candidatoTriangulo))
        {
            Console.WriteLine("El triángulo es " + tipoTriangulo(candidatoTriangulo));
        }
        else
        {
            Console.WriteLine("No es un triángulo.");
        }
    }
    ejercicioTriangulosArrays();
}