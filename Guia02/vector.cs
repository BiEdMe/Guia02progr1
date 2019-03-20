using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRA1
{
    class vectores
    {
        public void ejercicio60()
        {
            Console.Clear();
            string n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15;
            Console.WriteLine("Programa que solicita 15 nombres \n almacenarlos en un vector,luego se muestra en el orden igresado ");
            string[] vector;
            vector = new string[15];
            Console.WriteLine("Ingrese 15 nombre para el vector: ");
            Console.Write("N1  "); n1 = Console.ReadLine();
            Console.Write("N2  "); n2 = Console.ReadLine();
            Console.Write("N3  "); n3 = Console.ReadLine();
            Console.Write("N4  "); n4 = Console.ReadLine();
            Console.Write("N5  "); n5 = Console.ReadLine();
            Console.Write("N6  "); n6 = Console.ReadLine();
            Console.Write("N7  "); n7 = Console.ReadLine();
            Console.Write("N8  "); n8 = Console.ReadLine();
            Console.Write("N9  "); n9 = Console.ReadLine();
            Console.Write("N10 "); n10 = Console.ReadLine();
            Console.Write("N11 "); n11 = Console.ReadLine();
            Console.Write("N12 "); n12 = Console.ReadLine();
            Console.Write("N13 "); n13 = Console.ReadLine();
            Console.Write("N14 "); n14 = Console.ReadLine();
            Console.Write("N15 "); n15 = Console.ReadLine();


            Console.WriteLine("---------------------------------------");
            vector[0] = n1;
            vector[1] = n2;
            vector[2] = n3;
            vector[3] = n4;
            vector[4] = n5;
            vector[5] = n6;
            vector[6] = n7;
            vector[7] = n8;
            vector[8] = n9;
            vector[9] = n10;
            vector[10] = n11;
            vector[11] = n12;
            vector[12] = n13;
            vector[13] = n14;
            vector[14] = n15;

            foreach (string elemento in vector)
            {
                Console.WriteLine("Nombre :  " + elemento);
            }

            Console.ReadKey();

        }

        public void ejercicio64()
        {
            Console.Clear();
            Console.WriteLine("Programa que me permite llenar un vector y despues se muestra al reves");
            int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, n16, n17;

            int[] vector;
            vector = new int[17];
            Console.WriteLine("Ingrese 17 numero para el vector: ");
            Console.Write("N1  "); n1 = int.Parse(Console.ReadLine());
            Console.Write("N2  "); n2 = int.Parse(Console.ReadLine());
            Console.Write("N3  "); n3 = int.Parse(Console.ReadLine());
            Console.Write("N4  "); n4 = int.Parse(Console.ReadLine());
            Console.Write("N5  "); n5 = int.Parse(Console.ReadLine());
            Console.Write("N6  "); n6 = int.Parse(Console.ReadLine());
            Console.Write("N7  "); n7 = int.Parse(Console.ReadLine());
            Console.Write("N8  "); n8 = int.Parse(Console.ReadLine());
            Console.Write("N9  "); n9 = int.Parse(Console.ReadLine());
            Console.Write("N10 "); n10 = int.Parse(Console.ReadLine());
            Console.Write("N11 "); n11 = int.Parse(Console.ReadLine());
            Console.Write("N12 "); n12 = int.Parse(Console.ReadLine());
            Console.Write("N13 "); n13 = int.Parse(Console.ReadLine());
            Console.Write("N14 "); n14 = int.Parse(Console.ReadLine());
            Console.Write("N15 "); n15 = int.Parse(Console.ReadLine());
            Console.Write("N16 "); n16 = int.Parse(Console.ReadLine());
            Console.Write("N17 "); n17 = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------------------");
            vector[0] = n1;
            vector[1] = n2;
            vector[2] = n3;
            vector[3] = n4;
            vector[4] = n5;
            vector[5] = n6;
            vector[6] = n7;
            vector[7] = n8;
            vector[8] = n9;
            vector[9] = n10;
            vector[10] = n11;
            vector[11] = n12;
            vector[12] = n13;
            vector[13] = n14;
            vector[14] = n15;
            vector[15] = n16;
            vector[16] = n17;

            foreach (int elemento in vector)
            {
                Console.WriteLine("vector :  " + elemento);
            }


            vector[16] = n1;
            vector[15] = n2;
            vector[14] = n3;
            vector[13] = n4;
            vector[12] = n5;
            vector[11] = n6;
            vector[10] = n7;
            vector[9] = n8;
            vector[8] = n9;
            vector[7] = n10;
            vector[6] = n11;
            vector[5] = n12;
            vector[4] = n13;
            vector[3] = n14;
            vector[2] = n15;
            vector[1] = n16;
            vector[0] = n17;

            Console.WriteLine("--------------------------------------------");
            foreach (int elemento in vector)
            {

                Console.WriteLine("vector : " + elemento);
            }

            Console.ReadKey();

        }



        public void ejercicio66()
        {

            Console.Clear();
            int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12;
            int j1, j2, j3, j4, j5, j6, j7, j8, j9, j10, j11, j12;
            Console.WriteLine("Programa que permite llenar dos vectores de 12 posiciones ");
            Console.WriteLine("y luego en un tercer y cuarto vector guardar la suma y restar cada posicion");
            Console.WriteLine("Ingrese 12 numero para el primer vector: ");
            Console.Write("N1  "); n1 = int.Parse(Console.ReadLine());
            Console.Write("N2  "); n2 = int.Parse(Console.ReadLine());
            Console.Write("N3  "); n3 = int.Parse(Console.ReadLine());
            Console.Write("N4  "); n4 = int.Parse(Console.ReadLine());
            Console.Write("N5  "); n5 = int.Parse(Console.ReadLine());
            Console.Write("N6  "); n6 = int.Parse(Console.ReadLine());
            Console.Write("N7  "); n7 = int.Parse(Console.ReadLine());
            Console.Write("N8  "); n8 = int.Parse(Console.ReadLine());
            Console.Write("N9  "); n9 = int.Parse(Console.ReadLine());
            Console.Write("N10 "); n10 = int.Parse(Console.ReadLine());
            Console.Write("N11 "); n11 = int.Parse(Console.ReadLine());
            Console.Write("N12 "); n12 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Ingrese 12 numero para el segundo vector: ");
            Console.Write("N1  "); j1 = int.Parse(Console.ReadLine());
            Console.Write("N2  "); j2 = int.Parse(Console.ReadLine());
            Console.Write("N3  "); j3 = int.Parse(Console.ReadLine());
            Console.Write("N4  "); j4 = int.Parse(Console.ReadLine());
            Console.Write("N5  "); j5 = int.Parse(Console.ReadLine());
            Console.Write("N6  "); j6 = int.Parse(Console.ReadLine());
            Console.Write("N7  "); j7 = int.Parse(Console.ReadLine());
            Console.Write("N8  "); j8 = int.Parse(Console.ReadLine());
            Console.Write("N9  "); j9 = int.Parse(Console.ReadLine());
            Console.Write("N10 "); j10 = int.Parse(Console.ReadLine());
            Console.Write("N11 "); j11 = int.Parse(Console.ReadLine());
            Console.Write("N12 "); j12 = int.Parse(Console.ReadLine());

            int[] Vector1 = new int[12] { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12 };
            int[] Vector2 = new int[12] { j1, j2, j3, j4, j5, j6, j7, j8, j9, j10, j11, j12 };
            int[] Vector3 = new int[12];
            int[] Vector4 = new int[12];


            Console.WriteLine("");
            Console.WriteLine("La suma del vector 1 y 2 es: ");
            Console.WriteLine("------------------------------------ ");
            for (int i = 0; i < 12; i++)
            {
                Vector3[i] = Vector1[i] + Vector2[i];

                Console.WriteLine("La suma es: " + Vector3[i]);

            }

            Console.WriteLine("");
            Console.WriteLine("La resta del vector 1 y 2 es: ");
            Console.WriteLine("------------------------------------ ");
            for (int i = 0; i < 12; i++)
            {
                Vector4[i] = Vector1[i] - Vector2[i];

                Console.WriteLine("La resta es: " + Vector4[i]);

            }
            Console.ReadKey();
        }

        public void ejercicio67()
        {
            Console.Clear();
            Console.WriteLine("Programa que permite llenar un vector de N posiciones y luego un segundo y tercer vector ");
            Console.WriteLine("guarde el cuadrado y el cubo de cada una de las posiciones");
            int[] vector1 = new int[15];
            double[] vector2 = new double[15];
            double[] vector3 = new double[15];
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Dijite un valor para el vector en la posicion: " + (i + 1));
                vector1[i] = int.Parse(Console.ReadLine());
                vector2[i] = Math.Pow(vector1[i], 2);

            }

            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Vector 1 (original)");
                }

                Console.WriteLine(vector1[i]);
            }

            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Vector 2 elevado a la 2( arreglo resultante)");
                }
                Console.WriteLine(vector2[i]);
            }
            Console.WriteLine("-----------------------------------------------------");
            for (int i = 0; i < 15; i++)
            {

                vector3[i] = Math.Pow(vector1[i], 3);

            }
            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Vector 1 (original)");
                }

                Console.WriteLine(vector1[i]);
            }

            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Vector 3 elevado a la 3( arreglo resultante)");
                }
                Console.WriteLine(vector3[i]);
            }

            Console.ReadKey();

        }

        public void ejercicio68()
        {
            Console.Clear();
            int[] Num;
            int cant, menor, mayor;
            int suma = 0;
            Console.WriteLine("Programa que permita regresar el numeros de estudiantes asignados cada uno");
            Console.WriteLine("de los 20 salones de un colegio");

            Console.WriteLine("Dijte la cantidad de Salones: ");
            cant = int.Parse(Console.ReadLine());
            Num = new int[cant];

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Cuantos alumnos tiene el salon numero " + (i + 1) + "  : ");
                Num[i] = int.Parse(Console.ReadLine());
                suma = Num[i] * cant;
            }

            mayor = Num[0];
            menor = Num[0];
            for (int i = 0; i < cant; i++)
            {
                if (Num[i] > mayor)
                {
                    mayor = Num[i];
                }
                else if (Num[i] < menor)
                {
                    menor = Num[i];
                }
            }

            Console.WriteLine("El total de estdudiantes es es: " + suma);
            Console.WriteLine("El numero menor de estudiantes es: " + menor);
            Console.WriteLine("El numero mayor de estudiantes es: " + mayor);
            Console.ReadKey();

        }
    }
}