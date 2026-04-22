

//! ---COMANDOS DE git ---


//* 📌 Lista paso a paso de comandos Git más usados

/*🔹 Inicialización y configuración

1. **`git init`**  
- Crea un nuevo repositorio Git en la carpeta actual.  
- Ejemplo: `git init`  

2. **`git config --global user.name "Tu Nombre"`**  
- Configura tu nombre de usuario para los commits.  

3. **`git config --global user.email "tuemail@example.com"`**  
- Configura tu correo electrónico asociado a los commits.  
*/


/* 🔹 Trabajo con repositorios remotos

4. **`git clone <url>`**  
- Descarga un repositorio remoto a tu máquina.  
- Ejemplo: `git clone https://github.com/user/proyecto.git`  

5. **`git remote add origin <url>`**  
- Vincula tu repositorio local con uno remoto.  
*/


/*🔹 Estado y preparación de cambios

6. **`git status`**  
- Muestra el estado actual: archivos modificados, pendientes de commit, etc.  

7. **`git add <archivo>`**  
- Añade un archivo al área de *staging* (preparación para commit).  
- Ejemplo: `git add index.html`  

8. **`git add .`**  
- Añade todos los archivos modificados al área de staging.  

*/

/*🔹 Guardar cambios
9. **`git commit -m "mensaje"`**  
- Registra los cambios en el historial con un mensaje descriptivo.  

10. **`git log`**  
- Muestra el historial de commits.  
- Variación: `git log --oneline` para ver un resumen compacto.  

*/

/* 🔹 Sincronización con remoto
11. **`git push origin main`**  
    - Envía tus commits al repositorio remoto en la rama `main`.  

12. **`git pull origin main`**  
    - Descarga y fusiona los cambios del remoto a tu rama local.  



/*🔹 Trabajo con ramas

13. **`git branch`**  
    - Lista las ramas disponibles.  

14. **`git branch <nombre>`**  
    - Crea una nueva rama.  

15. **`git checkout <nombre>`**  
    - Cambia a otra rama.  

16. **`git merge <rama>`**  
    - Fusiona la rama indicada en la rama actual.  



/*🔹 Inspección y comparación

17. **`git diff`**  
- Muestra las diferencias entre archivos modificados y el último commit.  

18. **`git reflog`**  
- Muestra el historial de acciones realizadas (útil para recuperar commits perdidos).  
*/


//! ⚠️ Consejos prácticos
/*
- **Siempre usar mensajes claros en los commits**: ayudan a entender el historial.  
- **Trabajar con ramas**: evita romper la rama principal (`main` o `master`).  
- **Sincronizar seguido (`git pull`)**: reduce conflictos al trabajar en equipo.  

*/



//! --- Comandos con cd ---


// cd: para cambiar de directorio, es decir, para moverse entre las carpetas del sistema de archivos. 
// EJEMPLO: cd Calculadora: para entrar a la carpeta Calculadora, cd .. para subir un nivel en la jerarquía de carpetas, etc.

// cd ..: para subir un nivel en la jerarquía de carpetas, es decir, para ir a la carpeta padre de la carpeta actual. 
// EJEMPLO: si estamos en la carpeta C:\Users\Gabriel Blanco\Desktop\Curso C# Nivel 1\Calculadora, cd .. nos llevará a la carpeta C:\Users\Gabriel Blanco\Desktop\Curso C# Nivel 1, que es la carpeta padre de Calculadora.

// cd nombre_carpeta: para entrar a una carpeta específica, es decir, para ir a la carpeta con el nombre indicado que se encuentra dentro de la carpeta actual.
// EJEMPLO: si estamos en la carpeta C:\Users\Gabriel Blanco\Desktop\Curso C# Nivel 1, cd Calculadora nos llevará a la carpeta C:\Users\Gabriel Blanco\Desktop\Curso C# Nivel 1\Calculadora, que es una carpeta que se encuentra dentro de la carpeta actual.

// cd \: para ir a la raíz del sistema de archivos, es decir, para ir a la carpeta principal que contiene todas las demás carpetas y archivos del sistema de archivos.
// EJEMPLO: si estamos en cualquier carpeta del sistema de archivos, cd \ nos llevará a la raíz del sistema de archivos, que es la carpeta C:\ en Windows o / en Linux y macOS.

