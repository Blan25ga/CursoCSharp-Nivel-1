internal class Program
{
    private static void Main(string[] args)
    {
    /*Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos
        se encuentran ordenados de forma decreciente .*/
    
    int a, b, c, d;

    Console.WriteLine("Ingrese el primer número:");
    a = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo número:");
    b = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el tercer número:");
    c = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el cuarto número:");
    d = int.Parse(Console.ReadLine());

        
        if (a > b && b > c && c > d)
        {
            Console.WriteLine("Los números están ordenados de forma decreciente.");
        }
        else
        {
            Console.WriteLine("Los números NO están ordenados de forma decreciente.");
        }
    }
}