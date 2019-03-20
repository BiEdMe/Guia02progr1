using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    public class Programk
    {
        public void Main()
        {
            //1.	Programa que permita calcular la estatura promedio de un grupo de 18 estudiantes y luego tomar las siguientes decisiones:
            //a)	Si la estatura promedio es menor a 140 cm imprimir un mensaje que diga “Estudiantes muy bajos”.
            //b)	Si la estatura promedio se encuentra entre 140 y 170 cm imprimir “Estudiantes de estatura normal”.
            //Si la estatura promedio es mayor de 170 cm imprimir “Estudiantes muy altos//

            double estatura, acumulador=0;
            double promedio = 0;

            for (int x=1; x <= 18; x++) {
                Console.WriteLine("Digite la Estatura de Alumno  "+ x);
                estatura = double.Parse(Console.ReadLine());
                acumulador = acumulador + estatura;
                promedio = acumulador / 18;
            }

            Console.WriteLine("La Estatura Promedio es  :" +promedio);

            if (promedio <= 1.40) {

                Console.WriteLine("Estudiantes muy bajos");

            }else if (promedio >= 1.40 & promedio <=1.70){

                Console.WriteLine("Estudiantes de estatura normal");

            }else if (promedio >=1.70) {

                Console.WriteLine("Estudiantes Muy Altos");
            }


            Console.ReadKey();





        }
    }
}