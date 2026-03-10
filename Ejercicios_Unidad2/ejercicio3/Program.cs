
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
