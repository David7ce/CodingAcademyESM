/* Funciones matemáticas
 * Console.WriteLine(Math.Round(9.9)); // Redondea 
 * Console.WriteLine(Math.Floor(9.9)); // Función suelo o truncar
 * Console.WriteLine(Math.Ceiling(8.2)); // Función celing
 * Console.WriteLine(Math.Pow(10, 2)); // Elevear un número
 * Console.WriteLine(Math.Sqrt(25));  // Raíz cuadrada de un número
 * Console.WriteLine(Math.PI);   // Número pi
 */

/*
double n = 5;
double nCuadrado = Math.Pow(n, 2);

// Recoger entrada de usuario

Console.WriteLine("¿Hola cómo te llamas?: ");
string respuesta = Console.ReadLine();

Console.WriteLine("Hola " + respuesta);
Console.WriteLine("¿Cuántos años tienes?: ");

// Al convertir a double tener en cuenta que en la consola la notación es la correspondiente al idioma. Ejemplo si tenemos el sistema operativo en español, los números decimales en consola son 22,456 y en ingles´22.456
double edad = Convert.ToDouble(Console.ReadLine());  
edad++;

Console.WriteLine("Hola " + respuesta + "tienes " + edad + " años.");
*/

/* EJERCICIO 1.
 * Crear un programa.
 * Solicitar el nombre de un artículo por consola.
 * Solicitar el precio de un artículo por consola.
 * Solicitar el precio del envío del articulo por consola.
 * Solicitar el porcentaje de impuestos por consola.
 * Mostrar el nombre de un artículo y su precio total con impuestos por consola.
 * > Vía Romana Mencia : 10,45 €
 */

/*
Console.WriteLine("Escriba el nombre de un artículo: ");
string articulo = Console.ReadLine();

Console.WriteLine("Escriba el precio de un artículo: ");
double precio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escriba el precio del envío: ");
double precioEnvio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escriba el porcentaje del impuesto: ");
double porcentajeImpuesto = Convert.ToDouble(Console.ReadLine());

// Función para el cálculo del precio de un producto con el impuesto del precio del producto 
double calcularPrecio(double precioProducto, double precioEnvio, double porcenImpuesto)
{
    // double impuesto = (precioProducto) * porcenImpuesto * 0.01; // Impuesto al precio inicial
    double impuesto = (precioProducto + precioEnvio) * porcenImpuesto * 0.01; // Impuesto al precio con envío
    double precioTotal = precioProducto + precioEnvio + impuesto;
    return precioTotal;
}

Console.WriteLine("{0}: {1} EUR.", articulo, calcularPrecio(precio, precioEnvio, porcentajeImpuesto));
*/

// Arrays

/*
int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
string[] dias = { "lunes", "martes", "miercoles", "jeuves", "viernes" };
double[] temperaturas = { 14.3, 21.5 };

Console.WriteLine(dias[2]);

string[] nombres = { "Alicia", "Blas", "Carmen" };
double[] saldos = { 1234.3, 1233.2, 1112.1 };
int[] edad = { 45, 28, 32 };

int indice = 0;

Console.WriteLine(nombres[indice] + " tiene " + edad[indice] + " años y su saldo es " + saldos[indice]);

int[] numerosCeros = { 0, 0, 0, 0, 0 }; 
int[] arrayCeros = new int[5];

Console.WriteLine(numerosCeros[0] == arrayCeros[0]);

Console.WriteLine("Primer número");
numeros[0] = Convert.ToInt32(Console.ReadLine());

// Función Join
string[] palabras = { "lunes", "martes", "miercoles", "jueves", "viernes" };
string respuesta = String.Join("Separador", palabras);
Console.WriteLine(respuesta);
*/

/* Crear un programa.
 * Crear una sola variable que guarde las 3 dimensiones de una caja
 * Establecer cada dimensión por separado.
 * Escribir por consola el volumen de la caja.
 */
