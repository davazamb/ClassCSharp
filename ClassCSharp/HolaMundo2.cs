using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCSharp
{
    class HolaMundo2
    {
        static void Main2(string[] args)
        {
            EscribeHolaMundo();
            Console.WriteLine("Me llamo David");
            IdentificadorDelMetodo("valor1", "valor1", 6);
            int sumando1 = 23;
            int sumando2 = 72;
            int resultado = Suma(sumando1, sumando2);
            Console.WriteLine(resultado);
            Console.Read();

        }
        //Metodo que devolvera un valro
        static int Suma(int a, int b)
        {
            //para devolver un valor se usa return
            return a + b; 
        }



        //Creamos un metodo escribeholamundo
        //void EscribeHolaMundo() El cual debe ser estatico
        //Dentro de un metodo estatico de una clase solo puedes llamar otros metodos estaticos de la misma clase,
        //o a menos que instancies la clase.
        static void EscribeHolaMundo()
        {
            Console.WriteLine("Hola Mundo");
        }

        //Cadena de texto para escribir en consola pero debe incluir los paramatros (string valor)
        static void EscribeEnLaConsola(string valor)
        {
            Console.WriteLine(valor);
        }

        //sisntasis de un metodo estatico se pueden colocar tantas variables de entrada
        //los valores se declaran en el main
        //Void> son aquellos metodos que no tiene valores de salida, es decir que no devuelve un resultado de quien los invoca.
        static void IdentificadorDelMetodo(string parametro1, string parametro2, int etc)
        {
            
        }
    }
}
