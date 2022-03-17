using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Encuentra el área de una pizarra con dimensiones 140 cm de base y 90 cm de altura.


namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            double Base, Altura, Pizarra;

            Console.Title = " Area de una pizarra";
            Console.WriteLine("Base");
            Base = double.Parse(Console.ReadLine());


            Console.WriteLine("Altura");
            Altura = double.Parse(Console.ReadLine());


            // Procesamiento de datos


            Pizarra = ((Base * Altura));


            // Salida de la informacion

            Console.WriteLine("Area de una pizarra es {0}", Pizarra);
            Console.ReadKey();







        }
    }
}
