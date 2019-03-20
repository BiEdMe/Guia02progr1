using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class7
    {
        public void Matriz()
        {
            double[,] numero;

            numero = new double[3, 4];

            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.WriteLine("Ingrese un numero");
                    numero[fila, col] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("La sumatoria de los valores es: "+numero);
            Console.WriteLine("El valor promedio de los valores es: " + numero);
        }
    }
}