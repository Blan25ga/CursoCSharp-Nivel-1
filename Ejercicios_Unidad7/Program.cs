// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        //! Declaracion de vector de enteros con 5 posiciones
        int[] v = new int[5];

        // Cargar valores en el vector usando un bucle
        for (int x = 0; x < v.Length; x++)
        {
            Console.Write("Ingrese un número para la posición " + x + ": ");
            v[x] = int.Parse(Console.ReadLine()); // guardamos el número en la posición x!
        }
        //* Recorremos el vector y mostramos cada valor junto con su índice.
        Console.WriteLine("Valores cargados en el vector:");
        for (int x = 0; x < v.Length; x++)
        {
            Console.WriteLine("Posición " + x + ": " + v[x]);
        }

        int suma = 0;
        for (int x = 0; x < v.Length; x++)
        {
            suma += v[x]; // acumulamos cada número
        }
        Console.WriteLine("\nLa suma total es: " + suma);
        //La suma nos sirve para calcular porcentajes.

        Console.WriteLine("\nPorcentaje de cada número respecto al total:");

        for (int x = 0; x < 5; x++)
        {
            // calculamos el porcentaje de forma básica
            double porcentaje = v[x] * 100.0 / suma;

            Console.WriteLine("Número " + v[x] + " → " + porcentaje + "%");
        }

        ////////-----------///////////
        //EJEMPLOS 2

        //int (long, short)
        //float --- double ---decimal

        // Vectores para guardar temperaturas de 31 días
        double[] muestraMatutina = new double[31];
        double[] muestraVespertina = new double[31];
        double[] muestraNocturna = new double[31];

        int dia;
        double temperatura;

        // --- Carga de datos matutinos ---
        Console.WriteLine("Ingresa datos Matutinos");
        for (int x = 0; x < 31; x++)
        {
            Console.Write("Ingrese día (1 a 31): ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Ingrese temperatura registrada: ");
            temperatura = double.Parse(Console.ReadLine());

            muestraMatutina[dia - 1] = temperatura;
        }

        // --- Carga de datos vespertinos ---
        Console.WriteLine("\nIngresa datos Vespertinos");
        for (int x = 0; x < 31; x++)
        {
            Console.Write("Ingrese día (1 a 31): ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Ingrese temperatura registrada: ");
            temperatura = double.Parse(Console.ReadLine());

            muestraVespertina[dia - 1] = temperatura;
        }

        // --- Carga de datos nocturnos ---
        Console.WriteLine("\nIngresa datos Nocturnos");
        for (int x = 0; x < 31; x++)
        {
            Console.Write("Ingrese día (1 a 31): ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Ingrese temperatura registrada: ");
            temperatura = double.Parse(Console.ReadLine());

            muestraNocturna[dia - 1] = temperatura;
        }

        // --- Lectura y cálculo de promedios ---
        double acuMatutina = 0, acuVespertina = 0, acuNocturna = 0;

        for (int x = 0; x < 31; x++)
        {
            acuMatutina += muestraMatutina[x];
            acuVespertina += muestraVespertina[x];
            acuNocturna += muestraNocturna[x];
        }

        Console.WriteLine("Promedio Matutino: " + (acuMatutina / 31));
        Console.WriteLine("Promedio Vespertino: " + (acuVespertina / 31));
        Console.WriteLine("Promedio Nocturno: " + (acuNocturna / 31));

        //// -------/ ////////
        // Ejemplos con bool.

        //! asistencias de alumnos:
        // 16 clases con 100 alumnos.

        // 100 alumnos
        int[] legajos = new int[100];
        bool[] asistencias = new bool[100];

        // --- Carga de legajos ---
        for (int x = 0; x < 100; x++)
        {
            legajos[x] = x + 1; // legajo simple: 1 a 100
        }

        // --- Carga de asistencias ---
        // 16 clases
        for (int clase = 0; clase < 16; clase++)
        {
            Console.WriteLine("\nClase " + (clase + 1));
            for (int alumno = 0; alumno < 100; alumno++)
            {
                Console.Write("Alumno " + legajos[alumno] + " asistió? (1=Sí, 0=No): ");
                int respuesta = int.Parse(Console.ReadLine());
                asistencias[alumno] = (respuesta == 1);

                // Podés procesar directamente aquí:
                if (asistencias[alumno])
                {
                    Console.WriteLine("Alumno " + legajos[alumno] + " presente.");
                }
                else
                {
                    Console.WriteLine("Alumno " + legajos[alumno] + " ausente.");
                }
            }
        }

        // --- Procesamiento final ---
        int totalPresentes = 0;
        for (int alumno = 0; alumno < 100; alumno++)
        {
            if (asistencias[alumno])
            {
                totalPresentes = totalPresentes + 1;
            }
        }

        Console.WriteLine("Total de alumnos presentes en la última clase: " + totalPresentes);

        ////----------- //////
        ///  Cadenas de caracteres.


        char[] letras = new char[5]; // Declaramos un vector de caracteres con 5 posiciones

        // Cargamos caracteres
        letras[0] = 'H';
        letras[1] = 'o';
        letras[2] = 'l';
        letras[3] = 'a';
        letras[4] = '!';

        // Mostramos el vector como caracteres separados
        Console.WriteLine("Vector de letras:");
        for (int x = 0; x < letras.Length; x++)
        {
            Console.WriteLine("Posición " + x + ": " + letras[x]);
        }

        // Podemos unirlos en un string
        string palabra = new string(letras);
        Console.WriteLine("\nLa palabra formada es: " + palabra);
    }
}