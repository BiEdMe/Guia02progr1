using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class11
    {
        public void Matriz2()
        {
            

            Console.WriteLine("¿Cuantas filas tendrá la matriz?");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuantas columnas tendrá la matriz?");
            int J = int.Parse(Console.ReadLine());

            double[,] numero;
            numero = new double[i, J];

            for (int K = 1; K <= i; i++ ) {
                for(int Z = 1; Z <= J; J++)
                {
                    Console.WriteLine("Ingrese el primer valor");
                }
            }

            Console.WriteLine("la suma de la primera diagonal es: " + (numero[1, 1] + numero[2, 2] + numero[3, 3] + numero[4, 4] + numero[5, 5]));

            Console.WriteLine("la suma de la segunda diagonal es: " + (numero[1, 5] + numero[2, 4] + numero[3, 3] + numero[4, 2] + numero[5, 1]));
            Console.ReadKey();
        }
    }
}