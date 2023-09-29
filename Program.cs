using ExamenUnidad1_CARS.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad1_CARS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Introdusca una CURP:");

            string curp= Console.ReadLine();*/
            Examen examen = new Examen();

            Console.WriteLine("Inserte el primer numero");
            examen.num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserte el segundo numero");
            examen.num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(examen.IntervaloNumeros(examen.num1,examen.num2));
            Console.ReadKey();

            Console.WriteLine("Elija un taba para ultiplicar del 1-10");
            examen.numero1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(examen.TablasMultiplicacion(examen.numero1));
            Console.ReadKey();

        }
    }
}
