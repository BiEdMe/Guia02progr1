using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    public class Dev
    {
        public void Mapin()
        {

            //45.	Realizar un Programa que permita visualizar en pantalla los múltiplos de 5 hasta el número 100.
            int desde =5,hasta=100;
            
            Console.WriteLine("los multiplos de 5 son");
        

            for (int i=desde; i<=(desde*hasta);i+=desde) {

                Console.WriteLine(i);



            }
            Console.ReadKey();

        }
    }
}