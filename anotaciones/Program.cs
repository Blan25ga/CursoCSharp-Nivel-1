// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// --- Comandos de cd ---


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


// --- Comandos de consola: ---

// dotnet run: para ejecutar el programa.

// dotnet build: para compilar el programa, es decir, convertir el código fuente en un archivo ejecutable.

// dotnet clean: para limpiar los archivos generados por la compilación, es decir, eliminar los archivos ejecutables y otros archivos temporales generados por el proceso de compilación.
// Esto es útil para asegurarse de que la próxima compilación se realice desde cero, sin utilizar archivos antiguos que puedan causar problemas.

// dotnet new console: para crear un nuevo proyecto de consola, es decir, un proyecto que se ejecuta en la línea de comandos y no tiene una interfaz gráfica de usuario. 
// Este comando crea una estructura básica de archivos y carpetas para un proyecto de consola, incluyendo un archivo Program.cs con un código de ejemplo que imprime "Hello, World!" en la consola.



// --- Comandos de nombre Console: ---

// Console.WriteLine(): para mostrar un mensaje en la consola.

// Console.ReadLine(): para leer lo que el usuario ingresa por teclado. Este comando devuelve una cadena de texto (string) con el valor ingresado por el usuario.

// Console.Write(): para mostrar un mensaje en la consola sin saltar a la siguiente línea. 
//Es decir, el cursor se queda en la misma línea después de mostrar el mensaje, lo que permite que el usuario ingrese su respuesta en la misma línea.



// --- Tipos de variables: ---

// int: para almacenar números enteros, es decir, sin decimales. Ejemplo: 1, 2, -3, 0.

// float: para almacenar números decimales, es decir, con parte fraccionaria. Ejemplo: 3.14, -0.5, 0.0.

// char: para almacenar un solo carácter, es decir, una letra, un número o un símbolo. Ejemplo: 'a', '1', '$'.

// bool: para almacenar valores booleanos, es decir, true (verdadero) o false (falso).
// Estos valores se pueden representar también como 1 (true) y 0 (false).

// string: para almacenar cadenas de texto, es decir, una secuencia de caracteres. Ejemplo: "Hola", "123", "true".


// --- Covertidores de valores---

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







