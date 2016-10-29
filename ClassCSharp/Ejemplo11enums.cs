using Operaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCSharp
{
    #region Ejemplo1
    //enum EstatusOperacion
    //{
    //    Exitoso = 1,
    //    ClienteNoEncontrado = 2,
    //    ErrorSistema = 5
    //}
    class Ejemplo11enums
    {
        //static void Main11(string[] args)
        //{
        //    int estatusOperacion = 5;

        //    if (estatusOperacion == (int)EstatusOperacion.Exitoso)
        //    {
        //        //
        //    }
        //    else if (estatusOperacion == (int)EstatusOperacion.ClienteNoEncontrado)
        //    {
        //        //
        //    }
        //    else if (estatusOperacion == (int)EstatusOperacion.ErrorSistema)
        //    {
        //        //
        //    }

        //    Console.Read();
        //}

        
        #endregion

        #region Ejemplo2
        static void Main13(string[] args)
        {
            string estatusOperacion = "E123";

            if (estatusOperacion == EstatusOperaciones._exitoso)
            {
                //
            }
            else if (estatusOperacion == EstatusOperaciones._clienteNoEncontrado)
            {
                //
            }
            else if (estatusOperacion == EstatusOperaciones._errorSistema)
            {
                //
            }

            Console.Read();
        }
    }
    //Normalmente no creamos varias clases en el mismo archivo. 

    #endregion
}
//se agrega una clase nueva para archivar los metodos o clases
namespace Operaciones
{
    /// <summary>
    /// Estatus de las operaciones exitos y erroneas
    /// </summary>
    public static class EstatusOperaciones
    {
        public const string _exitoso = "E123";
        public const string _clienteNoEncontrado = "C123";
        public const string _errorSistema = "S123";
    }
}