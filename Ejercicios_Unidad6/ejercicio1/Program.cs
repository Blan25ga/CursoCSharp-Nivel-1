// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        // Hacer un programa para ingresar 10 números. 
        // El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

        int n, cont, contPrimos = 0;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingresa un numero: ");
            n = int.Parse(Console.ReadLine());
            cont = 0; //Se reinicia el contador de divisores para este número ingresado

            for (int y = 1; y <= n; y++)// Bucle interno: recorre todos los posibles divisores de n
            {
                if (n % y == 0)// Si el resto es 0, significa que "y" es divisor de "n"
                {
                    cont++; // se agrega el contados de divisores
                }
            }
            if (cont == 2)// Si el número tiene exactamente 2 divisores(1 y él mismo)
            {
                contPrimos++; // Se incrementa a primos
            }
        }
        Console.WriteLine("La cantidad de numeros primos ingresados fue : " + contPrimos);
    }
}

