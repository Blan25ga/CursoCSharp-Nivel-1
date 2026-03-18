/*1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

La resta si el primero es mayor que el segundo.
La suma si son iguales.
El producto si el primero es menor.
Se deberá emitir un cartel por pantalla con el resultado correspondiente.*/

using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;
        int resta, suma, producto;

        Console.WriteLine("Ingresá el primer numero: ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresá el segundo numero: ");
        b = int.Parse(Console.ReadLine());

        if (a > b){

            resta = a - b;
            Console.WriteLine("El resultado de la resta es: " + resta);
        }     

        else if(a == b){
            
            suma = a + b;
            Console.WriteLine("La suma de los numeros es: " + suma);
        }  
        else {
            producto = a * b; 
            Console.WriteLine("El producto de los numeros es: " + producto);
        }
    }
}