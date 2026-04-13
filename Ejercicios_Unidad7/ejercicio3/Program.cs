// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
internal class Program
{
    private static void Main(string[] args)
    {
        //3. Hacer un programa que solicite una cadena de frase y dos frase sueltos (tres ingresos). 
        //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
        /*Mostrar el resultado en pantalla. 
        Ejemplo:
        CADENA FUENTE: “La mar estaba serena"
        CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
        CADENA RESULTADO: “Li mir estibi sereni"*/

        char[] frase = new char[50];
        char letra1;
        char letra2;

        char letra;
        int i = 0;

        Console.WriteLine("Escribe una letra: ");// pido letra antes de entrar al while
        letra = char.Parse(Console.ReadLine());
        while (letra != '.' && i < 50) // mientas no sea un punto y menos a 50 caracteres
        {
            frase[i] = letra; // cada letra ingresada se guarda en un indice
            Console.WriteLine("Escribe otra letra para completar frase: "); // se pide otra letra, mientras siga las condiciones.... pide.
            letra = char.Parse(Console.ReadLine());
            i++; // acumula letras
        }
        frase[i] = '\0';// finliza el ingreso despues del punto con un barracero. (si no se completan los espacios del vector)
        Console.WriteLine("La frase completa es: ");

        i = 0;// reinicio indice
        while (frase[i] != '\0')
        {
            Console.Write(frase[i]);
            i++;
        }
        Console.WriteLine();// ---- Salto de linea
        Console.WriteLine("Escribe letra a reemplazar: ");
        letra1 = char.Parse(Console.ReadLine());
        Console.WriteLine("Escribe letra deseada: ");
        letra2 = char.Parse(Console.ReadLine());

        i = 0; // reinicio el índice para recorrer desde el principio
        while (frase[i] != '\0') // mientras no llegue al final de la frase (marcado con '\0')
        {
            if (frase[i] == letra1) // si el carácter actual coincide con el que quiero reemplazar
            {
                frase[i] = letra2; // lo reemplazo por el nuevo carácter
            }
            i++; // avanzo al siguiente índice
        }

        // Muestra resultado
        Console.WriteLine("La frase resultante es: ");
        i = 0; // reinicio el índice para recorrer desde el principio
        while (frase[i] != '\0') // mientras no llegue al final de la frase
        {
            Console.Write(frase[i]); // muestro cada carácter de la frase en forma de --- (string)
            i++; // avanzo al siguiente índice
        }


    }
}