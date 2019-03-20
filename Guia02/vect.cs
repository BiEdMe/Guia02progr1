using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRA1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Opcion = 0;
            EJERCICIOS obj = new EJERCICIOS();
            vectores obj1 = new vectores();
         

      
            Console.WriteLine("Ingrese un numero del 11 hasta el 21 y del 60 al 68  para realizar un ejercicio" +
                "(CADA NUMERO ES UN EJERCICIO)");
            Opcion = double.Parse(Console.ReadLine());
            switch (Opcion)
            {


                case 11:
                    obj.ejercicio11();
                    break;

                case 12:
                    obj.ejercicio12();
                    break;

                case 13:
                    obj.ejercicio13();
                    break;

                case 14:
                    obj.ejercicio14();
                    break;

                case 15:
                    obj.ejercicio15();
                    break;

                case 16:
                    obj.ejercicio16();
                    break;

                case 17:
                    obj.ejercicio17();
                    break;

                case 18:
                    obj.ejercicio18();
                    break;

                case 19:
                    obj.ejercicio19();
                    break;

                case 20:
                    obj.ejercicio20();
                    break;

                case 21:
                    obj.ejercicio21();
                    break;
                case 60:
                    obj1.ejercicio60();
                    break;
                case 64:
                    obj1.ejercicio64();
                    break;                                                       
                case 66:
                    obj1.ejercicio66();
                    break;

                case 67:
                    obj1.ejercicio67();
                    break;
                case 68:
                    obj1.ejercicio68();
                    break;
                default:
                    Console.WriteLine("fallo en la eleccion");
                    break;



            }
        }
    }
}
