using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamenUnidad1_CARS.Clases
{
    internal class Examen
    {
        /*
        public string SexoFechaCURP(string curp)
        {

            if (curp !=)
            {

            }
            return "";
        }*/
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int numero1 { get; set; }
        public string IntervaloNumeros(int num1, int num2)
        {
            if(num1 == num2)
            {
                return "los numeros son iguales";
            }
            else
            {
                if(num1<num2){
                    for (int i = num1; i <= num2; i++)
                    {
                        Console.WriteLine($"Numero: {i}");
                    }
                    return "fin";
                }
                else
                {
                    for (int i = num1; i >= num2; --i)
                    {
                        Console.WriteLine($"Numero: {i}");
                    }
                    return "fin";
                }

                /*
                for(int i = num1; i <= num2;i++)
                {
                    Console.WriteLine($"Numero: {i}");
                }
                return "fin";
                */
                
                

            }
        }
        int count;
        public string TablasMultiplicacion(int numero1)
        {
            
            int respuesta;
            if(numero1 == 1)
            {
                if (count == 10)
                {
                    return "listo";
                }
                respuesta = numero1 * count;

            }
            else if(numero1 == 2)
            {
                if (count == 10)
                {
                    return "listo";
                }
                respuesta = numero1 * count;
                

            }
            else if(numero1 == 3)
            {
                if (count == 10)
                {
                    return "listo";
                }
                respuesta = numero1 * count;

            }
            else if(numero1 == 4)
            {
                if (count == 10)
                {
                    return "listo";
                }
                respuesta = numero1 * count;

            }
            else if(numero1 == 5)
            {
                if (count == 10)
                {
                    return "listo";
                }
                respuesta = numero1 * count;

            }
            else if(numero1 == 6)
            {
                if (count == 10)
                {
                    return "listo";
                }
                respuesta = numero1 * count;

            }
            else if(numero1 == 7)
            {
                if (count == 10)
                {
                    return "listo";
                }
                respuesta = numero1 * count;

            }
            else if(numero1 == 8)
            {
                if (count == 10)
                {
                    return "listo";
                }
                respuesta = numero1 * count;

            }
            else if(numero1 == 9)
            {
                if (count == 10)
                {
                    return "listo";
                }
                respuesta = numero1 * count;

            }
            else if(numero1 == 10)
            {
                if (count == 10)
                {
                    return "listo";
                }
                respuesta = numero1 * count;

            }

            return count++ + TablasMultiplicacion(numero1);

        }


    }
}
