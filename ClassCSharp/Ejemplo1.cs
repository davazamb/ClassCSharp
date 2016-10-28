using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCSharp
{
    class Ejemplo1
    {
        static void Main3(string[] args)
        {
            //Metodos miembros que realizan una accion
            Ejemplo_1_NombreEdad();
            Console.Read();
        }
        static void Ejemplo_1_NombreEdad()
        {
            // Declaramos las variables nombre y edad
            string nombre;
            int edad;

            Console.Write("Ingrese su nombre: ");

            // Lo que el usuario escriba será asignado a la variable nombre
            nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            // Lo que el usuario escriba ahora será asignado a su edad (debe ser un entero)
            //int.parse para convertir el tipo string a tipo int
            edad = int.Parse(Console.ReadLine());

            // Armamos el mensaje final.
            //El metodo Format de la clase string nos permite insertar valores en un string de una manera sencilla.
            //{0} y {1} anotacion especial del metodo format que sera el remplazo de nombre y edad.
            string mensajeFinal = string.Format("Usted se llama {0} y tiene {1} años de edad", nombre, edad);

            // Mostramos el mensaje final
            Console.WriteLine(mensajeFinal);
        }
    }
}
