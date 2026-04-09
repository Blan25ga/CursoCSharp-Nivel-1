internal class Program
{
    private static void Main(string[] args)
    {
        //* 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

        int edad, acu = 0, cont = 0, promedio;

        for (int x = 0; x < 20; x++)// bucle que se repite 20 veces para pedir 20 edades
        {
            Console.WriteLine("Ingresa edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad > 18)
            // condición: solo se consideran las edades mayores a 18
            {
                acu += edad;   // suma la edad al acumulador
                cont++;        // incrementa el contador de mayores de 18
            }
        }
        promedio = acu / cont;
        Console.WriteLine("El promedio de mayores a 18 es: " + promedio);

    }
}