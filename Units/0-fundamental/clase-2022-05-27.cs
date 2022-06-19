/* Crear un programa.
 * Crear un string que contenga el abecedario ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ")
 * Crear un número.
 * Mostrar por consola la letra que se encuentra en la posición que indica dicho número.
 */

char calcularLetra(int posicionLetra, string abecedario)
{
    return abecedario[posicionLetra];
}

int num = 7; // ABCDEFGH, la H es 7
string abecedario = "ABCDEFGHIJKLMÑOPQRSTUVWXYZ";
Console.WriteLine("El elemento {0} del abecedario es {1}.", num, calcularLetra(num, abecedario));

// 3 posiciones a la derecha le sumamos 3, 3 posiciones a la izquierda le restamos 3

int[] numeros = new int[] { 1, 15, 21 }; // array de enteros
int[] numDesplazar = new int[] { 3, 3, 3 }; // array de enteros de 3

Console.WriteLine("\n Bucle con posicón de las letras.");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("La posición {0} del abecedario es la letra {1}.", numeros[i], calcularLetra(numeros[i] + numDesplazar[i], abecedario));
}


/* Crear un programa.
 * Crear un string que contenga el abecedario ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ")
 * Crear un número.
 * Mostrar por consola todas las letras entre la posición indicada y 5 posiciones a su derecha.
 */
int desplazamiento = 5;
string recorteLetras = abecedario.Substring(num, num + desplazamiento);

Console.WriteLine("\n Recorte de letras entre {0} y {1} es {2}.", num, desplazamiento, recorteLetras);

// Posición de la letra del abecedario con IndexOf
char letra = 'D';
int posicionLetra = abecedario.IndexOf(letra);

Console.WriteLine("\n La posición de la letra {0} es {1}", letra, posicionLetra);

Console.WriteLine('A' + 1); // Resultado 66, char + int lo convierte en un entero
Console.WriteLine("A" + 1); // Resultado A1, string + int lo convierte en un string

// El resto de la división se calcula con el módulo x % y = z
num = 33;

Console.WriteLine("En la posición {0} está la letra {1}.", num, abecedario[num % abecedario.Length]); // Con el módulo contralas que la posición no se salga del abecedario y vuelva al inicio

// El módulo se usa para los céntimos

// Operador incremento y decremento (i++, i--)
// Operador ++i

/* Crear un programa.
 * Definir un triángulo con su base y altura.
 * Escribir en consola el área del triángulo.
 */

int[] baseTriangulo = new int[] { 1, 2, 3, 4 };
int[] alturaTriangulo = new int[] { 1, 2, 3, 4 };

double areaTraingulo(double baseTriangulo, double alturaTriangulo)
{
    return baseTriangulo * alturaTriangulo / 2;
}

Console.WriteLine("\n Área de los triángulos especificados.");

for (int i = 0; i < baseTriangulo.Length; i++)
{
    Console.WriteLine("El área del triángulo de base {0} y altrua {1} es {2}", baseTriangulo[i], alturaTriangulo[i], areaTraingulo(baseTriangulo[i], alturaTriangulo[i]));
}

// En la segunda mitad de la case se hizo un Kahoot

/* Crear un programa.
 * Crear variables para guardar las dimensiones de una caja.
 * Escribir por consola el volumend de la caja.
 */

double calcularVolumen(double lado)
{
    return lado*lado*lado;
}

int ladoN = 3;

Console.WriteLine("\n EL volumen de un cubo de lado {0} es {1}.", ladoN, calcularVolumen(ladoN));

/* Crear un programa.
 * Crear una variable para el precio de un artículo.
 * Crear una variable para el precio del envío.
 * Crear una variable para el porcentaje de impuestos.
 * Calcular el precio con impuestos.
 * Mostrar el precio con impuestos por consola.
 */

double precioArticulo = 43.95;
double precioEnvio = 13.5;
double porcentajeImpuesto = 7;

double calculoPrecioImpuestos(double articulo, double envio, double porcImpuesto)
{
    double precio = (articulo * porcImpuesto*0.01) + envio;
    double resto = (((precio * 100) % 1) * 0.01);
    double precioFinal = precio - resto;
    return precioFinal;
}

Console.WriteLine("\n El artículo vale {0} EUR, el envío cuesta {1} EUR y el impuesto que se aplica sobre el precio del artículo es {2} EUR. Por tanto el total es {3} EUR.", precioArticulo, precioEnvio, porcentajeImpuesto, calculoPrecioImpuestos(precioArticulo, precioEnvio, porcentajeImpuesto));
