/* Compilar en VS Code.
   1. Install .NET 5.0 (https://dotnet.microsoft.com/download). Confirm installation with:
      "dotnet --version"
   2. Create a new C# project in VSCode 
      "dotnet new console -o app"
      "cd app"
      "code . # to open project in VSCode"
   3. Run Your C# Code in VSCode
      "dotnet run"
   4. Debug Your C# Code in VSCode. Install C# extension
   5. Compile your Code
      "dotnet build"
 */ 

/* Ejercicios resueltos Workbook C# 1
  - [WorkBook-1 | Replit](https://replit.com/@prueba8475/Workbook-1#main.cs)
  - Código dentro de C# (librerias en uso => espacio de trabajo => clase => función)
 */

using System;
					
public class Program
{
	static void Main(string[] args)
	{
        Program p = new Program();   // Crear el objeto de la clase Program
        //p.Ejercicio();             // Llamando al método
        Console.ReadLine();
    }

    // 1. Pide por pantalla 5 números por consola y muestra su media.
    public void Ejercicio1()
	{
        int numContador = 0;
        int cantidadNum = 5;
        decimal[] numeros = new decimal[cantidadNum];

        Console.WriteLine("Escribe " + cantidadNum + " número/s por consola.");

        while (numContador < cantidadNum)
        {
            Console.Write("Escribe un número: ");
                    
            bool numCorrecto = Decimal.TryParse(Console.ReadLine(), out decimal num);
            if (numCorrecto)
            {
                numeros[numContador] = num;
                numContador++;
            }
            else
            {
                Console.WriteLine("Error, no has escrito un número correctamente. Intentálo de nuevo.");
            }
        }

		decimal sumaTotal = 0;
        for (int i = 0; i < cantidadNum; i++)
            sumaTotal += numeros[i];

        decimal media = sumaTotal / cantidadNum;
		Console.WriteLine("La suma total es " + sumaTotal + " y la media es " +  media);
	}


    /* 2. Ingresar un número y mostrar el cuadrado del mismo. 
     * El número debe ser mayor que cero, en caso de que no lo sea que aparezca el mensaje: 
     * "ERROR. Introducir el número de nuevo." y se solicite la entrada de nuevo.
     */
	public void Ejercicio2()
	{
        Console.WriteLine("Programa para calcular el cuadrado de un número.");
        Console.Write("Introduzca un número positivo: ");

        bool numCorrecto = Double.TryParse(Console.ReadLine(), out double num);
        double numCuadrado = 0;

        if (numCorrecto & num > 0)
        {
            numCuadrado = Math.Pow(num, 2);
        }
        else
        {
            Console.WriteLine("ERROR. Introducir el número de nuevo.");
        }
            
        Console.WriteLine("El número introducido al cuadrado es " + numCuadrado);
	}

    // 3. De 10 números introducidos por consola indicar cuántos son mayores a cero y cuántos son menores a cero.
	public void Ejercicio3()
	{
        int cantidad = 10;

        // Función interna IntroducirNumero
        int numContador = 0;
        decimal[] numeros = new decimal[cantidad];

        Console.WriteLine("Escribe " + cantidad + " números por consola.");

        while(cantidad > numContador)
        {
        	Console.WriteLine("Escribe un número. Dato a introducir " + (numContador + 1));
			
            bool numCorrecto = Decimal.TryParse(Console.ReadLine(), out decimal num);
            if (numCorrecto)
            {
            	numeros[numContador] = num;
            	numContador++;
            }
            else
            {
            	Console.WriteLine("Error, no has escrito un número correctamente. Intentálo de nuevo.");
            }
      	}
        
        int positivos = 0;
        int negativos = 0;
        int ceros = 0;

        for (int posicion = 0; posicion < cantidad; posicion++)
        {
            if (numeros[posicion] != 0)
            {
                if (numeros[posicion] > 0)
                {
                    positivos++;
                }
                else
                {
                    negativos++;
                }
            }
            else
            {
                ceros++;
            }
        }
        Console.WriteLine("De los números introducidos hay " + positivos + " positivos y " + negativos + " negativos.");    
	}

