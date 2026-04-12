// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
internal class Program
{
    private static void Main(string[] args)
    {
        //1.Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
        //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

        int n;
        int[] numeros = new int[10];
        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingresa 10 numeros enteros: ");
            n = int.Parse(Console.ReadLine());
            numeros[x] = n;
        }

        int maximo = numeros[0]; // suponiendo que el primero es el mayor
        int posicion = 0;// posición inicial

        for (int x = 1; x < 10; x++)// se recorre desde la segunda posicion
        {
            if (numeros[x] > maximo)
            {
                maximo = numeros[x]; //se actualiza el valor del maximo
                posicion = x;        // se guarda la posicion.
            }
        }
        Console.WriteLine("El valor máximo es: " + maximo);
        Console.WriteLine("Se encuentra en la posición: " + posicion);
    }
}