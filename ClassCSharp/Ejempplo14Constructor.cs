using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCSharp
{
    class Ejempplo14Constructor
    {
        static void Main(string[] args)
        {
            //no tiene parametros
            //var v = new vector();
            //con parametros
            var v2 = new vector(new List<int> { 1, 2});
            Console.WriteLine(v2.valores.ToString());
            Console.WriteLine(v2.Dimension);
            //v2.Nombre = "vector 1";
            v2[0] = 5;
            Console.WriteLine("Indexador");
            Console.WriteLine(v2[0]);
            Console.WriteLine(v2.valores[0]);


            Console.WriteLine(v2.Nombre);
            Console.Read();
        }

        class vector
        {
            //Constructor: es el primer metodo que se ejecuta al instancia una clase
            //La sintaxis de un contructor la compone: modificador  de acceso "public" el nombre de la clase "vector" 
            //parentesis donde voy a indicar los valores de entrada
            //public vector()
            //{

            //}
            //campo: es una variable declarada en el cuerpo de una clase o estructura. dentro de la clase.
            private List<int> _valores;

            //Propiedad: una propiedad, nos permiten encapsular la logica de lectura y escritura de las variables de la clase.
            //Podemos establecer si es lectura "get" o escritura "set".
            public List<int> valores
            { get { return _valores; } }

            //
            public int Dimension { get { return _valores.Count; } }

            //me permite definir una variable para agregarla y obtener un valor
            public string Nombre { get; set; }


            //Indexadores: nos permite poder acceder al enecimo elemento de la coleccion
            public int this[int i]
            {
                get { return _valores[i]; }
                //value: representa el valor que le estamos asignando a una propiedad. ene este caso 5. linea 20 v2[0] = 5;
                set { _valores[i] = value; }
            }


            //constructor con valores en parametros
            public vector(List<int> valores)
            {
                _valores = valores;
            }
        }
    }
}
