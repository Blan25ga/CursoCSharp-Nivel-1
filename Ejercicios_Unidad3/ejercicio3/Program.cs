/*
3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

Si el importe es menor a ARS 1000, no hay descuento.
Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
Si el importe es ARS 5000 o más, aplica un descuento del 18%.
Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.*/


Console.Write("Ingrese el importe de la venta: "); // Muestra un mensaje en pantalla
float impV = float.Parse(Console.ReadLine()); // Lee lo que ingresa el usuario, lo convierte a número (float) y lo guarda en impV
float impFinal; // Declara la variable donde se guardará el importe final con descuento

        if (impV < 1000) // Si el importe es menor a 1000
        {
            impFinal = impV; // No hay descuento, el importe final es igual al importe ingresado
        Console.WriteLine("El importe final es: ARS " + impFinal); // Muestra el importe final por pantalla

        }
        else if (impV >= 1000 && impV < 5000) // Si el importe es 1000 o más pero menor a 5000
        {
            impFinal = impV * 0.90f; // Aplica un descuento del 10% (multiplica por 0.90)
        Console.WriteLine("El importe final con el 10% de descuento es: ARS " + impFinal);
        }
        else // Si el importe es 5000 o más
        {
            impFinal = impV * 0.82f; // Aplica un descuento del 18% (multiplica por 0.82)
        Console.WriteLine("El Importe final con 18% de descuento: ARS " + impFinal);
        }

