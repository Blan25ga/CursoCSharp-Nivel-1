internal partial class Program
{
    private static void Main(string[] args)
    {
    /*Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor
        al producto del segundo con el tercero.*/

        int a, b, c;
        int suma;
        int mayor;

        Console.WriteLine("Ingrese un numero:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un segundo numero:");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un tercer numero:");
        c = int.Parse(Console.ReadLine());
        
        suma = a + b;
        mayor = b * c;
        if (suma > mayor)
        {
            Console.WriteLine("La suma de los 2 primeros es mayo al pruducto del segundo con el tercero");
        }
        else
        {
            Console.WriteLine("El Producto es mayor a la suma de los 2 primeros");
        }
    }
}