using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo5
{
    public class Ejercicios5
    {
        private static string entrada = string.Empty;

        public static int factorial(int n)
        {
            if (n < 0)
                return 1;
            if (n == 1)
                return 1;
            else
                return n * factorial(n - 1);
        }

        public static void Ejercicio5_4()
        {
            int n = 0, factoriall = 0;  
            Console.WriteLine("Ingrese un numero entero:");
            entrada = Console.ReadLine();
            n = Convert.ToInt32(entrada);
            factoriall = factorial(n);
            Console.WriteLine(factoriall);
            Console.ReadKey();
        }
        public static void Ejercicio5_5()
        {
            int n = 0;
            string res = String.Empty;
            Console.WriteLine("Ingrese un numero del 1 al 10:");
            entrada = Console.ReadLine();
            n = Convert.ToInt32(entrada);

            if (n == 1) { res = "UNO"; }
            else if (n == 2) { res = "DOS"; }
            else if (n == 3) { res = "TRES"; }
            else if (n == 4) { res = "CUATRO"; }
            else if (n == 5) { res = "CINCO"; }
            else if (n == 6) { res = "SEIS"; }
            else if (n == 7) { res = "SIETE"; }
            else if (n == 8) { res = "OCHO"; }
            else if (n == 9) { res = "NUEVE"; }
            else if (n == 10) { res = "DIEZ"; }

            Console.Write(res);
            Console.ReadKey();
        }

        /*public static int Ejercicio5_5(int n)
        {

        }*/
    }
}
