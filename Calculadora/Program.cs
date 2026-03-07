// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Calculadora");

// --Paso 0, Declarar Variables.
// tipo de variables: int (enteros), float (decimales), char (caracteres), bool (booleanos, true/false - 1/0).

int n1, n2, resultado; // se declaran 2 variables para los números y una variable para el resultado. 
// Se pueden declarar varias variables del mismo tipo en una sola línea, separándolas por comas.


// --Paso 1: Pedir valores al usuario.
Console.WriteLine("Ingrese un número: "); // mostrar mensaje al usuario.

//Console.ReadLine(); // lee lo que el usuario ingresa por teclado.
//Console.WriteLine("N1 tiene cargado: " + n1); // para mostrar, concatenamos el mensaje con el valor de n1 usando el operador +.
n1 = int.Parse(Console.ReadLine()); // para convertir el valor ingresado por el usuario a un número entero, usamos int.Parse().
Console.WriteLine("Ingrese otro número: ");
n2 = int.Parse(Console.ReadLine());



// --Paso 2: pedir la operación a realizar.
resultado = n1 + n2; // para sumar, usamos el operador +.


// --Paso 3: mostrar resultado.
Console.WriteLine("El resultado de la suma es: " + resultado); // concatenamos el mensaje con el valor de resultado.
