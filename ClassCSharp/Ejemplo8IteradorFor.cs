using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCSharp
{
    class Ejemplo8IteradorFor
    {
        static void Main10(string[] args)
        {
            //Iteradores o bucles: nos permite repetir una accion tantas veces.
            //en el ejemplo desde valor i = 1 y hasta i <= 10 y i++ para ir cambiando aumentando la i de uno en uno
            //i++ es lo mismo i + 1
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            List<string> nombres = new List<string>() { "david", "maria", "pedro", "marlene"};
            
            //las listas "List<>" i = 0 comienzan desde 0
            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine(nombres[i].ToUpper());
            }


            //Ejemplo Break For
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    //Ejemplo Break For
                    //break;
                    continue;
                }
                Console.WriteLine(i);

            }

            Console.Read();
        }
    }
}
