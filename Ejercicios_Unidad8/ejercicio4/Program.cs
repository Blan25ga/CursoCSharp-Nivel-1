// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

internal class Program
{
    private static void Main(string[] args)
    {
        //4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
        //Que analice el número y escriba variable recibida por referencia con:

        /*a. 1 si el número es positivo.
        b. -1 si el número es negativo.
        c. 0 si el número es cero.*/

        int numero, equipo = 5; // 'Numero' guardará el valor ingresado, 'equipo' será modificado por referencia

        Console.WriteLine("Ingresa un numero: ");
        numero = int.Parse(Console.ReadLine());

        // Llamo a la función 'positivoNegativocero' pasando 'numero' por valor y 'equipo' por referencia
        positivoNegativocero(numero, ref equipo);

        // Muestro el resultado: el valor original ingresado y la clasificación asignada en 'equipo'
        Console.WriteLine("El valor " + numero + " corresponde a la selección: " + equipo);

    }

    static void positivoNegativocero(int n, ref int selección)
    { // Función de tipo void (no devuelve nada)
      // Recibe 'n' por valor (una copia del número ingresado)
      // Recibe 'selección' por referencia (modifica directamente la variable original)

        if (n > 0)
            selección = 1;
        else if (n == 0)
            selección = 0;
        else
            selección = -1;
    }
}