    // 4. Diseñar un algoritmo que calcule la longitud de la circunferencia y el área del círculo de radio solicitado por consola.
    void Ejercicio4()
    {
        double IntroducirRadio()
        {
            double radio = 0;
            Console.WriteLine("Prgrama para calcular el área y circunferencia de un círculo.");
            bool numCorrecto = false;

            while (!numCorrecto)
            {
                Console.Write("Introduce la langitud del radio (en metros): ");
                numCorrecto = Double.TryParse(Console.ReadLine(), out radio);
                if(numCorrecto)
                    Console.WriteLine("Dato correcto.");
                else
                    Console.WriteLine("El dato introducido es erróneo, prueba otra vez.");
            }
            return radio;
        }
        void CalcularLongitudAreaCirculo(double radio)
        {
            double[] resultado = new double[2];
            double longitud = 2 * Math.PI * radio;
            double area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("Para un círculo de radio {0:F2} metros, la longitud o perímetro de la circunferencia es {1:F2} y el área del círculo es {2:F2}.", radio, longitud, area);
        }
        CalcularLongitudAreaCirculo(IntroducirRadio());
    }

    // 5. Diseñar un programa que calcule la superficie de un triángulo a partir de recoger por consola las dimensiones de su base y altura y muestre el resultado.
    void Ejercicio5()
    {
        Console.WriteLine("Programa para calcular el área de un trángulo.");

        Console.Write("Introduce la altura del triángulo (en metros): ");
        bool baseCorrecta = Double.TryParse(Console.ReadLine(), out double base0);

        Console.Write("Introduce la base del triángulo (en metros)");
        bool alturaCorrecta = Double.TryParse(Console.ReadLine(), out double altura);

        double area = altura * base0 / 2;

        Console.WriteLine("El área del triángulo de base {0} y altura {1} es {2}.", base0, altura, area);
    }

