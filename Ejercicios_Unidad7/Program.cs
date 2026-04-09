// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

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
            v[x] = int.Parse(Console.ReadLine()); // guardamos el número en la posición x
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




    }
}