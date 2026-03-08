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

//2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

int num1;
int multiplicación;
Console.WriteLine("Ingresa un numero:");

num1 = int.Parse(Console.ReadLine());
multiplicación = num1 * num1 * num1;
Console.WriteLine("El resultado de la multiplicación es:" + multiplicación);


/*3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. 
Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.*/

int kms;
int vp;
int tiempo;

Console.WriteLine("ingrese kms entre ciudades:");
kms = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese velocidad promedio:");
vp = int.Parse(Console.ReadLine());

tiempo = kms / vp;
Console.WriteLine("Tiempo aproximado de llegada:" + tiempo + "hs");



/*4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. 
Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.*/

int sueldoFijo = 15000;
float totalFacturado;
float sueldoTotal;


Console.WriteLine("Ingrese el total facturado por el empleado:");
totalFacturado = float.Parse(Console.ReadLine());


sueldoTotal = sueldoFijo + (totalFacturado * 0.05f); // Al 0.05f se le agrega la "f" para indicar que es un número de tipo float, lo cual es necesario para evitar errores de tipo al realizar la multiplicación con un número decimal.


Console.WriteLine($"El sueldo total a cobrar es: $" + sueldoTotal + "ARS");


//5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.

int nt1, nt2, nt3;
int promedioFinal;

Console.WriteLine("Ingrese la primera nota:");
nt1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la segunda nota:");
nt2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la tercera nota:");
nt3 = int.Parse(Console.ReadLine());

// Cálculo del promedio
promedioFinal = (nt1 + nt2 + nt3) / 3;

Console.WriteLine("El Promedio Final es:" + promedioFinal);

