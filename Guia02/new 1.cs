using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;


namespace impar

class ejercicio
{
    static void Main(string[] args)
    {
        int i, impar = 0, par = 0;
		
		Console.WriteLine("Ingrese un numero :");
		
        for(i = 0; i < 100; i++)
		
            if(i % 3 == 0)
			
                Console.Write("{0}|",i);

        Console.Write("\n\n");
		
                impar++;
				
            }
        }