using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class8
    {
        public void Matriz2()
        {
            double[,] numero;

            Console.WriteLine();
            int I = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int J = int.Parse(Console.ReadLine());

            numero = new double[J,I];


            for (int fila = 0; fila < J; fila++)
            {
                for (int col = 0; col < I; col++)
                {
                    Console.WriteLine("Ingrese un numero");
                    numero[fila, col] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Ingrese el numero de fila y columa que desea ver");
            int Pl = int.Parse(Console.ReadLine());

            Console.WriteLine(numero);
            Console.ReadKey();
        }
    }
}