// cd ~: para ir al directorio de inicio del usuario, es decir, para ir a la carpeta que contiene los archivos personales del usuario, como documentos, imágenes, música, etc. 
// Este comando es útil para acceder rápidamente a los archivos personales del usuario sin tener que navegar por la jerarquía de carpetas del sistema de archivos.  
// EJEMPLO: si estamos en cualquier carpeta del sistema de archivos, cd ~ nos llevará al directorio de inicio del usuario, que es la carpeta C:\Users\Gabriel Blanco en Windows o /home/gabriel en Linux y macOS.


//! --- Comandos de consola: ---

// dotnet run: para ejecutar el programa.

// dotnet build: para compilar el programa, es decir, convertir el código fuente en un archivo ejecutable.

// dotnet clean: para limpiar los archivos generados por la compilación, es decir, eliminar los archivos ejecutables y otros archivos temporales generados por el proceso de compilación.
// Esto es útil para asegurarse de que la próxima compilación se realice desde cero, sin utilizar archivos antiguos que puedan causar problemas.

// dotnet new console: para crear un nuevo proyecto de consola, es decir, un proyecto que se ejecuta en la línea de comandos y no tiene una interfaz gráfica de usuario. 
// Este comando crea una estructura básica de archivos y carpetas para un proyecto de consola, incluyendo un archivo Program.cs con un código de ejemplo que imprime "Hello, World!" en la consola.



//! --- Comandos de nombre Console: ---

// Console.WriteLine(): para mostrar un mensaje en la consola.

// Console.ReadLine(): para leer lo que el usuario ingresa por teclado. Este comando devuelve una cadena de texto (string) con el valor ingresado por el usuario.

// Console.Write(): para mostrar un mensaje en la consola sin saltar a la siguiente línea. 
//Es decir, el cursor se queda en la misma línea después de mostrar el mensaje, lo que permite que el usuario ingrese su respuesta en la misma línea.



//! --- Tipos de variables: ---

// int: para almacenar números enteros, es decir, sin decimales. Ejemplo: 1, 2, -3, 0.

// float: para almacenar números decimales, es decir, con parte fraccionaria. Ejemplo: 3.14, -0.5, 0.0.

// char: para almacenar un solo carácter, es decir, una letra, un número o un símbolo. Ejemplo: 'a', '1', '$'.

// bool: para almacenar valores booleanos, es decir, true (verdadero) o false (falso).
// Estos valores se pueden representar también como 1 (true) y 0 (false).

// string: para almacenar cadenas de texto, es decir, una secuencia de caracteres. Ejemplo: "Hola", "123", "true".


//! --- Covertidores de valores---

// int.Parse(): para convertir una cadena de texto a un número entero. Ejemplo: int.Parse("123") devuelve el número entero 123.
// Ejemplo: n1 = int.Parse(Console.ReadLine()); para convertir el valor ingresado por el usuario a un número entero y almacenarlo en la variable n1.

// float.Parse(): para convertir una cadena de texto a un número decimal. Ejemplo: float.Parse("3.14") devuelve el número decimal 3.14.
// Ejemplo: n2 = float.Parse(Console.ReadLine()); para convertir el valor ingresado por el usuario a un número decimal y almacenarlo en la variable n2.

// bool.Parse(): para convertir una cadena de texto a un valor booleano. Ejemplo: bool.Parse("true") devuelve el valor booleano true, y bool.Parse("false") devuelve el valor booleano false.
// Ejemplo: bool respuesta = bool.Parse(Console.ReadLine()); para convertir el valor ingresado por el usuario a un valor booleano y almacenarlo en la variable respuesta.


//! Ejemplo de progama basico con datos:

//declaraion de variables
int numero1;
int numero2;
int resultado;

//pedir valores al usuario
Console.WriteLine("Ingrese un número: ");
Console.WriteLine("Ingrese otro número: ");

//convertir los valores ingresados por el usuario a números enteros y almacenarlos en las variables numero1 y numero2
numero1 = int.Parse(Console.ReadLine());
numero2 = int.Parse(Console.ReadLine());

