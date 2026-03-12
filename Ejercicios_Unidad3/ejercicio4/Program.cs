/*
4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.*/

int a, b, c, d;
Console.WriteLine("Ingrese el primer número: ");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número: ");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer número: ");
c = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el cuarto número: ");
d = int.Parse(Console.ReadLine());

// Suponemos que el menor es el primero
int menor = a;

        // Comparamos con el segundo
        if (b < menor)
        {
            menor = b;
        }

        // Comparamos con el tercero
        if (c < menor)
        {
            menor = c;
        }

        // Comparamos con el cuarto
        if (d < menor)
        {
            menor = d;
        }

        Console.WriteLine("El menor de los cuatro números es: " + menor);
