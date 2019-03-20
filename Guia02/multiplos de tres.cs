using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    public class Gro
    {
        public void Main()
        {

            //43.	Programa que muestre en pantalla los múltiplos de 3 teniendo como límite el número 99.
            int desde=3,hasta=99;
            
            Console.WriteLine("los multiplos de 3 son");
        

            for (int i=desde; i<=(desde*hasta);i+=desde) {

                Console.WriteLine(i);
                
                }
           
            Console.ReadKey();

        }
    }
}