using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pascual.Casos
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("*************************");
                Console.WriteLine("           MENU          ");
                Console.WriteLine("*************************");
                Console.WriteLine("1. Registrar Persona");
                Console.WriteLine("2. Consultar Persona");
                Console.WriteLine("3. Mostrar Todas");
                Console.WriteLine("4. Salir");
                Console.WriteLine("*************************");

                Console.Write("Digite su opción: ");
                int opcion = 0;// default(int)
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarPersona();
                        break;
                    case 2:
                        ConsultarPersona();
                        break;
                    case 3:
                        MostrarTodas();
                        break;
                    case 4:
                        Salir();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }
                
            }

            Console.ReadLine();

        }

        private static void Salir()
        {
            Console.WriteLine("Metodo Salir");
        }

        private static void MostrarTodas()
        {
            Console.WriteLine("Metodo Mostrar Todas");
        }

        private static void ConsultarPersona()
        {
            Console.WriteLine("Metodo Consultar Persona");
        }

        private static void RegistrarPersona()
        {
            Console.WriteLine("Metodo Registrar Persona");
        }
    }
}
