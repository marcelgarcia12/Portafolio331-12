using System;
// Espacio de nombres
namespace CS2
{
     // Clase principal
    class Program
    {
        // Función principal
        static void Main(string[] args)
        {
           // Sesión 5: Tipos de datos
           // Sintaxis para declarar variables
           // tipo_de_dato identificador_variable;
           // 1. Entero
           int a;
           // 2. Cadena de texto
           string s;
           // 3. Flotante (precisión sencilla)
           float f;
           // 3.2 Flotante (precisión doble)
           double d;
           // 4. Booleano (lógico)
           bool b;
           // Inicializaciones
           a = 5;
           s = "Exactas";
           f = 8.5F;
           d = 9.5D;
           b = true;
           // Palabra reservada: Identificador especial predefinido para el compilador.
           // Interpolación: Combinación de datos dentro de una cadena.
           // Impresiones
           Console.WriteLine($"Entero: {a}");
           Console.WriteLine($"Flotante (precisión sencilla): {f}");
           Console.WriteLine($"Flotante (precisión doble): {d}");
           Console.WriteLine($"Cadena de texto: {s}");
           Console.WriteLine($"Booleano: {b}");
        } // Término de la función principal   
    } // Término de la clase principal
} // Término del espacio de nombres