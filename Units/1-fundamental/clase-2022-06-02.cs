/* Ejercicio 1.
 * Crear un método o funcíón.
 * Recibe un texto, un entero.
 * Retorna un texto.
 * El retorno es un texto con entrada de texto repetida un número de veces.
 * Ejemplo "hola" y 5 retorna "HolaHolaHolaHolaHola".
 */ 
string repetirTexto(string texto, int repeticiones)
{
    string resultado = "";
    for (int i = 0; i < repeticiones; i++)
    {
        resultado = resultado + texto; // resultado += texto;
    }
    return resultado;
}

Console.WriteLine(repetirTexto("Hola", 5));


/* Ejercicio 2.
 * Crear un método o funcíón.
 * Recibe un texto, un entero.
 * Retorna un texto.
 * El retorno es un texto con entrada de texto repetida un número de veces.
 * Ejemplo "hola" y 5 retorna "HolaHolaHolaHolaHola".
 */
int multiplicarConSuma(int parametroUno, int parametroDos)
{
    int result = 0;
    for (int i = 0; i < parametroDos; i++)
    {
        result += parametroUno; // result += parametroUno;
    }
    return result;
}

Console.WriteLine(multiplicarConSuma(2, 3));

// Uso de void, función que no retorna nada. Función impura. Se puede usar para aislar ejercicios.
void contador(int inicio, int final)
{
    int n = inicio;
    while (n < final)
    {
        Console.WriteLine(n);
        n++;
    }
}

contador(0, 10);

// Uso de void con la función contador ya sea con while o un bucle for
void contador()
{
    int n = 0;
    while (n < 10)
    {
        Console.WriteLine(n);
        n++;
    }
}

void contadorFor()
{
    for (int n = 0; n < 10; n++)
    {
        Console.WriteLine(n);
    }
}

contador();
contadorFor();

// Ejercicio con un función dentro de otra
void ejercicioFuncionDoble()
{
    int duplicar(int n)
    {
        return n * 2;
    }
    Console.Write("Dime un número: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Tu número duplicado es " + duplicar(numero));
}

ejercicioFuncionDoble();

/* Ejercicio adivinanzas
 * Crear un programa que nos escriba por consola "Oro parece plata no es."
 * Leer una respuesta por consola. Si es correcta escirbir "Correcto!".
 * Si no es correcta escirbir "Vuelve a intentarlo, te quedan N oportunidades" y leer otra respuesta. Decrementar N.
 * Si N llega a 0 escribir "Lo siento, no lo has conseguido".
 */
void adivinanza(int intentos)
{
    while (intentos != 0)
    {
        Console.WriteLine("Oro parece plata no es. ¿Qué es?");
        string respuesta = Console.ReadLine();

        if (respuesta == "platano")
        {
            intentos = 0;
            Console.WriteLine("¡Correcto!");
        }
        else
        {
            intentos--; // intentos = intentos - 1;
            if (intentos != 0)
            {
                Console.WriteLine("Vuelve a intentarlo, te quedan {0} oportunidad/es.", intentos);
            }
            else
            {
                Console.WriteLine("Se acabaron los intentos.");
            }
        }
    }
}

adivinanza(2);


/* Ejercicio FIZZBUZZ
 * Crear un programa que escriba por consola los números del 1 al 100, pero sustituyendo algunos números por palabras siguiendo las siguientes reglas especiales:
 * · Si el número es divisible por 3, escribir FIZZ.
 * · Si el número es divisible por 5, escribir BUZZ.
 * · Si el número es divisible por 3 y por 5, escribir FIZZBUZZ.
 */
/*
void fizzbuzz()
{
    for (int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0 & i % 5 == 0)
        {
            Console.WriteLine("FIZZBUZZ");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("FIZZ");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("BUZZ");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}
*/

void fizzbuzz()
{
    for (int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0)
        {
            Console.WriteLine("FIZZ");

            if (i % 5 == 0)
            {
                Console.WriteLine("FIZZBUZZ");
            }
        }
        else
        {
            if (i % 5 == 0)
            {
                Console.WriteLine("BUZZ");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}

fizzbuzz();

// Función números pares
void sumaPares()
{
    int resultado = 0;

    for (int i = 1; i <= 100; i++)
    {
        if (i % 2 == 0)
        {
            resultado = resultado + i;
        }
    }
}

factorial();

// Función del factorial
void factorial()
{
    int resultado = 1;
    for (int i = 1; i <= 100; i++)
    {
        resultado = resultado * i;
    }
    Console.WriteLine(resultado);
}

factorial();

// Números más grandes
void size()
{
    Console.WriteLine(Int16.MinValue + " hasta " + Int16.MaxValue);
    Console.WriteLine(Int32.MinValue + " hasta " + Int32.MaxValue);
    Console.WriteLine(Int64.MinValue + " hasta " + Int64.MaxValue);
    Console.WriteLine(double.MinValue + " hasta " + double.MaxValue);
    Console.WriteLine(float.MinValue + " hasta " + float.MaxValue);
    Console.WriteLine(decimal.MinValue + " hasta " + decimal.MaxValue);
}