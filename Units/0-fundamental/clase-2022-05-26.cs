// Clase 2022-05-26

/*
// Definimos una frase al principio
string frase = "Buenos días";

// Contains es un método que sirve para encontrar una variable dentro de una variable especificada, por ejemplo frase
// Console.WriteLine(frase.Contains("os dí"));

// Imprime por pantalla la posición 10 del tipo de variable frase, el primer elemento se define como 0
int posicion = 10;
Console.WriteLine("En la posición {0} hay una {1}", posicion, frase[posicion]);

// IndexOf método para encontrar el índice de un caracter
char letra = 'a';
int indice = frase.IndexOf(letra);

Console.WriteLine("La letra {0} está en la posición {1}", letra, indice);

string diasSemana = "Lunes Martes Miercoles Jueves Viernes";

// Posicion donde empieza la cadena "Miercoles"
int valor = diasSemana.IndexOf("Miercoles");

// ¿Qué letra hay a la derecha de la primera M?
int posicionLetra = indice + 1;

char letraSalida = diasSemana[posicionLetra];

Console.WriteLine("A la derecha de la {0} hay una {1}", letra, letraSalida);
*/

/*
string datos = "Alicia:34"; //"JuanAlberto:444"

int posicionDosPuntos = datos.IndexOf(":");

// Substring método para cortar un string
string parteNumerica = datos.Substring(posicionDosPuntos+1);
string nombre = datos.Substring(0, posicionDosPuntos);

Console.WriteLine("Su nombre es {0} y su edad {1} años.", nombre, parteNumerica);

// abecedario
string abecedario = "abcdefghijklmnñopqrstuvwxyz";
string recorte = abecedario.Substring(10, 10);

Console.WriteLine(recorte);

// Función para usar en el cifrado
// A -> E, B -> F, C -> G, D -> H, E -> I, F -> J, G -> K ...

// Defino dos letras
char letraA = 'a';
char letraB = 'b';
char letraE = 'e';
char letraF = 'f';

char cifrado(char letra)
{
    string alfabeto = "abcdefghijklmnñopqrstuvwxyz";
    string alfabetoClave = "efghijklmnñoprstuvwxyzabcd";

    int posicion = alfabeto.IndexOf(letra);
    
    return alfabetoClave[posicion];
}

char descifrado(char letra)
{
    string alfabeto = "abcdefghijklmnñopqrstuvwxyz";
    string alfabetoClave = "efghijklmnñoprstuvwxyzabcd";

    int posicion = alfabetoClave.IndexOf(letra);  // posición de la letra especificada de la cadena de texto alfabetoClave

    return alfabeto[posicion];
}


Console.WriteLine("-- Palabra cifrada --");
Console.WriteLine("El cifrado de {0} es {1}", letraA, cifrado(letraA));
Console.WriteLine("El cifrado de {0} es {1}", letraB, cifrado(letraB));
Console.WriteLine("\n"); // Separa un línea con WriteLine y otra con \n
Console.WriteLine("-- Palabra descifrada --");
Console.WriteLine("El descifrado de {0} es {1}", letraE, descifrado(letraE));
Console.WriteLine("El descifrado de {0} es {1}", letraF, descifrado(letraE));
*/

/* Función que recibe un texto del formato
 * "Nombre:Edad"
 * y retorna solo la edad.
 * Por ejemplo edad("Bernardo:14)
 * > 14
 */

/*

string mostrarEdad(string datosPersona)
{
    char dosPuntos = ':';  // caracter único para realizar el cálculo
    int posicionDosPuntos = datosPersona.IndexOf(dosPuntos) + 1;
    string edad = datosPersona.Substring(posicionDosPuntos); // cadena de texto que se corta desde la siguiente posicion de los dos puntos hasta el final
    return edad;
}

Console.WriteLine("La edad de Bernardo es {0}", mostrarEdad("Bernardo:14"));

string mostrarNombre(string datosPersona)
{
    char dosPuntos = ':';  // caracter único para realizar el cálculo
    int posicionDosPuntos = datosPersona.IndexOf(dosPuntos);
    string nombre = datosPersona.Substring(0, posicionDosPuntos);
    return nombre;
}

Console.WriteLine("El nombre es {0}", mostrarNombre("Alberto:42"));


// Longitud de una cadena
string frase = ("En UN LUgar de LA mancha").ToUpper();
Console.WriteLine(frase);

// frase = frase.ToUpper();

Console.WriteLine(frase + "tiene " + frase.Length + " caracteres");
Console.WriteLine(frase.ToUpper());  // pasar a mayúsculas
Console.WriteLine(frase.ToLower());  // pasar a minúsculas

Console.WriteLine(frase.ToLower().Contains("mncha"));
*/


/* Crea un programa.
 * Crear un string con nuestro nombre.
 * Crear un string con el nombre de una mascota.
 * Hacer que el programa escriba por consola:
 * > "Soy {nombre} y mi mascota se llama {mascota}"
 */

/*
string miNombre = "David Alonso de Dios";
string miNombreMascota = "Picachu";
Console.WriteLine("Soy {0} y mi masscota se llama {1}.", miNombre, miNombreMascota);

// Meter el mini-programa anterior en una función
string nombrarCosas(string miNombre, string miNombreMascota)
{
    return "Soy " + miNombre + " y mi mascota se llama " + miNombreMascota + ".";
}

Console.WriteLine(nombrarCosas("David", "Pikachu"));
*/

/* Crear un string con un pedazo de texto, una frase que contenga nuestro nombre.
 * Obtener la posición en la que aparece nuestro nombre
 * Escribir por consola el texto a partir de nuesto nombre (incluído)
 */

string obtenerNombre(string texto, string nombre)
{
    int posicionNombre = texto.IndexOf(nombre);
    return texto.Substring(posicionNombre);
}

string pedazoTexto = "Esto es un pedazo de texto, te lo digo yo David Alonso.";
string nombre = "David";

Console.WriteLine(obtenerNombre(pedazoTexto, nombre));
