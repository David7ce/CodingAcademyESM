// Repaso básico de C#

// Switch

/*
void ejercicio1()
{

}

Console.WriteLine("Escoge una opción entre 1 y 5");
COnsole.Wirte("->_");
int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
    {
        Console.WriteLine("Has elegido el 1");
        ejercicio1();
    }
    break;
    case 2:
    {
        Console.WriteLine("Has elegido el 2.");
    }
    default;
}

int day = -4;

switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
}
*/

// Clase y objetos. Boyler plate
/*
using System;

namespace Objetos
{
    internal class Program
    {
        class Persona
        {
            public int edad;
            public string nombre;
            public string sexo;
            public string genero;
            public double altura;
            public double peso;
        }

        static void Main(string[] args)
        {
            Persona manolo = new Persona();  // Instanciar un clase
            manolo.nombre = "Manolo Hernándex";
            manolo.edad = 58;
            manolo.sexo = "macho";
            manolo.genero = "Varon";
            manolo.altura = 1.69;
            manolo.peso = 97;

            Console.WriteLine("Nombre: " + manolo.nombre);

            Persona[] listaPersona = new Persona[100];
        }
    }
}
*/
/*
using System;

namespace Objetos
{
    internal class Program
    {
        class Persona
        {
            public static string Saludar()
            {
                return "Hola";
            }

            public Persona(string n, int e)
            {
                nombre = n;
                edad = e;
            }
            public int edad;
            public string nombre;
        }

        class Perro
        {
            public static int indice; 

            public Perro(string nom, string raz, string col)
            {
                id = indice++;
                nombre = "Fufo";
                raza = "Labrador";
                color = "verde";
                fechaInscripcion = DateTime.Now;
            }
            public int id;
            public string nombre;
            public string raza;
            public string color;
            public DateTime fechaInscripcion;
        }

        static void Main(string[] args)
        {
            // Persona manolo = new Persona("Manolo Hernándex", 58);
            var manolo = new Persona("Manolo", 38);

            Perro p = new Perro("Fufo", "Labrador", "Verde");
            Console.WriteLine("Nombre: " + manolo.nombre);
            Console.WriteLine(Persona.Saludar());
            
        }
    }
}
*/

/*
using System;

namespace Ejercicios_Objetos
{
    internal class Program
    {
        // Crea una clase para definir una persona que guarde el nombre, DNI y si tiene carné de conducir o no

        class Persona
        {
            public string nombre;
            public string dni;
            public bool carnet;
            // Constructor una función que asigna valor a la clase en la que está con su mismo nombre
            public Persona(string nombreIn, string dniIn, bool carnetIn)  
            {
                this.nombre = nombreIn;
                this.dni = dniIn;
                this.carnet = carnetIn;
            }
            public Persona(string nombre, string dni)
            {
                this.nombre = nombre;
                this.dni = dni;
                this.carnet = false;
            }
            public Persona(string nombre)
            {
                this.nombre = nombre;
                this.dni = string.Empty;
                this.carnet = false;
            }
            public Persona()
            {
                this.nombre = string.Empty;
                this.dni = "";
                this.carnet = false;
            }
        }

        static void Main(string[] args)
        {
            // Crear lista de personas vacías
            Persona[] listaPersonas = new Persona[3];

            // Recoger los datos
            for (int i = 0; i < listaPersonas.Length; i++)
            {
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("DNI: ");
                string dni = Console.ReadLine();
                Console.Write("Tiene carnet (s/n): ");
                string opcion = Console.ReadLine();
                bool carnet = opcion == "s";

                Persona actual = new Persona(nombre, dni, carnet);

                listaPersonas[i] = actual;
            }
            // Mostrar los datos por pantalla
            for (int i = 0; i < listaPersonas.Length; i++)
            {
                Console.WriteLine("Nombre: " + listaPersonas[i].nombre);
                Console.WriteLine("DNI: " + listaPersonas[i].dni);
                Console.WriteLine("Tiene carnet: " + listaPersonas[i].carnet);
            }

            //Persona p = new Persona("Marce", "777777", true);
            //Persona g = new Persona("Juan", "88888");    // Sobrecarga por usar dos parámetros en lugar de tres
            //Persona h = new Persona("Felipe");   
            //Persona h = new Persona();  // No hay ningún constructor definido sin parámetros
        }
    }
}
*/

// Problema guardar las temepraturas
using System;

namespace Ejercicios_Objetos
{
    internal class Program
    {
        // Crea una clase para definir una persona que guarde el nombre, DNI y si tiene carné de conducir o no

        class Temepratura
        {
            private double temperaturaCentigrados;
            private DateTime horaDeRegistro;
            public double mostrarCentigrados()
            {
                return temperaturaCentigrados;
            }
            public double mostrarFarenheit()
            {
                return (temperaturaCentigrados * 9 / 5) + 32;
            }
            public void guaradarCentigrados(double t)
            {
                temperaturaCentigrados = t;
            }
            public void guardarFarenheit(double t)
            {
                temperaturaCentigrados = (t - 32) * 5 / 9;
            }

            public Temperatura()
            {
                this.temperaturaCentigrados = 0;
            }
        }

        static void Main(string[] args)
        {
            // Crear lista de personas vacías
            Temperatura t = new Temperatura();
            t.guardarFarenheit(100);
            Console.WriteLine(t.MostrarCentigrados());
        }
    }
}