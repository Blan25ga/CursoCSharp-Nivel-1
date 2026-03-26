using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        //*2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. 
        //*   Solo se debe emitir UN valor por pantalla.

        int num, max = 0;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingresa otro numero: ");
            num = int.Parse(Console.ReadLine());

            if (x == 0)
                max = num; //* esto ayuda a que si hay numeros negativos ingresados, la base siempre va a ser cero.

            else
            {
                if (num > max)
                    max = num;

            }


        }
        Console.WriteLine("El mayor de los numr ingresado fue: " + max);

    }
}