using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    public class Progra
    {
        public void Main()
        {
            int count = 0, numero, result;

            Console.WriteLine("Digite el numero de la tabla que desea");

            numero = int.Parse(Console.ReadLine());

            for (count =1;count<=10;count++) {

                result = count * numero;
                Console.WriteLine(count+" X "+numero+" = "+result);


            }


            Console.ReadKey();
        }
    }
}