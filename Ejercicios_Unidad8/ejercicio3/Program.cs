// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        //3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
        //Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. 
        //Informar el promedio teniendo en cuenta sólo los números primos.

        int num = 1;
        int cont = 0;
        int acuPrimos = 0;

        Console.WriteLine("Ingresa un número, inregresa 'cero(0)' para cortar: ");

        while (num != 0)
        {
            num = int.Parse(Console.ReadLine());
            if (primo(num))
            {
                cont++;
                acuPrimos += num;
            }
            Console.WriteLine("Ingresa otro numero,'cero(0)' para cortar: ");
        }

        if (cont > 0)
        {
            double promedio = (double)acuPrimos / cont;
            Console.WriteLine("El promedio de los números primos es: " + promedio);
        }
        else
        {
            Console.WriteLine("No se ingresaron números primos.");
        }

    }

    static bool primo(int n)
    {
        int cont = 0;


        for (int x = 1; x <= n; x++)
        {
            if (n % x == 0)
            {
                cont++;
            }
        }
        if (cont == 2)
            return true;
        else
            return false;
    }
}