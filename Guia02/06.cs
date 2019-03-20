using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class6
    {
        public void Lol()
        {
            int[,] numero = new int[3, 3];

            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.WriteLine("Ingrese un numero");
                    numero =[fila, col] = int.Parse(Console.ReadLine());
                }
                Console.ReadKey();
            }
        }
    }
}