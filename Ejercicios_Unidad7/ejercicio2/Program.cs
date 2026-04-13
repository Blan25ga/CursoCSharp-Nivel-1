// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
internal class Program
{
    private static void Main(string[] args)
    {
        //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
        //Luego recorrer ese vector para calcular el promedio. 
        //Mostrar por pantalla los valores que son mayores al promedio.

        int n;

        int[] numeros = new int[10]; // declaracion de vector de 10 numeros

        Console.WriteLine("Ingresa 10 numeros: ");//*Se coloca primero para que no se repita con cada ingreso de numero.
        for (int x = 0; x < 10; x++)// solicitud y carga de los 10 numeros.
        {
            n = int.Parse(Console.ReadLine());
            numeros[x] = n;
        }
        // calculo de promedio.
        int cont = 0;
        for (int x = 0; x < 10; x++)
        {
            cont += numeros[x];
        }
        int promedio = cont / 10;
        Console.WriteLine("El promedio de los numeros es: " + promedio);


        // recorrer el vector y mostrar los mayores al promedio
        Console.WriteLine("Los números mayores al promedio son:");
        //*Se coloca primero para que no se repita dentro del for y quede como anunciante de los resultados.
        for (int x = 0; x < 10; x++)
        {
            if (numeros[x] > promedio)
            {
                Console.WriteLine(numeros[x]);
            }
        }

    }
}