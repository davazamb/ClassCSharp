using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCSharp
{
    class Ejemplo7CondicionalesIF
    {
        static void Main9(string[] args)
        {            
            string nombre = "DavidA";
            string nombreMayuscula = "DAVIDA";
            string frase = "Bienvenido aca mundo";

            var longitudNombre = nombre.Length;
            Console.WriteLine(longitudNombre);
            if(longitudNombre == 2)
            {
                Console.WriteLine(longitudNombre);
            }
            else if (longitudNombre == 4)
            {
                Console.WriteLine(frase.Length);
            }
            else if (longitudNombre == 5)
            {
                Console.WriteLine("Longitud 5");
            }
            else if (longitudNombre == 6)
            {
                Console.WriteLine("Longitud 5");
                Console.WriteLine("Bien");
                Console.WriteLine("Vamos");
                //se extrae y se crea un metodo
                NewMethod(nombre, nombreMayuscula);
            }
            else
            {
                Console.WriteLine(nombre == nombreMayuscula);
            }

            Console.Read();
        }

        //metodo if
        private static void NewMethod(string nombre, string nombreMayuscula)
        {
            if (nombre.ToUpper() == nombreMayuscula)
            {
                Console.WriteLine("Los Nombres son iguales");
            }
        }
    }
}
