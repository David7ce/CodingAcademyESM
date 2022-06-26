void elegirEjercicio()
{
    Console.WriteLine(" Bienvenidx al workbook de Melany ");
    Console.WriteLine(" ");
    Console.WriteLine(" Por favor, elija entre una de las siguientes opciones para mostrar el ejercicio correspondiente: ");
    Console.WriteLine(" Ejercicio 1[1]");
    Console.WriteLine(" Ejercicio 2[2]"); 
    Console.WriteLine(" Ejercicio 3[3]");
    Console.WriteLine(" Ejercicio 4[4]");
    Console.WriteLine(" Ejercicio 5[5]");
    Console.WriteLine(" Ejercicio 6[6]");
    Console.WriteLine(" Ejercicio 7[7]");
    Console.WriteLine(" Ejercicio 8[8]");
    Console.WriteLine(" Ejercicio 9[9]");
    Console.WriteLine(" Ejercicio 10[10]");
    Console.WriteLine(" Ejercicio 11[11]");
    Console.WriteLine(" Ejercicio 12[12]");
    Console.WriteLine(" Ejercicio 13[13]");
    Console.WriteLine(" Ejercicio 14[14]");
    Console.WriteLine(" Ejercicio 15[15]");
    Console.WriteLine(" Ejercicio 16[16]");
    Console.WriteLine(" Ejercicio 17[17]");
    Console.WriteLine(" Ejercicio 18[18]");
    Console.WriteLine(" Ejercicio 19[19]");
    Console.WriteLine(" Ejercicio 20[20]");
    Console.WriteLine(" Ejercicio 21[21]");
    Console.WriteLine(" Ejercicio 22[22]");
    Console.WriteLine(" Ejercicio 23[23]");
    Console.WriteLine(" Ejercicio 24[24]");
    Console.WriteLine(" Ejercicio 25[25]");
    Console.WriteLine(" Ejercicio 26[26]");
    Console.WriteLine(" Ejercicio 27[27]");
    Console.WriteLine(" Ejercicio 28[28]");
    Console.WriteLine(" Ejercicio 29[29]");
    Console.WriteLine(" Ejercicio 30[30]");
    Console.WriteLine(" Ejercicio 31[31]");
    Console.WriteLine(" Ejercicio 32[32]");
    Console.WriteLine(" Ejercicio 33[33]");
    Console.WriteLine(" Avanzado 1[34]");
    Console.WriteLine(" Avanzado 2[35]");
    
}
elegirEjercicio();

