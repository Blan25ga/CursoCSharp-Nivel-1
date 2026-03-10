/*4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. 
Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.*/

int sueldoFijo = 15000;
float totalFacturado;
float sueldoTotal;


Console.WriteLine("Ingrese el total facturado por el empleado:");
totalFacturado = float.Parse(Console.ReadLine());


sueldoTotal = sueldoFijo + (totalFacturado * 0.05f); // Al 0.05f se le agrega la "f" para indicar que es un número de tipo float, lo cual es necesario para evitar errores de tipo al realizar la multiplicación con un número decimal.


Console.WriteLine($"El sueldo total a cobrar es: $" + sueldoTotal + "ARS");