//realizar la suma de los dos números y almacenar el resultado en la variable resultado
resultado = numero1 + numero2;
//mostrar el resultado de la suma en la consola
Console.WriteLine(resultado);

//!     UNIDAD 5
//? CICLO FOR AND WHILE

for (int x = 0; x < 5; x++)
{ // inicializacion de ciclo for.
    Console.WriteLine("Hello World!");

}

//*Ejemplo 2:
int n, promedio, suma = 0;

for (int x = 0; x < 5; x++)
{
    Console.WriteLine("Ingrese la nota: ");
    n = int.Parse(Console.ReadLine());
    suma += n;// se le asigna la nota y se le suma a "suma" la nueva nota ingresada.
}
promedio = suma / 5; //!se declara "AFUERA DEL FOR" el promedio que queremos saber de los 10 alumnos.
Console.WriteLine("El promedio de las notas es : " + promedio);


// WHILE 
// (MIENTRAAAAS ... SE DE ALGO... EJECUTA)

int a, cont = 0;
Console.WriteLine("ingresa un numero: ");//* Se pide el primer numero afuera, si cumple la condicion del while, entra a hacer el recorrido.
a = int.Parse(Console.ReadLine());

while (a != 0)
{ //! Condicion del While. Este va apedir numero mientras sean diferente a cero, al ingresar un cero, corta la itereción.
    cont++;     //* en el contador, se increminta cada numero ingresado. y muestra la cantidad de numeros ingresados.( sean 1 o 20 ej)
    Console.WriteLine("ingresa un numero: ");
    a = int.Parse(Console.ReadLine());
}
Console.WriteLine("Ingresaste una cantidad de : " + cont + " Numeros");
//La cosnola lanza el mensaje con el total de numeros guardados en la varaible "cont".


// Ciclo DO

int a, cont = 0;

do
{ //! en el DO, directamente, pide, da la primer vuelta, y despues pregunta al WHILE, si sigue iterendo.
    Console.WriteLine("ingresa un numero: ");
    a = int.Parse(Console.ReadLine());
    cont++;
} while (a != 0);
Console.WriteLine("Ingresaste una cantidad de : " + cont + " Numeros");

//TODO: //------------Ciclos COMBINADOS // LOTES Y SUBLOTES! ------------------//


// CICLOS COMBINADOS:
//*for con for 
//*Ejemplo 1:
//?Ejemplo: cargar edades de 5 equipos y sacar promedio.

int prom, acu, n;
for (int x = 0; x < 5; x++)
{
    acu = 0;
    for (int y = 0; y < 20; y++)
    {
        Console.WriteLine("Ingrese la edad: ");
        n = int.Parse(Console.ReadLine());
        acu += n;
    }
    prom = acu / 20;
    Console.WriteLine("El promedio de edad es: " + prom);
}




//*Ejemplo 2: (equipos mas jugadores)
int edad;
int cont;
double promedio;

// Bucle para recorrer los 5 equipos
for (int equipo = 1; equipo <= 5; equipo++)
{
    Console.WriteLine("Equipo número: " + equipo);
    cont = 0;// reiniciamos acumulador al inicio de cada equipo

    for (int jugador = 1; jugador <= 20; jugador++)// Bucle para recorrer los 20 jugadores
    {
        Console.Write("Edad del jugador " + jugador + ": ");
        edad = int.Parse(Console.ReadLine());

        cont += edad; // acumulamos edades
    }
    // cálculo del promedio
    promedio = cont / 20;
    Console.WriteLine("Promedio de edad del equipo " + equipo + ": " + promedio);
}


//*for con while ( El for pide 3 números, y el while asegura que cada uno sea válido.)
//?Ejemplo: pedir 3 números y validar que cada uno sea positivo.

for (int i = 1; i <= 3; i++) // ciclo externo
{
    int n;
    bool valido = false;

    while (!valido) // ciclo interno
    {
        Console.Write("Ingresa un número positivo: ");
        n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            Console.WriteLine("Número aceptado: " + n);
            valido = true; // rompe el while
        }
        else
        {
            Console.WriteLine("Error, debe ser positivo.");
        }
    }
}