    // 6. Ingresar un número e indicar si es positivo o negativo.
    void Ejercicio6()
    {
        int IngresarNumero()
        {
            Console.WriteLine("Escribe un número por consola: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        string PositivoONegativo(int num)
        {
            string texto = "";
            if (num > 0)
            {
                Console.WriteLine("Positivo");
            }
            if (num < 0)
            {
                Console.WriteLine("Negativo");
            }
            if (num == 0)
            {
                Console.WriteLine("Cero");
            }
            return texto;
        }

        PositivoONegativo(IngresarNumero());
    }


    // 7. Mostrar si un número introducido por consola es par o impar.
    void Ejercicio7()
    {
        int IntroducirNumero()
        {
            Console.Write("Introduce un número por pantalla:");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        void numeroParOImpar(int numero)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }
        }
        numeroParOImpar(IntroducirNumero());
    }


    // 8. Equivalencia de Grados Celsius con Grados Fahrenheit


    // 9. Equivalencia de centímetros con pies y pulgadas.


    // 10. Pedir por consola una frase y mostrar cuántas vocales tiene.
    public void Ejercicio10()
    {
        bool esVocal1(char letra)
        {
            return letra == 'a' | letra == 'e' | letra == 'i' | letra == 'o' | letra == 'u' | 
                letra == 'A' | letra == 'E' | letra == 'I' | letra == 'O' | letra == 'U';
        }

        bool esVocal2(char letra)
        {
            string vocales = "AEIOUaeiou"; // char voc = { 'a', 'e', 'i', 'o', 'u' }; // string[] voc = "aeiouAEIOU".Split("");
            for (int indice = 0; indice < vocales.Length; indice++)
            {
                if (letra == vocales[indice])
                {
                    return true;
                }
            }
            return false;
        }

        bool esVocal3(char letra)
        {
            string vocales = "aeiouAEIOU";
            return vocales.Contains(letra);
        }

        Console.WriteLine("Programa para el cálculo de vocales en una frase.");
        Console.WriteLine("Escribe una frase por consola.");

        string frase = Console.ReadLine();
        int contadorVocales = 0;

        for (int posicion = 0; posicion < frase.Length; posicion++)
        {
            if (esVocal3(frase[posicion]))
            {
                contadorVocales++;
            }
        }

        Console.WriteLine("El texto contiene " + contadorVocales + " vocales");
    }


    // 11. Mostrar en pantalla una lista de opciones con los días de la semana. Para elegir uno se debe introducir el número correspondiente. Una vez se ha introducido un número mostrar la opción elegida.
    void Ejercicio11()
    {
        string[] diasSemana = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"};

        void MostrarLista(string[] diasSemana)
        {
            for (int i = 0; i < diasSemana.Length; i++)
            {
                Console.Write(i + ". ");
            }
        }

        int IntroduceNumero()
        {
            Console.WriteLine("Introduce un números por pantalla, para saber el elemento de la lista. Ejemplo (lunes = 1).");
            int indice = Convert.ToInt32(Console.ReadLine());
            return indice;
        }

        string MostrarIndiceLista(string[] lista, int indice)
        {
            string dia = lista[indice];
            return dia;
        }

        MostrarLista(diasSemana);
        IntroduceNumero();
        MostrarIndiceLista(diasSemana,IntroduceNumero());
    }

    // 12. Mostrar los números impares entre el 0 y el 100.


    // 13. Mostrar los números pares entre el 0 y el 100.


    // 14. Mostrar los números del 0 al 100.


    // 15. Mostrar los números del 100 al 0.


    // 16. Mostrar los múltiplos de 3 del 0 al 100.


    // 17. Mostrar los múltiplos de 3 y de 2 entre el 0 y 100.


    // 18. Ingresar un número y mostrar la suma de los números que lo anteceden. Por ejemplo si se introduce un 6 el resultado es 5 + 4 + 3 + 2 + 1 = 15


    // 19. Mostrar los números del 1 hasta el número ingresado.


    // 20. Contar los múltiplos de 3 desde 1 hasta un número que ingresamos.


    // 21. Mostrar los números primos entre el 0 y 100.


    // 22. Ingresar 10 números sumar los positivos y multiplicar los negativos.


    // 23. Ingresar dos números e intercambiarlos. Por ejemplo si introducimos 7 y 14, mostrar 14 y 7.


    // 24. Ingresar un número y mostrar su cuadrado y cubo.


    // 25. Introducir por consola el peso de 5 personas y mostrar la cantidad de personas que pesan más de 80 kg y menos de 80 kg.
    /* Introducir por consola el peso de 5 personas.
    * 
    * Mostrar por consola la cantidad de personas que pesan más de 80 Kg
    * Mostrar por consola la cantidad de peronas que pesan menos de 80 Kg
    */
    void Ejercicio25_1()
    {
        // función pedirPersona
        int[] pedirPesoPersona(int personas)
        {
            int contador = 0;
            int[] pesoPersonas = new int[personas];

            while (contador < personas)
            {
                Console.Write("Escribe el peso de una persona en Kg ( "+ (contador+1) + " de " + personas +"): ");

                bool pesoCorrecto = Int32.TryParse(Console.ReadLine(), out int peso);

                if (pesoCorrecto)
                {
                    pesoPersonas[contador] = peso;
                    contador++;
                }
                else
                {
                    Console.WriteLine("El peso introducido no es correcto. Inténtalo de nuevo.");
                }
            }
            return pesoPersonas;
        }

        void CantidadMayorMenor(int[] pesos)
        {
            int pesosMayores = 0;
            int pesosMenores = 0;

            for ( int i = 0; i < pesos.Length; i++)
            {
                if (pesos[i] > 80)
                {
                    pesosMayores++;
                }
                if (pesos[i] < 80)
                {
                    pesosMenores++;
                }
            }
            Console.WriteLine("Hay " + pesosMayores + " personas que pesan más de 80 Kg y " + pesosMenores + " personas que pesan menos de 80 Kg.");
        }

        CantidadMayorMenor(pedirPesoPersona(5));
    }

    void Ejercicio25_2()
    {
        int contadorMayores = 0;
        int contadorMenores = 0;
        double[] pesosMayores = new double[5];
        double[] pesosMenores = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Peso: ");
            int peso = Convert.ToInt32(Console.ReadLine());
            if (peso > 80)
            {
                pesosMayores[contadorMayores] = peso;
                contadorMayores++;
            }
            if (peso < 80)
            {
                pesosMenores[contadorMenores] = peso;
                contadorMenores++;
            }
        }

        Console.WriteLine("Pesos mayores que 80: " + contadorMayores);
        for (int i = 0; i < contadorMayores; i++)
        {
            Console.WriteLine("--> {0}", pesosMayores[i]);
        }

        Console.WriteLine("Pesos menores que 80: " + contadorMenores);
        for (int j = 0; j < contadorMayores; j++)
        {
            Console.WriteLine("--> {0}", pesosMenores[j]);
        }
    }

