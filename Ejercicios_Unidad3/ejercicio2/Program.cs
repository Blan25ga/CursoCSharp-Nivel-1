// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/* 2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero,
“Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.*/



int numero;
Console.WriteLine("Ingresa un numero:");
numero = int.Parse(Console.ReadLine());

    if (numero == 0){
            Console.WriteLine("El numero ingresado es 'Cero'");
    }
    else if (numero < 0){
            Console.WriteLine("El numero ingresado es 'Negativo'");
    }else{
            Console.WriteLine("El numero ingresado 'Es positivo'");
    }