using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCSharp
{
    class Ejemplo9IteradorForeach
    {
        static void Main(string[] args)
        {
            //El Iterador Foreach: itera todos los elementos de una lista
        
            List<string> nombres = new List<string>() { "david", "maria", "pedro", "marlene" };

            //foreach: el string nombre son los elementos de la lista. in nombres es nombre de la lista
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre.ToUpper());
            }
            
            Console.Read();
        }
        //Diferencia entre For y Foreach
        //Que en Foreach te permite una sintaxis mucho mas limpia. 
        //Foreach tiene una limitacion en cuanto al for que no puede editar los elementos de una lista que esta iterando.
    }
}
