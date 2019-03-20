using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2Evaluacion
{
    class EJER59
    {

        public int edad, E = 0;

        public void res()
        {


            int[] EDAD = null;
            EDAD = new int[]
            {
                13,
                19,
                25,
                53,
                42,
                17,
                33,
                20,
                36,
                55

            };

            for (E = 0; E <= EDAD.Length - 1; E++)
            {

                Console.WriteLine(EDAD[E]);


            }
            Console.WriteLine();



         }


    }

}