int ejercicio = Convert.ToInt32(Console.ReadLine());
switch (ejercicio)
{
    case 1:
        {
            Console.WriteLine("Has elegido el Problema 1");
            Console.WriteLine("Solicitar 5 números por consola y mostrar su media");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio1()
                {
                    Console.WriteLine("Dime cinco números ");
                    string[] numeros = new string[5];
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        numeros[i] = Console.ReadLine();
                    }
                    double[] respuestaNumero = new double[numeros.Length];
                    for (int i = 0; i < respuestaNumero.Length; i++)
                    {
                        respuestaNumero[i] = Convert.ToDouble(numeros[i]);
                    }
                    Console.WriteLine("La media de los números escritos es: " +
                    (respuestaNumero[0] + respuestaNumero[1] + respuestaNumero[2] + respuestaNumero[3] + respuestaNumero[4]) / numeros.Length);
                }
                ejercicio1();
            } else
            {
                elegirEjercicio();
            }

        }
        break;
    case 2:
        {
            Console.WriteLine("Has elegido el Problema 2");
            Console.WriteLine("Ingresar un número y mostrar el cuadrado del mismo. El número debe ser mayor que cero, " +
            "en caso de que no lo sea que aparezca el mensaje : ERROR. Introducir el número de nuevo y se solicite la entrada de nuevo.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio2()
                {
                    double raiz;
                    do
                    {
                        Console.WriteLine("Pon un número: ");

                        string numeroRaiz = Console.ReadLine();
                        raiz = Convert.ToDouble(numeroRaiz);
                        if (raiz <= 0)
                        {
                            Console.WriteLine("ERROR. Introducir el número de nuevo: ");
                        }

                    }
                    while (raiz <= 0);
                    Console.WriteLine(Math.Sqrt(raiz));
                }
                ejercicio2();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 3:
        {
            Console.WriteLine("Has elegido el Problema 3");
            Console.WriteLine("De 10 números introducidos por consola indicar cuántos son mayores a cero y cuántos son menores a cero.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {

                void ejercicio3()
                {
                    Console.WriteLine("Dame 10 números ");
                    string[] numbers = new string[10];
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = Console.ReadLine();
                    }
                    double[] n = new double[numbers.Length];
                    int numerosPositivos = 0;
                    int numerosNegativos = 0;
                    for (int i = 0; i < n.Length; i++)
                    {
                        n[i] = Convert.ToDouble(numbers[i]);
                        if (n[i] < 0)
                        {
                            numerosNegativos++;
                        }
                        else if (n[i] > 0)
                        {
                            numerosPositivos++;
                        }
                    }
                    Console.WriteLine("Tienes " + numerosNegativos + "números negativos y " + numerosPositivos + " números positivos");
                }
                ejercicio3();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 4:
        {
            Console.WriteLine("Has elegido el Problema 4");
            Console.WriteLine("Diseñar un algoritmo que calcule la longitud de la circunferencia y el área del círculo de radio " +
                "solicitado por consola.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio4()
                {
                    Console.WriteLine("Escribe el radio del círculo: ");
                    double circulo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Escribe el radio de la circunferencia; ");
                    double circunferencia = Convert.ToDouble(Console.ReadLine());

                    double areaCirculo = Math.Truncate(Math.PI * circulo * circulo * 100) / 100;
                    double longCircunferencia = Math.Truncate(2 * Math.PI * circunferencia * 100) / 100;

                    Console.WriteLine("La longitud de la circunferencia es " + longCircunferencia + " y el área del círculo es " + areaCirculo);
                }
                ejercicio4();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 5:
        {
            Console.WriteLine("Has elegido el Problema 5");
            Console.WriteLine("Diseñar un programa que calcule la superficie de un triángulo a partir de recoger por consola " +
                "las dimensiones de su base y altura y muestre el resultado.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio5()
                {
                    Console.WriteLine("Escribe la base del triángulo: ");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Escribe la altura del triángulo: ");
                    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

                    double superficieT = Math.Truncate((baseTriangulo * alturaTriangulo / 2) * 100) / 100;

                    Console.WriteLine("La superficie del triángulo es: " + superficieT);
                }
                ejercicio5();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 6:
        {
            Console.WriteLine("Has elegido el Problema 6");
            Console.WriteLine("Ingresar un número e indicar si es positivo o negativo");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio6()
                {
                    Console.WriteLine("Dime un número: ");
                    double number = Convert.ToDouble(Console.ReadLine());

                    if (number > 0)
                    {
                        Console.WriteLine(number + " es positivo");
                    }
                    else
                    {
                        Console.WriteLine(number + " en negativo");
                    }

                }
                ejercicio6();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 7:
        {
            Console.WriteLine("Has elegido el Problema 7");
            Console.WriteLine("Mostrar si un número introducido por consola es par o impar.");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio7()
                {
                    Console.WriteLine("Introduce un número ");
                    double numero = Convert.ToDouble(Console.ReadLine());

                    if (numero % 2 == 0)
                    {
                        Console.WriteLine(numero + " es par");
                    }
                    else
                    {
                        Console.WriteLine(numero + " es impar");
                    }
                }
                ejercicio7();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 8:
        {
            Console.WriteLine("Has elegido el Problema 8");
            Console.WriteLine("Equivalencia de Grados Celsius con Grados Fahrenheit");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio8()
                {
                    Console.WriteLine("Escribe los grados en Celsius: ");
                    double Celsius = Convert.ToDouble(Console.ReadLine());

                    double transformarAFahrenheit(double Celsius)
                    {
                        return Celsius * 9 / 5 + 32;
                    }
                    Console.WriteLine(transformarAFahrenheit(Celsius));

                }
                ejercicio8();

            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 9:
        {
            Console.WriteLine("Has elegido el Problema 9");
            Console.WriteLine("Equivalencia de centímetros con pies y pulgadas");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio9()
                {
                    Console.WriteLine("Escribe los centímetros: ");
                    double centimetros = Convert.ToDouble(Console.ReadLine());

                    double transformarAPies(double centimetros)
                    {
                        return centimetros / 30.48;
                    }
                    Console.WriteLine(transformarAPies(centimetros));
                }
                ejercicio9();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 10:
        {
            Console.WriteLine("Has elegido el Problema 10");
            Console.WriteLine("Pedir por consola una frase y mostrar cuántas vocales tiene");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio10()
                {
                    Console.WriteLine("Escribe una frase: ");
                    string frase = Console.ReadLine();

                    bool esVocal3(char letra)
                    {
                        string vocales = "aeiouAEIOU";
                        return vocales.Contains(letra);
                    }
                    int contador = 0;
                    for (int i = 0; i < frase.Length; i++)
                    {
                        if (esVocal3(frase[i]))
                        {
                            ++contador;
                        }
                    }
                    Console.WriteLine("El texto contiene " + contador + " vocales");
                }
                ejercicio10();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 11:
        {
            Console.WriteLine("Has elegido el Problema 11");
            Console.WriteLine("Mostrar en pantalla una lista de opciones con los días de la semana. " +
                "Para elegir uno se debe introducir el número correspondiente.Una vez se ha introducido un número mostrar la opción elegida");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio11()
                {
                    string[] diaSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
                    Console.WriteLine("Selecciona un día de la semana: ");
                    for (int i = 0; i < diaSemana.Length; i++)
                    {
                        Console.WriteLine("[" + (i + 1) + "]" + diaSemana[i]);
                    }
                    Console.WriteLine("Tu selección: ");
                    int seleccion = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Has elegido el " + diaSemana[seleccion - 1]);
                    while (seleccion > 7)
                    {
                        Console.WriteLine("Debe ser un número del 1 al 7");
                        Console.WriteLine("Elige otro número:");
                        seleccion = Convert.ToInt32(Console.ReadLine());
                    }
                }
                ejercicio11();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 12:
        {
            Console.WriteLine("Has elegido el Problema 12");
            Console.WriteLine("Mostrar los números impares entre el 0 y el 100.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio12()
                {
                    bool esImpar(int numeros)
                    {
                        if ((numeros % 2) == 1)
                            return true;
                        else
                        {
                            return false;
                        }
                    }
                    for (int i = 0; i <= 100; i++)
                    {
                        if (esImpar(i))
                        {
                            Console.Write(i + " - ");
                        }

                    }
                }
                ejercicio12();

            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 13:
        {
            Console.WriteLine("Has elegido el Problema 13");
            Console.WriteLine("Mostrar los números pares entre el 0 y el 100.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {

                void ejercicio13()
                {
                    bool esPar(int numeros)
                    {
                        if ((numeros % 2) == 0)
                            return true;
                        else
                        {
                            return false;
                        }
                    }
                    for (int i = 0; i <= 100; i++)
                    {
                        if (esPar(i))
                        {
                            Console.Write(i + " - ");
                        }
                    }
                }
                ejercicio13();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 14:
        {
            Console.WriteLine("Has elegido el Problema 14");
            Console.WriteLine("Mostrar los números del 0 al 100.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio14()
                {
                    for (int j = 0; j <= 100; j++)
                    {
                        Console.Write(j + " - ");
                    }
                }
                ejercicio14();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 15:
        {
            Console.WriteLine("Has elegido el Problema 15");
            Console.WriteLine("Mostrar los números del 100 al 0");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio15()
                {
                    for (int h = 100; h >= 0; --h)
                    {
                        Console.Write(h + " - ");
                    }

                }
                ejercicio15();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 16:
        {
            Console.WriteLine("Has elegido el Problema 16");
            Console.WriteLine("Mostrar los múltiplos de 3 del 0 al 100");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio16()
                {
                    bool multiploDeTres(int number)
                    {
                        if (number % 3 == 0)
                            return true;
                        else
                        {
                            return false;
                        }
                    }
                    for (int i = 0; i <= 100; i++)
                    {
                        if (multiploDeTres(i))
                        {
                            Console.Write(i + "...");
                        }
                    }
                }
                ejercicio16();

            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 17:
        {
            Console.WriteLine("Has elegido el Problema 17");
            Console.WriteLine("Mostrar los múltiplos de 3 y de 2 entre el 0 y 100.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio17()
                {
                    bool multiploDeDosyTres(int number)
                    {
                        if (number % 3 == 0 & number % 2 == 0)
                            return true;
                        else
                        {
                            return false;
                        }
                    }
                    for (int i = 0; i <= 100; i++)
                    {
                        if (multiploDeDosyTres(i))
                        {
                            Console.Write(i + " **");
                        }
                    }
                }
                ejercicio17();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 18:
        {
            Console.WriteLine("Has elegido el Problema 18");
            Console.WriteLine("Ingresar un número y mostrar la suma de los números que lo anteceden.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio18()
                {
                    Console.Write("Escribe un número: ");
                    int numero4 = Convert.ToInt32(Console.ReadLine());

                    int sumar = 0;
                    for (int i = 0; i < numero4; i++)
                    {
                        sumar = sumar + i;
                    }
                    Console.WriteLine("Total: " + sumar);
                }
                ejercicio18();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 19:
        {
            Console.WriteLine("Has elegido el Problema 19");
            Console.WriteLine("Mostrar los números del 1 hasta el número ingresado.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio19()
                {
                    Console.Write("Escribe un número: ");
                    int numero5 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= numero5; i++)
                    {
                        Console.WriteLine(i);
                    }

                }
                ejercicio19();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 20:
        {
            Console.WriteLine("Has elegido el Problema 20");
            Console.WriteLine("Contar los múltiplos de 3 desde 1 hasta un número que ingresamos.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio20()
                {
                    Console.WriteLine("Escribe un número: ");
                    int respuestaNumero = Convert.ToInt32(Console.ReadLine());

                    int resultado = 0;
                    for (int i = 1; i <= respuestaNumero; i++)
                    {
                        resultado++;
                        if (resultado % 3 == 0)
                        {
                            Console.Write(resultado + " , ");
                        }
                    }

                }
                ejercicio20();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 21:
        {
            Console.WriteLine("Has elegido el Problema 21");
            Console.WriteLine("Mostrar los números primos entre el 0 y 100.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio21()
                {
                    bool esPrimo(int numero)
                    {
                        for (int i = 2; i < numero; i++)
                        {
                            if ((numero % i) == 0)
                                return false;
                        }
                        return true;
                    }
                    for (int i = 2; i <= 100; i++)
                    {
                        if (esPrimo(i))
                        {
                            Console.Write(i + " - ");
                        }
                    }
                }
                ejercicio21();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 22:
        {
            Console.WriteLine("Has elegido el Problema 22");
            Console.WriteLine("Ingresar 10 números sumar los positivos y multiplicar los negativos.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio22()
                {
                    int numeroPositivo = 0;
                    int numeroNegativo = 0;

                    int[] positivos = new int[10];
                    int[] negativos = new int[10];

                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write("Numero: ");
                        int numeroRespuesta = Convert.ToInt32(Console.ReadLine());

                        if (numeroRespuesta < 0)
                        {
                            negativos[numeroNegativo] = numeroRespuesta;
                            numeroNegativo++;
                        }
                        if (numeroRespuesta > 0)
                        {
                            positivos[numeroPositivo] = numeroRespuesta;
                            numeroPositivo++;
                        }
                    }
                    int totalSuma = positivos.Sum();

                    Console.WriteLine("El total de los números positivos sumados es = " + totalSuma);
                }
                ejercicio22();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 23:
        {
            Console.WriteLine("Has elegido el Problema 23");
            Console.WriteLine("Ingresar dos números e intercambiarlos.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio23()
                {
                    Console.Write("Escribe un número: ");
                    int numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Escribe otro número: ");
                    int numero2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(numero2 + " y " + numero1);
                }
                ejercicio23();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 24:
        {
            Console.WriteLine("Has elegido el Problema 24");
            Console.WriteLine("Ingresar un número y mostrar su cuadrado y cubo.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio24()
                {
                    Console.Write("Escribe un número: ");
                    double rNumero = Convert.ToDouble(Console.ReadLine());

                    double cuadrado = Math.Pow(rNumero, 2);
                    double cubo = Math.Pow(rNumero, 3);

                    Console.WriteLine("El cuadrado de " + rNumero + " es " + cuadrado + " y el cubo es " + cubo);
                }
                ejercicio24();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 25:
        {
            Console.WriteLine("Has elegido el Problema 25");
            Console.WriteLine("Introducir por consola el peso de 5 personas y mostrar la cantidad de personas " +
                "que pesan más de 80 kg y menos de 80 kg.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio25()
                {
                    int contador1 = 0;
                    int contador2 = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("Escribe el peso de las personas: ");
                        double peso = Convert.ToDouble(Console.ReadLine());

                        if (peso > 80)
                        {
                            ++contador1;
                        }
                        if (peso < 80)
                        {
                            int resultado2 = contador2;
                            ++contador2;
                        }
                    }
                    Console.WriteLine(contador1 + " personas pesan más de 80kg " + contador2 + " personas pesan menos de 80kg");
                }
                ejercicio25();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 26:
        {
            Console.WriteLine("Has elegido el Problema 26");
            Console.WriteLine("Ingresar la longitud de los 3 lados de un triángulo y decir qué clase de triángulo es. " +
                "Para formar un triángulo hay que tener en cuenta que la suma de la longitud de sus dos lados más cortos debe " +
                "ser mayor que la longitud de su lado más largo.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio26()
                {
                    string tipoDeTriangulo(double lado1, double lado2, double lado3)
                    {

                        if (lado1 == lado2 & lado2 == lado3)
                        {
                            return " equilatero";
                        }
                        if (lado1 != lado2 & lado2 != lado3 & lado1 != lado3)
                        {
                            return " escaleno";
                        }
                        else
                        {
                            return " isósceles";
                        }
                    }

                    bool esTriangulo(double lado1, double lado2, double lado3)
                    {
                        return lado1 + lado2 > lado3 &
                               lado1 + lado3 > lado2 &
                               lado2 + lado3 > lado1;
                    }

                    Console.Write("Escribe el primer lado: ");
                    double lado1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Escribe el segundo lado: ");
                    double lado2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Escribe el tercer lado: ");
                    double lado3 = Convert.ToDouble(Console.ReadLine());

                    if (esTriangulo(lado1, lado2, lado3))
                    {
                        string resultado = tipoDeTriangulo(lado1, lado2, lado3);
                        Console.WriteLine("El triángulo es " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Eso no es un triángulo");
                    }
                }
                ejercicio26();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 27:
        {
            Console.WriteLine("Has elegido el Problema 27");
            Console.WriteLine("Dados 3 números donde el primero y el último son límites de un intervalo, " +
                "indicar si el tercero pertenece a dicho intervalo.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                Console.WriteLine("Hola");
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 28:
        {
            Console.WriteLine("Has elegido el Problema 28");
            Console.WriteLine("Por teclado se ingresa el valor hora de un empleado. Posteriormente se ingresa " +
                "el nombre del empleado, la antigüedad en años y la cantidad de horas trabajadas en el mes.Se pide " +
                "calcular el importe a cobrar teniendo en cuenta que al total que resulta de multiplicar el valor " +
                "hora por la cantidad de horas trabajadas, hay que sumarle la cantidad de años trabajados multiplicados" +
                " por 30, 00 €, y al total de todas esas operaciones restarle el 13 % en concepto de retenciones. " +
                "Imprimir el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en " +
                "bruto, el total de retenciones y el valor neto a cobrar.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                Console.WriteLine("Hola");
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 29:
        {
            Console.WriteLine("Has elegido el Problema 29");
            Console.WriteLine("Realizar la tabla de multiplicar de un número entre 0 y 10 de forma que se " +
                "visualice de la siguiente forma: 4x1 = 4.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio29()
                {
                    Console.Write("Escriba un número para mostrar sus tablas de multiplicar: ");
                    int numeroMultiplicacion = Convert.ToInt32(Console.ReadLine());
                    for (int n = 0; n <= 10; n++)
                    {
                        Console.WriteLine(numeroMultiplicacion + "x" + n + " = " + (numeroMultiplicacion * n));
                    }
                }
                ejercicio29();

            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 30:
        {
            Console.WriteLine("Has elegido el Problema 30");
            Console.WriteLine("Solicitar 2 números por consola, imprimir los números naturales que hay entre " +
                "ambos empezando por el más pequeño, contar cuántos números hay y cuántos de ellos son pares.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio30()
                {
                    Console.Write("Numero 1: ");
                    int numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Numero 2: ");
                    int numero2 = Convert.ToInt32(Console.ReadLine());
                    int suma = 0;
                    for (int i = numero1; i <= numero2; i++)
                    {
                        suma = suma + i;
                    }
                    Console.WriteLine("Total: " + suma);
                }
                ejercicio30();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 31:
        {
            Console.WriteLine("Has elegido el Problema 31");
            Console.WriteLine("Se ingresa por teclado la cantidad de agua caída, en milímetros día a día durante un mes. " +
                "Se pide determinar el día de mayor lluvia, el de menor y el promedio.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                Console.WriteLine("Hola");
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 32:
        {
            Console.WriteLine("Has elegido el Problema 32");
            Console.WriteLine("Hacer el algoritmo que imprima el mayor y el menor de una serie de 5 números " +
                "que vamos introduciendo por teclado");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void ejercicio32()
                {
                    int max = int.MinValue;
                    int min = int.MaxValue;

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Introduzca un número: ");
                        int numero3 = Convert.ToInt32(Console.ReadLine());
                        if (numero3 > max)
                        {
                            max = numero3;
                        }
                        if (numero3 < min)
                        {
                            min = numero3;
                        }
                    }
                    Console.WriteLine(min + " / " + max);
                }
                ejercicio32();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 33:
        {
            Console.WriteLine("Has elegido el Problema 33");
            Console.WriteLine("Crear un problema que solicite por consola el nombre de una persona seguido de una coma y su edad.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
               Console.WriteLine("Hola");
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 34:
        {
            Console.WriteLine("Has elegido el Problema Avanzado 1");
            Console.WriteLine("Crear un programa que reciba como entrada por consola una frase. " +
                "El programa deberá retornar dicha entrada como una cadena de puntos(.) y guiones(-)");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void traductorAMorse()
                {
                    char[] abecedario = {'A', 'B','C','D','E','F','G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O','P', 'Q', 'R', 'S','T',
    'U', 'V', 'W', 'X', 'Y', 'Z',' ', '1','2','3','4','5','6','7','8','9','0',':',',',';','¿','?' };

                    string[] codigoMorse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..",  "--",
    "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."," ", ".----", "..---",
    "...--","....-",".....","-....","--...","---..","----.","-----","---...", "--..--","-.-.-.","..--..","..--.." };

                    Console.Write("Escribe una frase: ");
                    string frase = (Console.ReadLine()).ToUpper();

                    Console.Write("Esta es su frase en código Morse: ");
                    foreach (char letra in frase)
                    {
                        int indice = Array.IndexOf(abecedario, letra);
                        if (indice != -1)
                        {

                            Console.Write(codigoMorse[indice] + "  ");
                        }
                        else
                        {
                            Console.WriteLine("No te hemos entendido");
                        }
                    }
                }
                traductorAMorse();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    case 35:
        {
            Console.WriteLine("Has elegido el Problema Avanzado 2");
            Console.WriteLine("Implementar un programa que obtenga los factores primos de un número introducido por consola.");
            Console.WriteLine("¿Desea continuar? Sí (S) No (N)");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" | respuesta == "s")
            {
                void FactorizarNumero()
                {
                    Console.WriteLine("Escribe un número para calcular sus factores primos: ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    int x = 2;
                    while (numero != 1)
                    {
                        if (numero % x == 0)
                        {
                            Console.Write(x + " · ");
                            numero = (numero / x);
                        }
                        else x++;
                    }
                }
                FactorizarNumero();
            }
            else
            {
                elegirEjercicio();
            }

        }
        break;
    default:
        {
            Console.WriteLine("No existe esta opción");
        }
        break;
}