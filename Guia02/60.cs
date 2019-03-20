class Vectores
    {
        public void ejercicio60()
        {

            string n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15;

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
    }