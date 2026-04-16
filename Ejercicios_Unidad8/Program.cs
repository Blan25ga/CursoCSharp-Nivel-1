// See https://aka.ms/new-console-template for more information
using System.Data;

//Console.WriteLine("Hello, World!");

internal class Program
{
    private static void Main(string[] args) //programa principal
    { //*primer cuerpo

        //! Programa principal donde se ejecuta paso a paso el programa.
        //! Hasta encontrar una INVOCACION DE FUNCION.
        //! Para luego seguir con el recorrido de codigo.
        int n1 = 0, n2 = 0, resultado; // declaro variables

        pedirDatos(ref n1, ref n2); //* invocacion de funcion por referencia.

        resultado = sumar(n1, n2);//* ---- invocación de función por parametro.
        //fin de logica

        Console.WriteLine("El resultado es: " + resultado);
        //otro metodo, en donde tambien devuelve el valor concatenando directamente la funcion.

    }

    //  ---- Funciones : siempre se declaran fuera del "Programa Principal", fuera del primer cuerpo.------
    //* Declaracion de funcion "sumar".
    static int sumar(int a, int b)// solicita 2 parametros enteros!
    {
        int r;
        r = a + b;//este toma los parametros ingresados por el usuario (n1 y n2)
        return r;
        //return: se retorna el resultado de la funcion "sumar", el cual se asignara a/en "resultado" (del main)
    }

    static void pedirDatos(ref int j, ref int h) //* declaracion de funcion para pedir datos al usuario!!
    {
        Console.WriteLine("Ingresa un numero"); // carga mas guardado de datos
        j = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa otro numero..");
        h = int.Parse(Console.ReadLine());
    }

}