//* While con for ( El while controla los lotes, el for recorre los elementos dentro de cada lote.)
//?Ejemplo: procesar lotes de datos, cada lote con 3 elementos.

int lote = 1;

while (lote <= 2) // ciclo externo: cantidad de lotes
{
    Console.WriteLine("Lote " + lote);

    for (int i = 1; i <= 3; i++) // ciclo interno: elementos del lote
    {
        Console.Write("Ingresa número del lote " + lote + ": ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Número ingresado: " + n);
    }

    lote++;
}

//*While con While ( El while externo controla la salida con 0, el interno valida que no se ingresen negativos.)
//?Ejemplo: pedir números hasta que el usuario ingrese 0, y dentro validar que sean positivos.

int n = -1;

while (n != 0) // ciclo externo: se repite hasta que se ingrese 0
{
    Console.Write("Ingresa un número (0 para salir): ");
    n = int.Parse(Console.ReadLine());

    int temp = n;
    while (temp < 0 && temp != 0) // ciclo interno: valida que no sea negativo
    {
        Console.Write("Número inválido, ingresa positivo o 0: ");
        temp = int.Parse(Console.ReadLine());
        n = temp;
    }

    if (n != 0)
        Console.WriteLine("Número aceptado: " + n);
}

//TODO:          //----------- CORTE DE CONTROL-------------- //

//! La estructura es casi siempre, "While dentro de While"


// Variables
int codEquipo, equipoActual;
float sueldo;

// Acumuladores generales
float sumaGeneral = 0;
int contadorGeneral = 0;

// Primera carga de datos
Console.WriteLine("Ingrese sueldo (0 para terminar): ");
sueldo = float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese código de equipo: ");
codEquipo = int.Parse(Console.ReadLine());

// Corte general: mientras el sueldo sea mayor a 0
while (sueldo > 0)
{
    // Guardamos el equipo actual
    equipoActual = codEquipo;

    // Acumuladores por equipo
    float sumaEquipo = 0;
    int contadorEquipo = 0;

    // Corte de control: mientras el código de equipo no cambie
    while (codEquipo == equipoActual && sueldo > 0)
    {
        // Procesar registro
        sumaEquipo += sueldo;
        contadorEquipo++;

        sumaGeneral += sueldo;
        contadorGeneral++;

        // Nueva carga de datos
        Console.WriteLine("Ingrese sueldo (0 para terminar): ");
        sueldo = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese código de equipo: ");
        codEquipo = int.Parse(Console.ReadLine());
        /*si al cargar datos, cargo otro codigo de equipo distinto...cambia de equipo, ya que pregunta a la
        condicion del segundo while y al ser distinto, sale.... y modifica el valor de la primer condicion 
        de "equipoActual" en el primer while y vuelve a entrar para seguir cargando*/

    }

    // Resultados por equipo
    if (contadorEquipo > 0)
    {
        float promedioEquipo = sumaEquipo / contadorEquipo;
        Console.WriteLine("Promedio de sueldos del equipo " + equipoActual + ": " + promedioEquipo);
        Console.WriteLine("-----------------------------------");
    }
}

// Resultados generales
if (contadorGeneral > 0)
{
    float promedioGeneral = sumaGeneral / contadorGeneral;
    Console.WriteLine("Promedio general de sueldos: " + promedioGeneral);
}

Console.WriteLine("Fin de la carga de datos.");


//TODO: ----- Vectores ----------!!! 

//* Declaracion de vector de enteros con 5 posiciones

int[] v = new int[5];

// Cargar valores en el vector usando un bucle
for (int x = 0; x < v.Length; x++)
{
    Console.Write("Ingrese un número para la posición " + x + ": ");
    v[x] = int.Parse(Console.ReadLine()); // guardamos el número en la posición x!
}
//* Recorremos el vector y mostramos cada valor junto con su índice.
Console.WriteLine("Valores cargados en el vector:");
for (int x = 0; x < v.Length; x++)
{
    Console.WriteLine("Posición " + x + ": " + v[x]);
}

