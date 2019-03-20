using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    public class Progri
    {
        public void Maiin()
        {
            //47.	Programa que encuentre el resultado de la operación potencia donde el usuario ingresa el valor de la base y el exponente.
            double bas, expo, result;

            Console.WriteLine("Favor escriba la base que desea elevar");
            bas = double.Parse(Console.ReadLine());

            Console.WriteLine("Favor digite el exponente");
            expo = double.Parse(Console.ReadLine());

            result = Math.Pow(bas,expo);
            Console.WriteLine("el resultado es:  "+ result);
            Console.ReadKey();
        }
    }
}