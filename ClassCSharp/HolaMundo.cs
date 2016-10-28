//los "using" es poner las clases que reciben lo que hay dentro del namespace. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se declara el namespace: esto significa que todas las clases que se creen aca solo seran accedidas atraves de namespace
namespace ClassCSharp
{
    //La llave define lo que estara dentro y se le llama bloque a lo que esta en el interior de las llaves.
    class HolaMundo
    {
        //Ejemplo de hola mundo
        //Creamos clase "Console": Permite mostrar mensaje en la consola
        //le daremos punto a Console. Aca mostrara los miembros de la clase "Console" 
        //entre parentesis y comillas es lo que le pasamos en el mensaje de console.
        //Esta es una sentencia la cual debe terminar en punto y coma ;
        //Sentencia es una instrucion que le damos a la computadora. en C# estas terminan en ;
        //Ejemplo:

            //El metodo main sera el punto de inicio de la aplicacion
            //Los metodos son bloques de codigo que podemos ejecutar cuantas veces queramos.
            //pueden recibir valores de entrada, llamado parametros. tambien puede devolver valores si se desea.
        static void Main1(string[] args)
        {
            //Metodos miembros que realizan una accion
            //WriteLine es el metodo que escribe en pantalla
            Console.WriteLine("Hola Mundo");
            //Read es el metodo que lee y muestra mensaje.
            Console.Read();
        }
    }
    //>>>>VARIABLES<<<<<

    //Una variable debera contener una sintaxis;
    //tipo de identificador: 
    //tipo:  dato que se almacena la variable, puede ser numero, entero, cadena de caracteres, fecha , booleano y otros...
    // Identificador: es el nombre de la variable.
    //public class Variables
    //{
    //static void Main(string[] args)
    //{
    //Ejemplo de declaracion de una variable:
    //Numeros enteros

             //int mes;

    //Cadenas de textos

             //string nombre;

    //Tipo de datos de fecha

             //DateTime fechaEntrada;

    //Son valores verdaderos y falsos

            //bool procesoTerminado;

    //Ejemplo iniciando variable;

            //mes = 7;

    //Se escribe entre doble comilla porque es cadena de texto.


            //nombre = "David";
            //procesoTerminado = true;
            //procesoTerminado = false;


    //Se puede inicializar y declarar en una misma linea


           //string direccion = "avenida 2323";

    //}
    //}
}
