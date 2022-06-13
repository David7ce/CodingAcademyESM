// Tabla de multipllicar
// 5 x 1 = 5, 5 x 2 = 10, 5 x 3 = 15

void tablaDeMultiplicar()
{
    Console.Write("Introduce un número: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i <= 10; i++)
        Console.WriteLine(numero + " x  " + i + " = " + (numero * i));
}

// Sumatorio entre dos númemros corregir
void ejercicioMisterio1()
{
    Console.Write("Número 1: ");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Número 2: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    int suma = 0;
    for (int i = numero1; i <= numero2; i++)
    {
        suma = suma + i;
    }
    Console.WriteLine(suma);
}

void ejercicioMisterio2()
{
    int maxRelativo = int.MinValue;  // Incializa así para que el valor de máximo cambie, y no se establezca como máximo absoluto
    int minRelativo = int.MaxValue;

    for (int i = 0; i < 10; i++)
    {
        Console.Write("Introduzca un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > maxRelativo)
        {
            maxRelativo = numero;
        }
        if (numero < minRelativo)
        {
            minRelativo = numero;
        }
    }
    Console.WriteLine(minRelativo + " / " + maxRelativo);
}

// Función duplicar array

int[] duplicar(int[] array1)
{
    int[] resultado = new int[array1.Length];

    for (int i = 0; i < array1.Length; i++)
    {
        resultado[i] = array1[i] * 2;
    }
    return resultado;
}

int[] testArray = { 1, 2, 3, 4, 5, 6 };
int[] arrayDuplicado = duplicar(testArray);

Console.WriteLine(String.Join(", ", arrayDuplicado));

// Copiar arrays
test.CopyTo();


// tablaDeMultiplicar();
// ejercicioMisterio1();
// ejercicioMisterio2();
// duplicar

// Valor o referencia

// Los string, enteros guardan el valor
void ejemploStrings()
{
    string x = "10";
    string y = x;
    x = "20";         // Este valor no se usa

    Console.WriteLine(y);  // Imprime por pantalla "10"
}


// Los arrays hacen referencia
void ejemploArray()
{
    string[] x = {"10", "hola", "adios"};
    string[] y = x;
    x[0] = "20";

    Console.WriteLine(y[0]);  // Imprime por pantalla "20"
    Console.WriteLine(y[2]);
}

ejemploStrings();
ejemploArray();

int[] lista = { 0, 1, 2, 3, 4, 5, 6 };

// Añadir un hueco en lista[7] = 7;, función push

int[] lista2 = new int[lista.Length + 1];

for (int i = 0; i < lista.Length; i++)
{
    lista2[i] = lista[i];
}

lista2[lista2.Length - 1] = 7;

for (int i = 0; i < lista2.Length; i++)
{
    Console.WriteLine(lista2[i]);
}


// Función para invertir
string[] invertir(string[] lista)
{
    string[] invertido = new string[lista.Length];
    for (int i = lista.Length - 1; i >= 0; i--)
    {
        // hay que hacer una transformación en el índice. En este caso que empieza por el final hay que restarle la posición
        invertido[(lista.Length - 1) - i] = lista[i];
    }
    return invertido;
}

string[] palabras = { "Primero", "Segundo", "Tercero", "Cuarto", "Quinto" };

Console.WriteLine(String.Join(", ", palabras));
Console.WriteLine(String.Join(", ", invertir(palabras)));


// Función para combinar dos arrays de enteros
int[] combinarArrays(int[] arr1, int[] arr2)
{
    int[] combinado = new int[arr1.Length + arr2.Length];

    for (int i = 0; i < arr1.Length; i++)
    {
        combinado[i] = arr1[i];
    }
    for (int j = 0; j < arr2.Length; j++)
    {
        combinado[arr1.Length + j] = arr2[j];
    }
    return combinado;
}

int[] lista1 = { 1, 2, 3, 4, };
int[] lista2 = { 90, 80, 70 };

Console.WriteLine(String.Join(", ", combinarArrays(lista1, lista2)));

// Función para representar arrays por consola
string representar(int[] lista)
{
    return "[ " + string.Join(", ", lista) + " ].";
}

int[] x = { 3, 6, 9, 12 };

Console.WriteLine(representar(x));


// .....................................
// ´Función para combertir números a texto
string[] ConvertirNumerosATexto(int[] numeros)
{
    string[] resultado = new string[numeros.Length];
    for (int i = 0; i < numeros.Length; i++)
    {
        resultado[i] = numeros[i].ToString();
    }
    return resultado;
}

int[] x = { 3, 6, 9, 12 };

Console.WriteLine(ConvertirNumerosATexto(x));
