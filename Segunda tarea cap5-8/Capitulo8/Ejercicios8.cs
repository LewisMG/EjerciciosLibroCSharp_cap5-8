using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Capitulo8
{
    public class Ejercicios8
    {
        public static void Ejercicio8_3()
        {
            String fecha, ora;
            ora = DateTime.Now.ToString("h:mm: ss tt ");
            fecha = DateTime.Now.ToString("yyyy/dd/MM");
            Console.WriteLine("La hora es: {0} ", ora);
            Console.WriteLine("La fecha es:{0} ", fecha);
            Console.ReadKey();
        }

        public static void Ejercicio8_5()
        {
            string cadena, caden;
            ArrayList cadenas = new ArrayList();


            Console.WriteLine("Digite cadena 1");
            cadena = Console.ReadLine();
            cadenas.Add(cadena);

            Console.WriteLine("Digite cadena 2");
            caden = Console.ReadLine();
            cadenas.Add(caden);


            cadenas.Sort();

            foreach (string datos in cadenas)
            {
                Console.WriteLine("{0}", datos);
            }
            Console.ReadKey();
        }
    }
}
