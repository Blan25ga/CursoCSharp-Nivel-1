// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        /*4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro 
        con los siguientes datos:
        -Número de Artículo(1 a 15)
        -Cantidad Vendida
        */

        //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
        /*
        Se pide determinar e informar:
        a) El número de artículo que más se vendió en total.
        b) Los números de artículos que no registraron ventas. //*ok
        c) Cuantas unidades se vendieron del número de artículo 10. //*OK
        */

        int nArt;
        int cVentas;

        int[] articulos = new int[15];// vector acumulador de articulos
        for (int x = 0; x < 15; x++)
        {
            articulos[x] = 0; //Iniciacion en cero.
        }
        //*Peticion de datos y guardado de articulos y ventas de cada uno.
        Console.WriteLine("Ingrese numero de articulo vendido: ");
        nArt = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese cantidades vendidas: ");
        cVentas = int.Parse(Console.ReadLine());

        while (nArt != 0)
        { //*Mientas el articulo no sea cero, este se guarda, restando una posicion, ya que va de 1 a 15.
            articulos[nArt - 1] += cVentas;
            Console.WriteLine("Ingrese numero de articulo vendido: ");
            nArt = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidades vendidas: ");
            cVentas = int.Parse(Console.ReadLine());
        }
        Console.Write("El aritculo numero 10 vendió: " + articulos[9] + " unidades"); //Muestra de cantidades de ventas que tubo el articulo 10
        Console.WriteLine(); // salto de linea para consola.

        for (int x = 0; x < 15; x++)
        {
            if (articulos[x] == 0)
            {
                Console.WriteLine("El artuculo numero" + (x + 1) + " no tiene ventas");// Se imprimen los numeros de articulos no vendidos.
            }
        }

        //Artículo más vendido
        int maxVendido = articulos[0];   // inicializo con la cantidad vendida del primer artículo
        int indiceMax = 0;               // guardo el índice del artículo más vendido (empieza en 0)

        for (int x = 1; x < 15; x++)     // recorro desde el segundo artículo (índice 1) hasta el último (índice 14)
        {
            if (articulos[x] > maxVendido)   // si la cantidad vendida del artículo actual es mayor que la máxima registrada
            {
                maxVendido = articulos[x];   // actualizo la nueva cantidad máxima
                indiceMax = x;               // guardo el índice del artículo que tiene esa nueva cantidad máxima
            }
        }

        Console.WriteLine("El número de artículo más vendido fue el: " + (indiceMax + 1));
        Console.WriteLine("Con un total de " + maxVendido + " unidades vendidas");
    }
}