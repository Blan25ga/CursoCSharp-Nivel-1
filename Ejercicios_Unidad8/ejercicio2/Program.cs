// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        //2.Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
        //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

        int contPar = 0;
        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine("Ingresa un numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (par(numero))
            {
                contPar++;
            }
        }
        Console.WriteLine("La cantidad de numeros pares son: " + contPar);
    }
    static bool par(int n1)
    {
        if (n1 % 2 == 0)
        {
            return true;
        }
        else
            return false;
    }
}