using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCSharp
{
    class Ejemplo2Persona
    {
        static void Main4(string[] args)
        {
            //la variable p es un objeto. inicalizar un objeto recibe el nombre de "instanciar una clase"
            //sera el constructor de la clase
            Persona p = new Persona();
            p.Nombre = "David";
            p.Edad = 31;
            p.Direccion = "san cristobal";
            p.MostrarDatosenConsola();

            Persona p2 = new Persona();
            p2.Nombre = "Maria";
            p2.Edad = 20;
            p2.Direccion = "cristobal";
            p2.MostrarDatosenConsola();
            Console.Read();
        }
        //la clase que crea
        class Persona
        {
            //Public es un modificador de acceso que indica que podemos usar los campos desde afuera de la clase persona.
            //Sera publicos
            public string Nombre;
            public int Edad;
            public string Direccion;

            //Metodo para mostrar los valores de la varible p
            //se crea un metodo que no tiene valor de retorno
            public void MostrarDatosenConsola()
            {
                string mensajeFinal = "Usted se llama {0} y tiene {1} años de edad y su direccion es {2}";
                mensajeFinal = string.Format(mensajeFinal, Nombre, Edad, Direccion);
                Console.WriteLine(mensajeFinal);
            }
        }
    }
}
