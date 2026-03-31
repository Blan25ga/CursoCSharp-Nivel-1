using System.Buffers.Binary;

internal class Program
{
    private static void Main(string[] args)
    {
        //*5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y 
        //*  el mínimo de los números impares.

        int n;
        int maxPar = 0;
        int minImp = 0;
        bool bpar = false;
        bool bimp = false;

        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("Ingresa un numero:");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) // bloque de pares
            {
                if (!bpar)
                {
                    maxPar = n;
                    bpar = true;
                }
                else if (n > maxPar)
                {
                    maxPar = n;
                }
            }
            else // bloque de impares
            {
                if (!bimp)
                {
                    minImp = n;
                    bimp = true;
                }
                else if (n < minImp)
                {
                    minImp = n;
                }
            }
        }

        if (bpar)
            Console.WriteLine("El máximo PAR es: " + maxPar);
        else
            Console.WriteLine("No se ingresaron números pares.");

        if (bimp)
            Console.WriteLine("El mínimo IMPAR es: " + minImp);
        else
            Console.WriteLine("No se ingresaron números impares.");
    }
}