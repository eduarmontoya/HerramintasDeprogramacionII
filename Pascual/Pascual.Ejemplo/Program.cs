using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pascual.Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {

            //tipo de dato - nombre de la variable - igual - inicializar
            string nombreCompleto = string.Empty;
            Console.WriteLine("¿Cual es su nombre?");
            //nombreCompleto = "Lina";
            //nombreCompleto = otra;
            nombreCompleto = Console.ReadLine();

            if (nombreCompleto == string.Empty)
            {
                Console.WriteLine("Hola Mundo");
            }
            else
            {
                Console.WriteLine("Hola " + nombreCompleto);
            }          
            
            Console.ReadLine();



        }
    }
}
