using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo7
{
    public class Ejercicios7
    {
        private static string entrada = string.Empty;

        public static void Ejercicio7_1()
        {
            int calificaciones = 0;
            int promedio = 0, max = 0, min = 0;
            ArrayList clase = new ArrayList();
            Console.WriteLine("Programa que Dice el promedio, la maxima y la minima calificacion de un grupo de estudiantes");
            for (int x = 0; ; x++)
            {
                Console.WriteLine("Ingrese 1 cuando desee dejar de registrar calificaciones");
                Console.WriteLine("Ingrese calificacion");
                entrada = Console.ReadLine();
                calificaciones = Convert.ToInt32(entrada);
                if (calificaciones == 1)
                    break;
                clase.Add(calificaciones);

            }

            foreach (int datos in clase)
            {

                promedio = promedio + datos;
                if (min == 0)
                    min = datos;

                if (datos > max)
                    max = datos;

                if (min > datos)
                    min = datos;

            }

            Console.WriteLine("El promedio es {0}", promedio / clase.Count);
            Console.WriteLine("la calificacion maxima es {0}", max);
            Console.WriteLine("la calificacion minima es {0}", min);
            Console.ReadKey();
        }

        public static void Ejercicio7_2()
        {
            Console.WriteLine("Diccionario Utilizando Hashtable");
            Hashtable Diccionario = new Hashtable();
            
            int op = 0;
            bool existe = false;
            Diccionario.Add("violia", "Tabla utilizada para planchar.");
            Diccionario.Add("concomerse", "Consumirse de impaciencia, arrepentimiento o envidia.");
            Diccionario.Add("desacatar", "Faltar a la reverencia o al respeto");
            do
            {
                Console.WriteLine("El diccionario esta limitado a varias palabras las cuales son: \n *violia \n *concomerse \n *desacatar");

                Console.WriteLine("Ingrese la palabra que desea");
                entrada = Console.ReadLine();


                foreach (DictionaryEntry datos in Diccionario)
                {


                    if (entrada == (string)datos.Key)
                    {
                        Console.WriteLine("El Concepto de {0} es:  {1}", datos.Key, datos.Value);
                        break;

                    }

                }

                existe = Diccionario.Contains(entrada);
                if (existe == false)
                    Console.WriteLine("La palabra ingresada no se encuentra en el diccionario");

                Console.WriteLine("Digite 0 para salir, 1 para continuar");
                entrada = Console.ReadLine();
                op = Convert.ToInt32(entrada);

            } while (op != 0);
            Console.ReadKey();
        }

        public struct Agendas
        {
            public String Nombre;
            public String telefono;
        }

        public static void Ejercicio7_5()
        {
            int salir = 0;
            ArrayList Agenda = new ArrayList();
            Agendas h = new Agendas();

            for (int x = 0; ; x++)
            {
                Console.WriteLine("Ingrese el nombre");
                h.Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el numero de telefono");
                h.telefono = Console.ReadLine();

                Agenda.Add(h);

                Console.WriteLine("Si desea salir ingrese '0' si no ingrese '1'");
                entrada = Console.ReadLine();
                salir = Convert.ToInt32(entrada);
                if (salir == 0 || salir == 0)
                    break;
            }


            foreach (Agendas datos in Agenda)
            {
                Console.WriteLine("Datos de la personas {0} {1}", datos.Nombre, datos.telefono);

            }
            Console.ReadKey();
        }
    }
}
