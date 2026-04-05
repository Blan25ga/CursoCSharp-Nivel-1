// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

internal class Program
{
    private static void Main(string[] args)
    {
        //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
        // El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

        int n;
        int cont;
        int numLista = 1; // identificación para las listas

        Console.WriteLine("Ingresa un número (negativo para terminar): ");
        n = int.Parse(Console.ReadLine()); // primera lectura

        while (n >= 0) // corte general: mientras el número sea mayor o igual a cero
        {
            cont = 0; // reinicio de cont para cada lista

            while (n > 0) // mientras el número sea positivo, seguimos dentro de la lista
            {
                cont++;
                Console.WriteLine("Ingresa números enteros o 'cero' para cambiar de lista: ");
                n = int.Parse(Console.ReadLine()); // pide otro número hasta ingresar un cero o negativo
            }

            if (cont > 0) // si la lista tuvo números (evitamos mostrar listas vacías)
            {
                Console.WriteLine("La lista " + numLista + " tiene: " + cont + " números");
                numLista++; // pasamos a la siguiente lista
            }

            // Si el número es cero, pedimos el siguiente para ver si hay otra lista
            if (n == 0)
            {
                Console.WriteLine("Ingresa un número (negativo para terminar): ");
                n = int.Parse(Console.ReadLine());
            }
        }
    }

}