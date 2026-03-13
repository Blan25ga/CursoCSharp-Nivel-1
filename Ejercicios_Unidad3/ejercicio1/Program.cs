/*
1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.*/

int numero;
Console.Write("Ingrese un número: "); // Se solicita al usuario que ingrese un número.
numero = int.Parse(Console.ReadLine()); // La variable numero se asigna con el valor ingresado por el usuario.

        if (numero > 10)  
        {
            Console.WriteLine("Es mayor a 10");
        }
        else
        {
            Console.WriteLine("No es mayor a 10");
        }
