using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pascual.Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = string.Empty;
            string apellido = string.Empty;

            Console.WriteLine("Cual es el nombre:");
            nombre = Console.ReadLine();
            
            Console.WriteLine("Cual es el apellido:");
            apellido = Console.ReadLine();

            Imprimir(nombre, true);

            Imprimir(apellido, false);

            /*if (nombre == string.Empty)
                Console.WriteLine("No ha escrito el nombre");
            else
                Console.WriteLine("El nombre es: " + nombre);
            */
            Console.ReadLine();
            
        }

        //alcance - tipo - nombre ( parametros )
        private static void Imprimir(string valor, bool esNombre)
        {
            string complemento = string.Empty;
            if (esNombre)
                complemento = "nombre";
            else
                complemento = "apellido";

            //No intente esto en el examen
            //string complemento = esNombre ? "nombre" : "apellido";

            if (valor == string.Empty)
                Console.WriteLine("No ha escrito el " + complemento);
            else
                Console.WriteLine("El " + complemento + " es: " + valor);
        }
    }
}
