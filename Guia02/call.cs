[11:09, 19/3/2019] Wolf~🇸🇻: using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;


namespace PromedioEdad
{
class program
{
static void Main(string[] args)
{
int edad, actualizador = 0;

for(int x = 1; x <= 40; x++)
{
Console.WritLine( "ingrese la edad");

edad=int.parse(Console.ReadLine());

actualizador = actualizador + edad;


}
Console.WritLine("El promedio de edad del grupo es: "+ actualizador);

Console.ReadKey();
}
}
}
[11:09, 19/3/2019] Wolf~🇸🇻: using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;


namespace Tablas
{
class TablasM
{
static void Main(string[] args)
{
int num, resultado;

Console.WriteLine("Ingrese un numero :");

 for (int i = 1; i <= 10; i++ )
  {
    resultado = num * i;
	
   Console.WriteLine(num+ " * " +i+ " = " +resultado)
  }
Console.WritLine();


Console.ReadKey();
}
}
}