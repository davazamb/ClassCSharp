using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCSharp
{
    class Ejemplo4DateTime
    {
        static void Main6(string[] args)
        {
            ////Instancia
            //DateTime fecha = new DateTime(2016, 10, 28);
            //DateTime fechaConHora = new DateTime(2007, 05, 17, 9, 20, 23);
            ////Mostrar 
            //Console.WriteLine(fecha.ToString());
            //Console.WriteLine(fecha.ToString("MM/dd/yyyy"));
            //Console.WriteLine(fechaConHora.ToString("dd-MM-yyyy hh:mm:ss"));

            //Console.WriteLine(fecha.AddDays(45).ToString());
            //Console.WriteLine(fechaConHora.DayOfWeek);
            //Console.WriteLine(fechaConHora.Date);
            ////Restar dias entre las 2 fechas
            //Console.WriteLine(fecha.Subtract(fechaConHora).Days);

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //        continue;
            //    }
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //        continue;
            //    }
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            for (int x = 1; x <= 100; x++)
            {
                string output = "";
                if (x % 3 == 0) output += "Fizz";
                if (x % 5 == 0) output += "Buzz";
                if (output == "") output = x.ToString();
                Console.WriteLine(output);
            }

                Console.Read();
        }

    }
}
