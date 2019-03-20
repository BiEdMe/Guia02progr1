using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potencia


{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado, numero = 4;
			
			
            int value = 4;
			
			
            Console.WriteLine("Ingrese un numero :");	
			
            resultado = Math.Pow(numero, value);
			
            Console.WriteLine( "La potencia de " + numero +" elevada a "+ value+" potencia es " + resultado);
			
			
            Console.ReadLine();
        }
    }
}