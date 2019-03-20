using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class9
    {
        public void Matriz2()
        {
            double[,] numero;
            numero = new double[5, 5];

            
            ///////////////////////////
            numero[1, 1] = 5;
            numero[1, 2] = 5;
            numero[1, 3] = 5;
            numero[1, 4] = 5;
            numero[1, 5] = 5;
            ///////////////////////////
            numero[2, 1] = 5;
            numero[2, 2] = 5;
            numero[2, 3] = 5;
            numero[2, 4] = 5;
            numero[2, 5] = 5;
            ///////////////////////////
            numero[3, 1] = 5;
            numero[3, 2] = 5;
            numero[3, 3] = 5;
            numero[3, 4] = 5;
            numero[3, 5] = 5;
            ///////////////////////////
            numero[4, 1] = 5;
            numero[4, 2] = 5;
            numero[4, 3] = 5;
            numero[4, 4] = 5;
            numero[4, 5] = 5;
            ///////////////////////////
            numero[5, 1] = 5;
            numero[5, 2] = 5;
            numero[5, 3] = 5;
            numero[5, 4] = 5;
            numero[5, 5] = 5;


            Console.WriteLine("la multiplicacion de la primera diagonal es: "+(numero[1,1] * numero[2,2] * numero[3,3] *numero[4,4] * numero[5,5]));

            Console.WriteLine("la multiplicacion de la segunda diagonal es: " + (numero[1, 5] * numero[2, 4] * numero[3, 3] * numero[4, 2] * numero[5, 1]));
            Console.ReadKey();
        }
    }
}