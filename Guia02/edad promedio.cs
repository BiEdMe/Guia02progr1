using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{

   
    public class Progro
    {
       public void Maini()
        {
            int edad, acumulador=0;
            int pro=0;

            Console.WriteLine("Programa decalculo de edad promedio");

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Digite la edad del Alumno   " + i);
                edad =int.Parse(Console.ReadLine());
                acumulador = acumulador + edad;
                pro = acumulador / 15;
            }
            Console.WriteLine("la edad promedio de los estudiantes es:  " + pro);
            Console.ReadKey();
        }
    }
}