using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCSharp
{
    //Clase define un bloque
    class Ejemplo5Bloques
    {
        //<<---reglas de bloques:--->>
        //Regla1:Todo lo que declaro dentro de un bloque lo puedo utilizar dentro del mismo bloque.
        //Regla2:No puedes acceder a elementos definidos en bloques internos desde un bloque externo.
        //Regla3:Puedes acceder a una variable definida en un bloque externo desde un bloque interno.
        //Regla4:Los Modificadores de acceso define el alcance de los elementos que existen dentro de una clase.
        //Un elemento "Public" puede ser alcanzado desde afuera y adentro de la clase. 
        //un elemento "private" solos puede ser alcanzado desde adentro de la clase.
        //Nota: Hay otros modificadores de acceso que permiten acceder a elementos de una clase desde afuera sin ser publicos.
        //Regla5: No podemos acceder a los elementos declarados en bloques hermanos
        //Los Bloques hermanos son aquellos que estan al mismo nivel, uno no contiene al otro, y son hijos del mismo padre.



        //------------------------------
        //Metodo main define un bloque
        static void Main7(string[] args)
        {
            string nombre = "David";
            nombre = "A.";
            edad = 31;

            var p = new Persona();
            p.paisOrigen = "Venezuela";
            p.obtenerEdad();

            Console.Read();
        }
        //Los Bloques hermanos son aquellos que estan al mismo nivel, uno no contiene al otro, y son hijos del mismo padre.

        //public void Main2()
        //{
        //    nombre = "A.";

        //}
        //Fin Los Bloques hermanos

        // fin Metodo main define un bloque
        static int edad = 31;
        //-------------------------------
        //clase persona define un bloque
        class Persona
        {
            public string paisOrigen;
            //Modificador de acceso private es privado.
            private int edad;

            public int obtenerEdad()
            {
                return edad;
            }
        }
        //fin clase persona define un bloque
    }
    //fin Clase define un bloque

}
