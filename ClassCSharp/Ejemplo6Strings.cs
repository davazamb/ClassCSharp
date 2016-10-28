using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCSharp
{
    class Ejemplo6Strings
    {
        static void Main(string[] args)
        {
            //Subcadenas creadas
            string nombre = "David";
            string frase = "Bienvenido aca mundo";

            //Length: nos permite conocer la longitud de un string
            Console.WriteLine(nombre.Length);
            Console.WriteLine(frase.Length);

            //sybstring: nos permite extraer una subcadena de texto del string
            Console.WriteLine(nombre.Substring(3));
            Console.WriteLine(frase.Substring(11, 3));

            //startswith: nos permite verificar si un string comienza con una subcadena predeterminada
            Console.WriteLine(frase.StartsWith("mundo"));
            Console.WriteLine(frase.StartsWith("aca"));

            //endswith: nos permite verificar si un string termina con una subcadena predeterminada 
            Console.WriteLine(frase.EndsWith("aca"));
            Console.WriteLine(frase.EndsWith("mundo"));

            //contains: nos permite verificar si una subcadena existe en cualquier parte del string terminado
            Console.WriteLine(frase.Contains("David"));
            Console.WriteLine(frase.Contains("mundo"));

            //indexof: nos permite apartir de cual caracter se encuentra una determinada subcadena.
            var indiceDeMundo = frase.IndexOf("mundo");           
            var indiceDeBienvenido = frase.IndexOf("Bienvenidos");

            Console.WriteLine(indiceDeMundo);
            Console.WriteLine(indiceDeBienvenido);

            //operador +: nos permite sumar strings, esto concatena los string. 
            Console.WriteLine(nombre + ", " + frase);

            //ToLower: nos permite escribir en miniscula todo el contenido de un string.
            Console.WriteLine(frase.ToLower());

            //ToUpper: nos permite escribir en mayuscula todo el contenido de un string.
            Console.WriteLine(frase.ToUpper());

            //Trim: nos permite eliminar los espacios que hay al principio y al final de una cadena de texto.
            string ejemploTrim = " David ";
            Console.WriteLine(ejemploTrim);
            Console.WriteLine(ejemploTrim.Trim());

            //Format: nos permite  hacer sustituciones de subcadenas especiales dentro de un string.
            string ejemploFormat = "Bienvenido {0} a la progrmacion c# intento {1}! {1}";
            var resultadoFormat = string.Format(ejemploFormat, nombre, 30);
            Console.WriteLine(resultadoFormat);

            //Replace: nos permite hacer reemplazos dentro de un string en vez de usar {0} nos da mas libertad en lo que se va a reemplazar
            string ejemploReplace = "Bienvenido @nombre a la progrmacion c# intentos @intento!";
            var resultadoReplace = ejemploReplace.Replace("@nombre", nombre);
            resultadoReplace = resultadoReplace.Replace("@intento", "40");
            Console.WriteLine(resultadoReplace);

            //IsNullOrWhiteSpace: nos permite saber si un string consiste de espacios en blancos o es nulo.
            string stringEspaciosEnBlanco = "      ";
            string stringNULO = null;
            Console.WriteLine(string.IsNullOrWhiteSpace(stringEspaciosEnBlanco));
            Console.WriteLine(string.IsNullOrWhiteSpace(stringNULO));
            Console.WriteLine(string.IsNullOrWhiteSpace(nombre));


            Console.Read();
        }
    }
}
