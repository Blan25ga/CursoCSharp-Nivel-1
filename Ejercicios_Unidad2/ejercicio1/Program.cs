//! Leer atentamente y resolver!

//!Para cada ejercicio deberás escribir el código correspondiente y probar su funcionamiento.

//1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.

int n1;
int n2;
int suma;
Console.WriteLine("Ingrese el primer número:");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número:");
n2 = int.Parse(Console.ReadLine());

suma = n1 + n2;
Console.WriteLine("La suma es: " + suma);