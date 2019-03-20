using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2Evaluacion
{
    class EJER57
    {

        public double  resul = 1;
        public int num, num1, k;
        public string opcion; 


        public void res()
        {

            Console.WriteLine("Que operacion desea realizar :");
            Console.WriteLine("Factorial :");
            Console.WriteLine("Potencia :");

            Console.WriteLine("SALIR :");

            opcion = Console.ReadLine();


            Console.WriteLine("Ingrese un numero :");
            num = int.Parse(Console.ReadLine());



            switch (opcion)
            {



                case "Factorial":

                    for ( k = 2; k <= num; k++)
                    {

                        resul = resul * k;

                    }

                    Console.WriteLine("Factorial es : " + resul);

                    break;


                case "Potencia":


                    Console.WriteLine("Digite un numero ;");
                    num1 = int.Parse(Console.ReadLine());


                    Console.WriteLine("POTENCIA ES : " + Math.Pow(num1, 3));


                    break;


                default:

                    Console.WriteLine();
                    Console.WriteLine("Salir");

                    break; 





            }


        }

    }
}