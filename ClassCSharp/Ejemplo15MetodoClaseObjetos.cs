using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCSharp
{
    class Ejemplo15MetodoClaseObjetos
    {
        //metodo principal no retorna nada es void
        static void Main(string[] args)
        {
            var v1 = new Vector(new List<int> { 1, 2 });
            var v2 = new Vector(new List<int> { 3, 4 });
            //Vector vectorSuma = v1.Sumas(v2);

            Console.Read();
        }
    }

    class Vector
    {
        //Campo
        private List<int> _componentes;

        //Propiedades
        public List<int> Componentes
        {
            get
            {
                return _componentes;
            }
        }
        //Indexadores: nos permite poder acceder al enecimo elemento de la coleccion
        public int this[int i]
        {
            get { return _componentes[i]; }
            set { _componentes[i] = value; }
        }

        public int Dimension
        {
            get
            {
                return _componentes.Count;
            }
        }
        //Constructor
        public Vector(List<int> Componentes)
        {
            _componentes = Componentes;
        }

        //    public Vector Sumas(Vector v2)
        //    {
        //        if (Dimension != v2.Dimension)
        //        {
        //            throw new ApplicationException("Las dimensiones no son iguales");
        //        }

        //        List<int> resultado = new List<int>();

        //        for (int i = 0; i < Dimension; i++)
        //        { resultado.Add(this[i]) + v2[i]);
        //    }
        //    return new vector(resulado);
        //}
    }
        
 }

    

