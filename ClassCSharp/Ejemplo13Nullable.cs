using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCSharp
{
    class Ejemplo13Nullable
    {
        static void Main(string[] args)
        {
            var persona = new Persona()
            {
                nombre = "David",
                edad = 31
            };
            //Null: cuando no existe un valor se le coloca null, dando idea de que esta nulo no exite.
            persona = null;

            //Nullable: es util para asignarle nulo a valores que no tenemos
            Nullable<int> numero = 31;
            numero = null;

            DateTime? fechaDeNacimiento = null;
            fechaDeNacimiento = new DateTime(2016, 1, 10);
            if(numero.HasValue)
            {
                Console.WriteLine("El numero tiene valor");
            }
            if (fechaDeNacimiento.HasValue)
            {

                Console.WriteLine("La fecha tiene valor");
            }
            Console.Read();
        }

        class Persona
        {
            public string nombre;
            public int edad;
        }
    }
}
