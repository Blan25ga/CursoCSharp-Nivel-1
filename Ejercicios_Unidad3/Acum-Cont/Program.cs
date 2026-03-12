/*
ACUMULADORES Y CONTADORES
*/
//Los acumuladores son variables que se utilizan para almacenar la suma de una serie de valores.
//Los contadores son variables que se utilizan para contar el número de veces que se cumple una condición.  

//Ejemplo de acumulador

        int acumulador = 0; //Declaramos el acumulador e inicializamos en 0

        for (int i = 1; i <= 10; i++) //Bucle que se ejecuta 10 veces, desde 1 hasta 10
        {
            acumulador += i; //Sumamos el valor de i al acumulador
        }
        Console.WriteLine("La suma de los números del 1 al 10 es: " + acumulador); //Mostramos el resultado


//Ejemplo de contador

        int contador = 0; //Declaramos el contador e inicializamos en 0

        for (int i = 1; i <= 10; i++) //Bucle que se ejecuta 10 veces, desde 1 hasta 10
        {
            if (i % 2 == 0) //Si el número es par
            {
                contador++; //Incrementamos el contador
            }
        }
        Console.WriteLine("El número de números pares del 1 al 10 es: " + contador); //Mostramos el resultado


//Ejemplo de acumulador y contador juntos
        int sumaPares = 0; //Declaramos el acumulador para la suma de los números pares e inicializamos en 0
        int contadorPares = 0; //Declaramos el contador para los números pares e inicializamos en 0

        for (int i = 1; i <= 10; i++) //Bucle que se ejecuta 10 veces, desde 1 hasta 10
        {
            if (i % 2 == 0) //Si el número es par
            {
                sumaPares += i; //Sumamos el valor de i al acumulador de pares
                contadorPares++; //Incrementamos el contador de pares
            }
        }
        Console.WriteLine("La suma de los números pares del 1 al 10 es: " + sumaPares); //Mostramos la suma de los números pares
        Console.WriteLine("El número de números pares del 1 al 10 es: " + contadorPares); //Mostramos el número de números pares

