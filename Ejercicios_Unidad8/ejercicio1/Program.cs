// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

internal class Program
{
    private static void Main(string[] args)
    {
        //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
        //Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. 
        //Usar la función.

        int pArticulo;
        int cantVendida;
        Console.WriteLine("Ingrese el precio del articulo: ");
        pArticulo = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa la cantidad vendida del articulo: ");
        cantVendida = int.Parse(Console.ReadLine());

        int montoTotal = producto(pArticulo, cantVendida); // se le pasa los valores a la funcion. Nó la tarea!!
        Console.WriteLine("El monto a pagar es : $ " + montoTotal);

    }
    static int producto(int a, int b) //* Decalracion de función
    {
        int vent;
        vent = a * b;
        return vent;
    }

}