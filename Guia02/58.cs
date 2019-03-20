using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2Evaluacion
{
    class EJER58
    {
        public int resul;
        public int sumP = 0, i = 0;
        public int num, num1, num2; 
        public string opcion;   

        public void res()
        {

            Console.WriteLine("Que operacion desea realizar :");
            Console.WriteLine("Numeros pares :");
            Console.WriteLine("Multiplos :");
            Console.WriteLine("Tablas de multiplicar :");
            Console.WriteLine("SALIR :");

            opcion = Console.ReadLine();


            switch (opcion)
            {


                case "Numeros pares":

                    Console.WriteLine("Ingrese un numero :");
                    num = int.Parse(Console.ReadLine());

                    if (num <= 100)
                    {

                    }

                    for (i = 1; i <= num; i= +2)
                    {

                        sumP = sumP + i;


                    }
                    Console.WriteLine("El total de pares es :" + sumP);

                    break;

                case "Multiplos":

                    Console.WriteLine("Ingrese un numero :");
                    num1 = int.Parse(Console.ReadLine());


                    Console.WriteLine("Ingrese multiplo de 4 :");
                    num2 = int.Parse(Console.ReadLine());


                    while (i <=10)
                    {


                        for (i = num1; i <=(num1*num2); i += num1)
                        {

                            Console.Write(i + ", ");


                        }




                    }

                    break;

                case "Multiplicacion":


                    Console.WriteLine("Ingrese un numero :");
                    num = int.Parse(Console.ReadLine());

                    i = 1;

                    while(i <= 12)
                    {

                        resul = num * i;

                        Console.WriteLine(" {0} * {1} = {2}", num, i, resul);
                        i = i + 1;

                    }

                    break;




                default:

                    Console.WriteLine();
                    Console.WriteLine("Salir");

                    break;


            }


        }    

    }
}