// Función par comprobar si un número es primo

// Función que recibe dos números
// Retorna True si  el número es múltiplo del segundo
/*
bool esDivisible(int numero, int divisor)
{
    return numero % divisor == 0;
}

// Retorna True si el número es un número primo (https://en.wikipedia.org/wiki/Prime_number)
bool esPrimo(int numero)
{
    if (numero <= 1)
        return false;

    // Bucle for para que recorra todos los números de dos en dos, para ahorra tiempo de ejecución
    for (int i = 2; i <= numero - 1; i = i + 2)
        if (esDivisible(numero, i))
            return false;
    return true;
}

for (int j = 2; j < 1000; j++)
if (esPrimo(j))
        Console.WriteLine(j + " es primo.");
else
    Console.WriteLine(j + " no es primo.");
*/

/* Ejercicio adivinanzas
 * Crear un programa que nos escriba por consola "Oro parece plata no es."
 * Leer una respuesta por consola. Si es correcta escirbir "Correcto!".
 * Si no es correcta escirbir "Vuelve a intentarlo, te quedan N oportunidades" y leer otra respuesta. Decrementar N.
 * Si N llega a 0 escribir "Lo siento, no lo has conseguido".
 * Escrito en 2022-06-02.cs
 */
/*
bool adivinanza(string pregunta, string secreto, int oportunidades)
{
    Console.WriteLine(pregunta);
    string respuesta = Console.ReadLine();

    while (respuesta != secreto & oportunidades > 0)
    {
        Console.WriteLine("Vuelve a intentarlo, te quedan " + oportunidades + " intentos.");
        respuesta = Console.ReadLine();
        oportunidades--;
    }

    if (respuesta == secreto)
    {
        Console.WriteLine("Correcto.");
        return true;
    }
    else
    {
        Console.WriteLine("Perdiste, no te quedan intentos.");
        return false;
    }
}

bool[] resultados = new bool[10];

resultados[0] = adivinanza("Oro parece plátano es. ¿Qué es?", "plátano", 2);
resultados[1] = adivinanza("Blanco por dentro blanco por fuera, si no sabes lo que es, espera. ¿Que es?", "pera", 2);


// Código superfluo, código redundante
int x = 10 * 1;
int y = 20 + 0;
bool z = x > y == true;
*/

// Arrays de strings
string[] diasSemana = { "Luneas", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
Console.WriteLine("Seleccione un día de la semana");

for (int i = 0; i < diasSemana.Length; i++)
{
    Console.WriteLine("[" + (i+1) + "] - " + diasSemana[i]);
}

Console.Write("Tu selección: ");

int seleccion = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Has elegido el " + diasSemana[seleccion - 1]);