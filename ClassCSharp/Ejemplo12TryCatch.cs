using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCSharp
{
    class Ejemplo12TryCatch
    {
        static void Main(string[] args)
        {
            //Trycatch: nos permite manejar una excepcion en un bloque
            int a = 1;
            int b = 0;
            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            //Exception: es todo error que puede ocurrir
            //Catch: se utilizan para mitigar una situacion.
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha habido un error!");
            }
            //finally: nos sirve para ejecutar un bloque de codigo que no halla un error o que exita un error.
            //Tambien para librar recursos, y abrir y cerrar un recurso.
            finally
            {
                Console.WriteLine("Siempre se va ejecutar");
            }

            Console.Read();
        }
    }
}
