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