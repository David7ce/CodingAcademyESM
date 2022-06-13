// Si la función recibe 5 y 8
// El resultado que espero es "El número 5 más el númemro 8 dan como resultado 13"
// Console.WriteLine(suma(5, 8));

string sumar(int num1, int num2)
{
    //int suma = num1 + num2;
    //string fraseFinal = "El número " + num1 + " más el " + num2 + " dan como resultado " + suma;
    string fraseFinal = "El número " + num1 + " más el " + num2 + " dan como resultado " + (num1 + num2);
    return fraseFinal;
}

Console.WriteLine(sumar(5, 8));

/*
int a = 1;
int b = 2;
int total = a + b;

Console.WriteLine("El número {0} más el número {1} dan como resultado {2}", a, b, total);
*/

/* Una función llamada producto que multiplica 3 números doubles
 * Ejemplo:
 * double resultado = producto (3.9, 2.0, 1.5);
 * Console.WriteLine(resultado);
 * > 11,7
 */

double producto(double num1, double num2, double num3)
{
    return num1 * num2 * num3;
}

double resultado = producto(3.9, 2.0, 1.5);
Console.WriteLine(resultado);


// Crear la función mitad
// Dado un número double nos retorna el resultado de dividir es número por dos
// Ejemplo de uso de la función mitad(5)
// 2.5
// Console.WriteLine(mitad(5));

double mitad(double dividendo)
{
    return dividendo / 2;  // multiplicar por 0.5
}

Console.WriteLine(mitad(5));


/* Función que desea feliz cumpleaños a una persona.
 * Hay que darle el nombre de la persona
 * nos devuelve una felicitación que incluye el nombre
 * Ejemplo:
 * felicitar("Marce")
 * "Feliz cumpleaños Marce"
 */

string felicitar(string persona)
{
    return "Feliz cumpleaños " + persona;
}

Console.WriteLine(felicitar("Marce"));


/* Función fecha
 * Se llama con fecha("lunes")
 * retorna "Hoy es lunes"
 */

string fecha(string dia)
{
    return "Hoy es " + dia;
}

Console.WriteLine(fecha("lunes"));