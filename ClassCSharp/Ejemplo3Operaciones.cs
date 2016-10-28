using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCSharp
{
    class Ejemplo3Operaciones
    {
        static void Main5(string[] args)
        {
            //Metodos miembros que realizan una accion
            Operadores_Ejemplos();
            Console.Read();
        }
        private static void Operadores_Ejemplos()
        {
            // asignación
            var a = 1;
            var b = 2;
            var c = 8;
            var d = 9;
            string templateEncabezado = "\n--- {0} ---\n";

            Console.WriteLine(templateEncabezado, "Operaciones aritméticas");
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", c, a, c - a);
            Console.WriteLine("{0} * {1} = {2}", b, c, b * c);
            Console.WriteLine("{0} / {1} = {2}", c, b, c / b);

            //Como 1 y 2 son enteros, al dividirlos nos devuelve un entero y no un double
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);

            // Si escribimos 1.0 entonces el resultado de la división es de tipo double, pues 1.0 es double
            Console.WriteLine("{0} / {1} = {2}", "1.0", b, 1.0 / b);

            // Incremento en 1 el valor de a
            a++;
            Console.WriteLine("El incremento de {0} es {1} pues x++ = x + 1", a - 1, a);

            // Disminuyo en 1 el valor de a
            a--;
            Console.WriteLine("El decremento de {0} es {1} pues x-- = x - 1", a + 1, a);

            //Residuo
            Console.WriteLine(templateEncabezado, "Residuo");
            Console.WriteLine("{0} % {1} = {2}", b, a, b % a);
            Console.WriteLine("{0} % {1} = {2}", d, b, d % b);

            // Acceso de miembro
            Console.WriteLine(templateEncabezado, "Acceso a miembro");
            var stringEjemplo = string.Empty;
            Console.WriteLine("var stringEjemplo = string.Empty;");

            // invocación de método
            Console.WriteLine(templateEncabezado, "Invocación de un método");
            var esVacioElString = string.IsNullOrEmpty(stringEjemplo);
            Console.WriteLine(" var esVacioElString = string.IsNullOrEmpty(stringEjemplo);");

            Console.WriteLine(templateEncabezado, "default");
            Console.WriteLine("El valor por defecto de {0} es {1}", typeof(int), default(int));
            Console.WriteLine("El valor por defecto de {0} es {1}", typeof(bool), default(bool));
            Console.WriteLine("El valor por defecto de {0} es {1}", typeof(DateTime), default(DateTime));


            // Operaciones de relacion
            Console.WriteLine(templateEncabezado, "operaciones de relación");
            Console.WriteLine("{0} < {1} es {2}", a, b, a < b);
            Console.WriteLine("{0} < {1} es {2}", c, a, c < a);

            Console.WriteLine("{0} > {1} es {2}", a, b, a > b);
            Console.WriteLine("{0} > {1} es {2}", d, b, d > b);

            Console.WriteLine("{0} <= {1} es {2}", c, d, c <= d);
            Console.WriteLine("{0} <= {0} es {1}", b, b <= b);

            Console.WriteLine("{0} >= {1} es {2}", c, d, c >= d);
            Console.WriteLine("{0} >= {0} es {1}", a, a >= a);

            Console.WriteLine("{0} is int = {1}", a, a is int);
            Console.WriteLine("{0} is string = {1}", a, a is string);

            Console.WriteLine("{0} == {1} = {2}", a, b, a == b);
            Console.WriteLine("{0} == {0} = {1}", a, a == a);

            Console.WriteLine("{0} != {1} = {2}", c, d, c != d);
            Console.WriteLine("{0} != {0} = {1}", b, b != b);

            // operaciones logicas
            Console.WriteLine(templateEncabezado, "operaciones lógicas");
            var booleano = true;
            Console.WriteLine("Operación negación: !{0} = {1} ", booleano, !booleano);

            //Devuelve el valor true si ambos operandos tienen valor de verdad true
            Console.WriteLine("Operación Conjunción");
            Console.WriteLine("{0} & {0} = {1}", true, true & true);
            Console.WriteLine("{0} & {0} = {1}", false, false & false);
            Console.WriteLine("{0} & {1} = {2}", true, false, true & false);

            //Devuelve true cuando los operadores son distintos(uno true y el otro false)
            Console.WriteLine("Operación Exclusiva");
            Console.WriteLine("{0} ^ {0} = {1}", true, true ^ true);
            Console.WriteLine("{0} ^ {0} = {1}", false, false ^ false);
            Console.WriteLine("{0} ^ {1} = {2}", true, false, true ^ false);

            //Devuelve false cuando ambos operandos son false(su simbolo |  teclas alt+124)
            Console.WriteLine("Operación Inclusiva");
            Console.WriteLine("{0} | {0} = {1}", true, true | true);
            Console.WriteLine("{0} | {1} = {2}", true, false, true | false);
            Console.WriteLine("{0} | {1} = {2}", false, false, false | false);

            int? enteroNulo = null;
            int? enteroNoNulo = 7;
            Console.WriteLine("{0} ?? {1} = {2}", enteroNoNulo, a, enteroNoNulo ?? a);
            Console.WriteLine("null ?? {0} = {1}", a, enteroNulo ?? a);

            Console.WriteLine("{0} ? {1} : {2} = {3}", true, a, b, true ? a : b);
            Console.WriteLine("{0} ? {1} : {2} = {3}", false, a, b, false ? a : b);
        }
    }
}
