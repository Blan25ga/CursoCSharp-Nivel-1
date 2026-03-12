/*
5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.*/

int a, b, c, d;

Console.WriteLine("Ingrese el primer número: ");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número: ");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer número: ");
c = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el cuarto número: ");
d = int.Parse(Console.ReadLine());


int contador = 0; // Inicializamos el contador en cero.

        // Verificamos cada número
        if (a > 100)
            contador++; //Cda vez que un numero sea mayor a 100, se agrega al contador.

        if (b > 100)
            contador++;

        if (c > 100)
            contador++;

        if (d > 100)
            contador++;

        Console.WriteLine("La cantidad de números mayores a 100 es: " + contador);
