using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Segunda_tarea_cap5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = string.Empty;
            int opcion = 0;
           
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Ejercicio 5.4");
                Console.WriteLine("2 - Ejercicio 5.5");
                Console.WriteLine("3 - Ejercicio 7.1");
                Console.WriteLine("4 - Ejercicio 7.2");
                Console.WriteLine("5 - Ejercicio 7.5");
                Console.WriteLine("6 - Ejercicio 8.3");
                Console.WriteLine("7 - Ejercicio 8.5");
                Console.Write("Seleccione el ejercicio del 1 al 7:");
                entrada = Console.ReadLine();
                opcion = Convert.ToInt32(entrada);
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ejercicio 5.4");
                        Capitulo5.Ejercicios5.Ejercicio5_4();
                        break;

                    case 2:
                        Console.WriteLine("Ejercicio 1.5");
                        Capitulo5.Ejercicios5.Ejercicio5_5();
                        break;
                    case 3:
                        Console.WriteLine("Ejercicio 7.1");
                        Capitulo7.Ejercicios7.Ejercicio7_1();
                        break;
                    case 4:
                        Console.WriteLine("Ejercicio 7.2");
                        Capitulo7.Ejercicios7.Ejercicio7_2();
                        break;
                    case 5:
                        Console.WriteLine("Ejercicio 7.5");
                        Capitulo7.Ejercicios7.Ejercicio7_5();
                        break;
                    case 6:
                        Console.WriteLine("Ejercicio 8.3");
                        Capitulo8.Ejercicios8.Ejercicio8_3();
                        break;
                    case 7:
                        Console.WriteLine("Ejercicio 8.5");
                        Capitulo8.Ejercicios8.Ejercicio8_5();
                        break;
                    default:
                        Console.WriteLine("Opción no valida");
                        break;
                }
            } while (opcion != 0);
            Console.ReadKey();
        }
    }
}