    // 26. Ingresar la longitud de los 3 lados de un triángulo y decir qué clase de triángulo es. Para formar un triángulo hay que tener en cuenta que la suma de la longitud de sus dos lados más cortos debe ser mayor que la longitud de su lado más largo.
    void ejercicio26()
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

    // 27. Dados 3 números donde el primero y el último son límites de un intervalo, indicar si el tercero pertenece a dicho intervalo.


    // 28. Por teclado se ingresa el valor hora de un empleado. Posteriormente se ingresa el nombre del empleado, la antigüedad en años y la cantidad de horas trabajadas en el mes. Se pide calcular el importe a cobrar teniendo en cuenta que al total que resulta de multiplicar el valor hora por la cantidad de horas trabajadas, hay que sumarle la cantidad de años trabajados multiplicados por 30,00 €, y al total de todas esas operaciones restarle el 13% en concepto de retenciones. Imprimir el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto, el total de retenciones y el valor neto a cobrar.


    /* 29. Realizar la tabla de multiplicar de un número entre 0 y 10 de forma que se visualice de la siguiente forma: 4x1=4.
    * Por ejemplo, la tabla del 5:
    * 5x1=5
    * 5x2=10
    * 5x3=15
    * …
    * 5x10=50
    */


    // 30. Solicitar 2 números por consola, imprimir los números naturales que hay entre ambos empezando por el más pequeño, contar cuántos números hay y cuántos de ellos son pares.


    // 31. Se ingresa por teclado la cantidad de agua caída, en milímetros día a día durante un mes. Se pide determinar el día de mayor lluvia, el de menor y el promedio.


    // 32. Hacer el algoritmo que imprima el mayor y el menor de una serie de 5 números que vamos introduciendo por teclado.


    // 33. Crear un problema que solicite por consola el nombre de una persona seguido de una coma y su edad. Por ejemplo  Felipe, 43   
    // Luego mostrar por consola todos los nombres y solo los nombres.



    // ##############################################################################################################################

    /*
    Avanzado 1: Traductor Morse
    Crear un programa que reciba como entrada por consola una frase. El programa deberá retornar dicha entrada como una cadena de puntos (.) y guiones (-)
    Cada grupo de puntos (.) y guiones (-) representa una letra o símbolo. Cada grupo está separado de los demás con un espacio.
    Ejempo de ejecución
    > traductor
    Texto a traducir: SOS
    Traducción: ...---...
        Cadenas de prueba
    * Hola → .... --- .-.. .-
    * Buenos dias → ... ..- . -. --- ... -.. .. .- ...
    * It's been a hard day's night, and I've been working like a dog → .. - ... -... . . -. .- .... .- .-. -.. -.. .- -.-- ... -. .. --. .... - --..-- .- -. -.. .. ...- . -... . . -. .-- --- .-. -.- .. -. --. .-.. .. -.- . .- -.. --- --.
    Más información sobre el código morse se puede encontrar en la página de wikipedia.
    Se puede utilizar este Traductor Web para validar nuestras traducciones.
    */


    /*
    Avanzado 2: Factorizar Números
    En criptografía es muy útil encontrar los factores primos de un número. Se trata de un conjunto de números primos que si son multiplicados entre sí dan como resultado el número original.
    Información en profundidad puede ser encontrada en https://es.wikipedia.org/wiki/Factor_primo
    Utilizando la descripción que ofrece este problema, wikipedia o cualquier otro recurso de internet implementar un programa que obtenga los factores primos de un número introducido por consola.
    Utilizar algún programa ya existente[2] que calcule los factores de un número para comprobar que los resultados de nuestro programa son correctos.
    */


    /*
    Avanzado 3: Aplicación de problemas
    Crear una aplicación de consola que encapsule todos los problemas de éste workbook.
    La aplicación debería mostrar un menú, listando todos los problemas contenidos. Cuando se selecciona un problema debería mostrar el enunciado y preguntar si queremos continuar o volver al menú.
    En caso de continuar, ejecutar el problema de la misma forma que en el código independiente.
    */

}
