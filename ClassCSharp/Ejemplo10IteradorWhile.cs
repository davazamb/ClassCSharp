using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCSharp
{
    class Ejemplo10IteradorWhile
    {
        static void Main12(string[] args)
        {
            List<string> nombres = new List<string>() { "david", "maria", "pedro", "marlene" };
            
            //While: crea condicion true o false en el bucle de codigo recorriendo una lista
            int j = 0;
            while (j < nombres.Count)
            {
                Console.WriteLine(nombres[j].ToUpper());
                j++;
                var respuestaUsuario = Console.ReadLine();
                if(respuestaUsuario.ToUpper() == "C")
                { 
                //break: funciona para deterner la ejecucion de un bucle
                break;
                }

            }

            Console.Read();
        }
    }
}