int suma = 0;
for (int x = 0; x < v.Length; x++)
{
    suma += v[x]; // acumulamos cada número
}
Console.WriteLine("\nLa suma total es: " + suma);
//La suma nos sirve para calcular porcentajes.

Console.WriteLine("\nPorcentaje de cada número respecto al total:");

for (int x = 0; x < 5; x++)
{
    // calculamos el porcentaje de forma básica
    double porcentaje = v[x] * 100.0 / suma;

    Console.WriteLine("Número " + v[x] + " → " + porcentaje + "%");
}

////////-----------///////////
//EJEMPLOS 2

//int (long, short)
//float --- double ---decimal

// Vectores para guardar temperaturas de 31 días
double[] muestraMatutina = new double[31];
double[] muestraVespertina = new double[31];
double[] muestraNocturna = new double[31];

int dia;
double temperatura;

// --- Carga de datos matutinos ---
Console.WriteLine("Ingresa datos Matutinos");
for (int x = 0; x < 31; x++)
{
    Console.Write("Ingrese día (1 a 31): ");
    dia = int.Parse(Console.ReadLine());
    Console.Write("Ingrese temperatura registrada: ");
    temperatura = double.Parse(Console.ReadLine());

    muestraMatutina[dia - 1] = temperatura;
}

// --- Carga de datos vespertinos ---
Console.WriteLine("\nIngresa datos Vespertinos");
for (int x = 0; x < 31; x++)
{
    Console.Write("Ingrese día (1 a 31): ");
    dia = int.Parse(Console.ReadLine());
    Console.Write("Ingrese temperatura registrada: ");
    temperatura = double.Parse(Console.ReadLine());

    muestraVespertina[dia - 1] = temperatura;
}

// --- Carga de datos nocturnos ---
Console.WriteLine("\nIngresa datos Nocturnos");
for (int x = 0; x < 31; x++)
{
    Console.Write("Ingrese día (1 a 31): ");
    dia = int.Parse(Console.ReadLine());
    Console.Write("Ingrese temperatura registrada: ");
    temperatura = double.Parse(Console.ReadLine());

    muestraNocturna[dia - 1] = temperatura;
}

// --- Lectura y cálculo de promedios ---
double acuMatutina = 0, acuVespertina = 0, acuNocturna = 0;

for (int x = 0; x < 31; x++)
{
    acuMatutina += muestraMatutina[x];
    acuVespertina += muestraVespertina[x];
    acuNocturna += muestraNocturna[x];
}

Console.WriteLine("Promedio Matutino: " + (acuMatutina / 31));
Console.WriteLine("Promedio Vespertino: " + (acuVespertina / 31));
Console.WriteLine("Promedio Nocturno: " + (acuNocturna / 31));


//Todo: -------- FUNCIONES --------

//private static void Main(string[] args) //programa principal
{ //*primer cuerpo

    //! Programa principal donde se ejecuta paso a paso el programa.
    //! Hasta encontrar una INVOCACION DE FUNCION.
    //! Para luego seguir con el recorrido de codigo.
    int n1 = 0, n2 = 0, resultado; // declaro variables

    pedirDatos(ref n1, ref n2); //* invocacion de funcion por referencia.

    resultado = sumar(n1, n2);//* ---- invocación de función por parametro.
                              //fin de logica

    Console.WriteLine("El resultado es: " + resultado);
    //otro metodo, en donde tambien devuelve el valor concatenando directamente la funcion.

}

//  ---- Funciones : siempre se declaran fuera del "Programa Principal", fuera del primer cuerpo.------
//* Declaracion de funcion "sumar".
static int sumar(int a, int b)// solicita 2 parametros enteros!
{
    int r;
    r = a + b;//este toma los parametros ingresados por el usuario (n1 y n2)
    return r;
    //return: se retorna el resultado de la funcion "sumar", el cual se asignara a/en "resultado" (del main)
}

static void pedirDatos(ref int j, ref int h) //* declaracion de funcion para pedir datos al usuario!!
{
    Console.WriteLine("Ingresa un numero"); // carga mas guardado de datos
    j = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa otro numero..");
    h = int.Parse(Console.ReadLine());
}