/*
double[] ladosXYZ = new double[3]; // array con de lados con valores incializados a cero

Console.WriteLine("Introduce los valores de la caja.");
Console.Write("El ancho es: ");
ladosXYZ[0] = Convert.ToDouble(Console.ReadLine());

Console.Write("El alto es: ");
ladosXYZ[1] = Convert.ToDouble(Console.ReadLine());

Console.Write("El largo es: ");
ladosXYZ[2] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Rsultado: el ancho es {0}, el alto es {1}, el largo es {2}" + ladosXYZ[0], ladosXYZ[1], ladosXYZ[2]);

Console.WriteLine("El volumen de la caja es {0}.", ladosXYZ[0] * ladosXYZ[1] * ladosXYZ[2]);
*/

string[] nombre = { "zanahoria", "harina", "tomates", "aguacate", "agua" };
double[] precios = { 12.0, 1.4, 22.1, 11.2, 4.2 };

for (int i = 0; i < nombre.Length; i++)
{
    Console.WriteLine(nombre[i] + ": " + precios[i]);
}

// Condicionales: If

string diaDomingo = "domingo";

if (diaDomingo == "domingo") // dia == "domingo"
{
    Console.WriteLine("Menos mal que es domingo");
}
else
{
    Console.WriteLine("Aun no es domingo");     
}
Console.WriteLine("Esto simpre sale");

string diaFin = "domingo";

if (diaFin.ToUpper() == "Domingo".ToUpper())
{
    Console.WriteLine("Es domingo.");
}

string a = "A";
string B = "B";

bool comparar(string a, string b)
{
    return a.ToUpper() == b.ToUpper();
}

// Elemntos comparativos denttro de una sentencia if: ==, !=, >, < >, >=, <=


bool esPar(int n)
{
    return n % 2 == 0;
}

if (esPar(5))
{
    Console.WriteLine("El número es par");
}
else
{
    Console.WriteLine("El número es impar");
}

/*
string[] nombre = { "zanahoria", "harina", "tomates", "aguacate", "agua" };
double[] precios = { 12.0, 1.4, 22.1, 11.2, 4.2 };

for (int i = 0; i < nombre.Length; i++)
{
    Console.WriteLine(nombre[i] + ": " + precios[i]);
}

// Condicionales: If

string diaDomingo = "domingo";

if (diaDomingo == "domingo") // dia == "domingo"
{
    Console.WriteLine("Menos mal que es domingo");
}
else
{
    Console.WriteLine("Aun no es domingo");     
}
Console.WriteLine("Esto simpre sale");

string diaFin = "domingo";

if (diaFin.ToUpper() == "Domingo".ToUpper())
{
    Console.WriteLine("Es domingo.");
}

string a = "A";
string B = "B";

bool comparar(string a, string b)
{
    return a.ToUpper() == b.ToUpper();
}
*/

// Elemntos comparativos denttro de una sentencia if: ==, !=, >, < >, >=, <=

/*
bool esPar(int n)
{
    return n % 2 == 0;
}

if (esPar(5))
{
    Console.WriteLine("El número es par");
}
else
{
    Console.WriteLine("El número es impar");
}

string diaX = "lunes";
int numeroX = 13;

if (diaX == "martes")
{
    if (numeroX == 13)
    {
        Console.WriteLine("Mierda, es martes 13.");
    }
    else
    {
        Console.WriteLine("Hoy no es día 13.");
    }
}
else
{
    Console.WriteLine("Hoy no es martes");
}

*/

// EJERCICIO.
// Crear un programa que nos pregunte por consola un día de la semana.
// Si el día es "viernes" escribir por consola "¡Por fin es viernes!"
// Si el día es "lunes escribir por consola "Ya llegó el lunes.."

Console.WriteLine("¿Qué día de la semana es?");
string dia = Console.ReadLine();

if (dia.ToLower() == "viernes")
{
    Console.WriteLine("¡Por fin es viernes!");
}
else
{
    Console.WriteLine("No es viernes.");
}

if (dia.ToLower() == "lunes")
{
    Console.WriteLine("¡Ya llegó el lunes!");
}
else
{
    Console.WriteLine("No es lunes.");
}
