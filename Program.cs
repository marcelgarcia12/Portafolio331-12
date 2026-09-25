using System;
namespace SE1
{
    class Program
    {
        static void Main(string[] args)
        { 
           // Sesión 9: Examen
           // Sesión 10: Solución de examen   
           // 1. Proyecto en C#
           // 2. Sintaxis
           // Tipo_de_dato indetificador_variable = valor_inicial;
           bool a;
           int numero;
           // 3. Interpolacion
           // Combinacion de datos dentro de una cadena.
           a = true;
           numero = 10;
           Console.WriteLine($"Booleano: {a}");
           Console.WriteLine($"Número: {numero}");
           // 4. Incrementos y decrementos
           int m = 0;
           int n = -1;
           m += 1;
           n -= 3;
           m -= 5;
           n += 9;
           // 5. Operador resto (módulo)
           int residuo = 40 % 16;
           Console.WriteLine($"Residuo: {residuo}");
           // 6. Operadores aritméticos
           double operacion = 0;
           operacion = ((30 +8 -2) /2) * -1;
           Console.WriteLine($"Operación: {operacion}");
           // Sesión 11: Solución de examen (..continuación)
           // 7. Interruptores
           bool interruptor_1 = true;
           bool interruptor_2 = true;
           bool bombilla = false;
           if (interruptor_1 && interruptor_2)
           {
               bombilla = true;
           }
           else
            {
                bombilla = false;
            }
            Console.WriteLine($"Bombilla: {bombilla}");
            // 8. Asueto
            int dia = 16;
            string mes = "septiembre";
            if (dia == 16 && mes == "septiembre")
            {
                Console.WriteLine("Asueto");
            }
            else
            {
                Console.WriteLine("Sin definir");
            }
            // 9. Expresión
            bool resultado = 7 < 11 && 9 != 0; 
            Console.WriteLine($"Expresión: {resultado}");
        }
    }
}