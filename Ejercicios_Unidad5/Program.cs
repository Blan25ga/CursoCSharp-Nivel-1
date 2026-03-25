internal class Program
{
    private static void Main(string[] args)
    {
        //!     UNIDAD 5, CICLO FOR AND WHILE

        /*for (int x = 0; x < 5; x++){ // inicializacion de ciclo for.
            Console.WriteLine("Hello World!");

        }*/

        //*Ejemplo 2:
        /*int n, promedio, suma = 0;

        for (int x = 0; x < 5; x++){
            Console.WriteLine("Ingrese la nota: ");
            n = int.Parse(Console.ReadLine());
            suma += n;// se le asigna la nota y se le suma a "suma" la nueva nota ingresada.
        }
            promedio = suma / 5; //!se declara "AFUERA DEL FOR" el promedio que queremos saber de los 10 alumnos.
            Console.WriteLine("El promedio de las notas es : " + promedio);
        */

        // WHILE 
        // (MIENTRAAAAS ... SE DE ALGO... EJECUTA)
        /*    
        int a, cont =0;
        Console.WriteLine("ingresa un numero: ");//* Se pide el primer numero afuera, si cumple la condicion del while, entra a hacer el recorrido.
        a = int.Parse(Console.ReadLine());

        while (a != 0){ //! Condicion del While. Este va apedir numero mientras sean diferente a cero, al ingresar un cero, corta la itereción.
            cont++;     //* en el contador, se increminta cada numero ingresado. y muestra la cantidad de numeros ingresados.( sean 1 o 20 ej)
            Console.WriteLine("ingresa un numero: ");
            a = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Ingresaste una cantidad de : " + cont + " Numeros");
        //La cosnola lanza el mensaje con el total de numeros guardados en la varaible "cont".
*/

        // Ciclo DO

        int a, cont = 0;

        do
        { //! en el DO, directamente, pide, da la primer vuelta, y despues pregunta al WHILE, si sigue iterendo.
            Console.WriteLine("ingresa un numero: ");
            a = int.Parse(Console.ReadLine());
            cont++;
        } while (a != 0);
        Console.WriteLine("Ingresaste una cantidad de : " + cont + " Numeros");
    }
}