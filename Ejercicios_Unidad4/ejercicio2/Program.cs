
internal class Program
{
    private static void Main(string[] args)
    {
    /*Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

        Si vende menos de 100 litros, no hay descuento.
        Si vende entre 101 y 300 litros, el descuento es del 10%.
        Si vende entre 301 y 500 litros, el descuento es del 15%.
        Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
        Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita
        el importe con el descuento  aplicado..*/

    float impTotal, litros, importe;
    int rango;

        Console.WriteLine("Ingrese IMPORTE DE VENTA: ");
        importe = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese LITROS VENDIDOS: ");
        litros = float.Parse(Console.ReadLine());

        // Clasificamos los litros en un rango
        if (litros < 100) rango = 0;
        else if (litros <= 300) rango = 3;
        else if (litros <= 500) rango = 2;
        else rango = 1;

        switch (rango)
        {
            case 1: // más de 500 litros
                if (litros > 500)
                {
                    impTotal = importe * 0.75f;
                    Console.WriteLine("Se aplicó un 25% de descuento.");
                    Console.WriteLine("El Importe Final es: " + impTotal);
                }
                break;

            case 2: // entre 301 y 500 litros
                if (litros > 300 && litros <= 500)
                {
                    impTotal = importe * 0.85f;
                    Console.WriteLine("Se aplicó un 15% de descuento.");
                    Console.WriteLine("El Importe Final es: " + impTotal);
                }
                break;

            case 3: // entre 101 y 300 litros, o menos de 100
                if (litros >= 101 && litros <= 300)
                {
                    impTotal = importe * 0.90f;
                    Console.WriteLine("Se aplicó un 10% de descuento.");
                    Console.WriteLine("El Importe Final es: " + impTotal);
                }
                else
                {
                    impTotal = importe;
                    Console.WriteLine("No se aplica descuento.");
                    Console.WriteLine("El importe es: " + impTotal);
                }
                break;

            default:
                Console.WriteLine("No se reconoció el rango de litros.");
                break;
        }
    }
}