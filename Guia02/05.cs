using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class5
    {
        public void Nombres()
        {
            String[] Nombre = new String[25];
            String[] Apellido = new String[25];
            for (int i = 1; i <= 25; i++)
            {
                Console.Clear();
                Console.WriteLine("Ingrese el "+i+" nombre");
                Nombre[i] = Console.ReadLine();

                Console.WriteLine("Ingrese el " + i + " apellido");
                Apellido[i] = Console.ReadLine();
            }
        }
    }
}