// See https://aka.ms/new-console-template for more information

//! Ciclos COMBINADOS // LOTES Y SUBLOTES!
internal class Program
{
    private static void Main(string[] args)
    {
        // CICLOS COMBINADOS:
        //*for con for 
        //*Ejemplo 1:
        //?Ejemplo: cargar edades de 5 equipos y sacar promedio.

        int prom, acu, n;
        for (int x = 0; x < 5; x++)
        {
            acu = 0;
            for (int y = 0; y < 20; y++)
            {
                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
                acu += n;
            }
            prom = acu / 20;
            Console.WriteLine("El promedio de edad es: " + prom);
        }




        //*Ejemplo 2: (equipos mas jugadores)
        int edad;
        int cont;
        double promedio;

        // Bucle para recorrer los 5 equipos
        for (int equipo = 1; equipo <= 5; equipo++)
        {
            Console.WriteLine("Equipo número: " + equipo);
            cont = 0;// reiniciamos acumulador al inicio de cada equipo

            for (int jugador = 1; jugador <= 20; jugador++)// Bucle para recorrer los 20 jugadores
            {
                Console.Write("Edad del jugador " + jugador + ": ");
                edad = int.Parse(Console.ReadLine());

                cont += edad; // acumulamos edades
            }
            // cálculo del promedio
            promedio = cont / 20;
            Console.WriteLine("Promedio de edad del equipo " + equipo + ": " + promedio);
        }


        //*for con while ( El for pide 3 números, y el while asegura que cada uno sea válido.)
        //?Ejemplo: pedir 3 números y validar que cada uno sea positivo.

        for (int i = 1; i <= 3; i++) // ciclo externo
        {
            int n;
            bool valido = false;

            while (!valido) // ciclo interno
            {
                Console.Write("Ingresa un número positivo: ");
                n = int.Parse(Console.ReadLine());

                if (n > 0)
                {
                    Console.WriteLine("Número aceptado: " + n);
                    valido = true; // rompe el while
                }
                else
                {
                    Console.WriteLine("Error, debe ser positivo.");
                }
            }
        }

        //* While con for ( El while controla los lotes, el for recorre los elementos dentro de cada lote.)
        //?Ejemplo: procesar lotes de datos, cada lote con 3 elementos.

        int lote = 1;

        while (lote <= 2) // ciclo externo: cantidad de lotes
        {
            Console.WriteLine("Lote " + lote);

            for (int i = 1; i <= 3; i++) // ciclo interno: elementos del lote
            {
                Console.Write("Ingresa número del lote " + lote + ": ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Número ingresado: " + n);
            }

            lote++;
        }

        //*While con While ( El while externo controla la salida con 0, el interno valida que no se ingresen negativos.)
        //?Ejemplo: pedir números hasta que el usuario ingrese 0, y dentro validar que sean positivos.

        int n = -1;

        while (n != 0) // ciclo externo: se repite hasta que se ingrese 0
        {
            Console.Write("Ingresa un número (0 para salir): ");
            n = int.Parse(Console.ReadLine());

            int temp = n;
            while (temp < 0 && temp != 0) // ciclo interno: valida que no sea negativo
            {
                Console.Write("Número inválido, ingresa positivo o 0: ");
                temp = int.Parse(Console.ReadLine());
                n = temp;
            }

            if (n != 0)
                Console.WriteLine("Número aceptado: " + n);
        }

        // CORTE DE CONTROL //

        int edad;

        while (true) // while externo: recorre equipos hasta que se ingrese -1 (fin total)
        {
            Console.WriteLine("Nuevo equipo (ingrese -1 para terminar): ");
            edad = int.Parse(Console.ReadLine());

            if (edad == -1) break; // corte total

            int suma = 0, contador = 0;

            // while interno: recorre jugadores hasta que se ingrese 0 (corte de equipo)
            while (edad != 0)
            {
                suma += edad;
                contador++;

                Console.Write("Ingrese edad (0 para terminar equipo, -1 para terminar todo): ");
                edad = int.Parse(Console.ReadLine());

                if (edad == -1) break; // corte total dentro del sublote
            }

            if (contador > 0)
            {
                double promedio = (double)suma / contador;
                Console.WriteLine("Promedio de edad del equipo: " + promedio);
            }

            if (edad == -1) break; // salir del bucle externo también
        }

    }
}


