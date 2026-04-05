// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

internal class Program
{
    private static void Main(string[] args)
    {
        //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
        //*Se pide determinar e informar:
        //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

        int n, contNum, contImpares, grupImpMax, min, contOrdenados = 0;
        double porcentajeImp, porcentajeMaximo = -1;
        bool banderaOrdenados;

        for (int x = 0; x < 5; x++)// for para recorrer las 5 listas
        {
            contNum = 0;
            contImpares = 0; //reinicia el contador de impares por grupo
            banderaOrdenados = true; // se ASUME que estan ordenados desde el inicio.
            n = int.Parse(Console.ReadLine());
            min = n;// Se guarda como referencia inicial para verificar orden descendente

            while (n != 0) // Se guarda como referencia inicial para verificar orden descendente
            {
                contNum++;
                if (n % 2 != 0) //sie el numero es impar
                    contImpares++; // se suma al contador

                //*Verificación de orden descendente
                //punto B
                if (n <= min)
                {
                    min = n;
                }
                else
                {
                    banderaOrdenados = false;// si ingresa un numero mayor, se da por echo que el grupo no esta ordenado.
                }

                n = int.Parse(Console.ReadLine());//Carga de numeros.
            }
            porcentajeImp = contImpares * 100 / contNum;

            if (porcentajeImp > porcentajeMaximo)// Si el porcentaje actual es mayor al máximo registrado
            {
                porcentajeMaximo = porcentajeImp;// se actualiza el maximo porcentaje.
                grupImpMax = x + 1;// numero de grupo
            }

            if (banderaOrdenados == true)// si el grupo se mantiene ordenado
            {
                contOrdenados++; // se suma al contador de ordenados


            }

        }//fin del for
        Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupImpMax);
        Console.WriteLine("La cantidad de grupos ordenados es: " + contOrdenados);

    }

}