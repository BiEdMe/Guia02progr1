using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class12
    {
        public void Plan()
        {
            Console.WriteLine("¿Cuantas filas tendrá la matriz?");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuantas columnas tendrá la matriz?");
            int J = int.Parse(Console.ReadLine());

            double[,] numero;
            numero = new double[i, J];
            int T = 0;
            int L = 0;
            int M = 0;
            for (int K = 1; K <= i; i++)
            {
                for (int Z = 1; Z <= J; J++)
                {
                    Console.WriteLine("Ingrese el primer valor");
                    numero[i, J] = double.Parse(Console.ReadLine());

                    if (numero[i, J] == 0)
                    {
                        T = T + 1;
                    }

                    if (numero[i, J] < 0)
                    {
                        L = L + 1;
                    }

                    if (numero[i, J] > 1)
                    {
                        M = M + 1;
                    }
                    Console.WriteLine("Hay numero = 0 " + T);
                    Console.WriteLine("Hay numero < 0 " + L);
                    Console.WriteLine("Hay numero > 0 " + M);
                }
            }

            Console.ReadKey();
        }
    }
}