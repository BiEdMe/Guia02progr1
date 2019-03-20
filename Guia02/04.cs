using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class4
    {
        public void Elv()
        {
            int N = 0;
            int J = 1;

            Console.WriteLine("Ingrese la cantidad de numeros de los cuales se desea sacar su potencia");
            N = int.Parse(Console.ReadLine());

            while (J <= N)
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero");
                int Z = int.Parse(Console.ReadLine());
                Console.WriteLine("====================================");
                Console.WriteLine(Math.Pow(Z, 3));
                Console.WriteLine(Math.Pow(Z, 4));
                Console.WriteLine(Math.Pow(Z, 5));
                J++;
                Console.ReadKey();
            }
            Console.ReadKey();
        }

        public void Rep()
        {
            int N = 0;
            int J = 1;
            int K = 0;
            int H = 0;

            Console.WriteLine("Ingrese la cantidad de numeros que desea ingresar");
            N = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Ingrese un numero, que desee saber cuantas veces se repite");
            int Z = int.Parse(Console.ReadLine());

            while (J <= N)
            {
                Console.Clear();
                Console.WriteLine("El numero ingresado al inicio es: " + Z);
                Console.WriteLine("====================================");
                Console.WriteLine("Ingrese un numero");
                K = int.Parse(Console.ReadLine());
                if (Z == K)
                {
                    H++;
                }
                J++;
                Console.WriteLine("El valor inicial " + Z + " se ha repetido " + H + " veces.");
                Console.ReadKey();
            }
            Console.ReadKey();
        }

        public void Deaf()
        {
            int N = 0;
            int J = 1;
            double Nota = 0.0;
            double PROM = 0.0;
            double Acu = 0;
            double Ma = 0;
            double Acs = 0;

            Console.WriteLine("Ingrese la cantidad de notas que desea calificar");
            N = int.Parse(Console.ReadLine());

            while (J <= N)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("Ingrese la nota...");
                Nota = double.Parse(Console.ReadLine());
                Acu = Acu + Nota;
                J++;

            }
            PROM = Acu / N;
            Console.WriteLine("La nota promedio es " + PROM);
            if (PROM >= 4.0)
            {
                Console.WriteLine("Ha pasado con una nota de: " + PROM);
            }
            else
            {
                Console.WriteLine("Ha reprobado con una nota de: " + PROM);
            }
            Console.ReadKey();
        }

        public void CoL()
        {
            int z, numero, J = 1;

            Console.WriteLine("Cuantos numeros desea factorizar?");
            z = int.Parse(Console.ReadLine());

            while (J <= z)
            {
                Console.WriteLine("Numero a factorizar");
                numero = int.Parse(Console.ReadLine());
                int tempo = 1;
                if (numero == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    while (numero > 0)
                    {
                        tempo = tempo * numero;
                        numero--;
                    }
                    Console.WriteLine(tempo);
                }
                J++;
            }
            Console.ReadKey();
        }


        public void Cluy()
        {
            Console.WriteLine("Cuantos productos desea pagar?");
            int n = int.Parse(Console.ReadLine());
            int J = 1;
            double Asc = 0;
            while (J <= n)
            {
                Console.Clear();
                Console.WriteLine("Ingrese el precio del producto");
                double Producto = double.Parse(Console.ReadLine());
                Asc = Asc + Producto;
                J++;
            }
            Console.WriteLine("Su total a pagar es de: $" + Asc);
            Console.ReadKey();
        }

        public void Main()
        {
            Console.WriteLine("Ingrese el numero de estudiantes en su aula");
            int n = int.Parse(Console.ReadLine());
            int J = 1;
            double Asc = 0, may = 0;
            while (J <= n)
            {
                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine("Ingrese la estatura del estudiante");
                    double Esta = double.Parse(Console.ReadLine());

                    if (i == 0)
                    {
                        may = Esta;
                    }
                    else if (i != 0)
                    {
                        if (Esta > may)
                        {
                            may = Esta;
                        }
                    }

                }
                J++;
            }
            Console.WriteLine("La estatura promedio es: " + may);
            Console.ReadKey();
        }

        public void Cuz()
        {
            Console.WriteLine("Ingrese el numero de estudiantes en su aula");
            int n = int.Parse(Console.ReadLine());
            int J = 1;
            double Asc = 0, may = 0;
            double Esta;
            Console.Clear();
            while (J <= n)
            {
                for (int i = 0; i < n; i++)
                {

                    Console.WriteLine("Ingrese la estatura del estudiante");
                    Esta = double.Parse(Console.ReadLine());

                    if (i == 0)
                    {
                        may = Esta;
                    }
                    else if (i != 0)
                    {
                        if (Esta > may)
                        {
                            may = Esta;
                        }
                    }
                    Console.WriteLine("La estatura promedio es: " +Esta);
                }
                J++;
                Console.ReadKey();
            } 
        }

        public void Criss()
        {
            Console.WriteLine("Ingrese un numero");
            double Val1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            double Val2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese una de las siguientes opciones:");
            Console.WriteLine("Presione 1 si desea ingresar otros dos numeros");
            Console.WriteLine("Presione 2 si desea sumar los dos numeros");
            Console.WriteLine("Presione 3 si desea restar los dos numeros");
            Console.WriteLine("Presione 4 si desea multiplicar dos numeros");
            Console.WriteLine("Presione 5 si desea dividir los dos numeros");
            Console.WriteLine("Presione 6 si desea salir del programa");
            int N = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Ingrese un numero");
                double Val3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                double Val4 = double.Parse(Console.ReadLine());

                Console.WriteLine("El valor 1 es: " + Val1);
                Console.WriteLine("El valor 2 es: " + Val2);
                Console.WriteLine("El valor 3 es: " + Val3);
                Console.WriteLine("El valor 4 es: " + Val4);

            } while (N == 1);
            do
            {
                double Val0 = Val1 + Val2;
                Console.WriteLine("La suma de los valores es: " + Val0);
            } while (N == 2);
            do
            {
                double Val0 = Val1 - Val2;
                Console.WriteLine("La resta de los valores es: " + Val0);
            } while (N == 3);
            do
            {
                double Val0 = Val1 * Val2;
                Console.WriteLine("La multiplicacion de los valores es: " + Val0);
            } while (N == 4);
            do
            {
                double Val0 = Val1 / Val2;
                Console.WriteLine("La division de los valores es: " + Val0);
            } while (N == 5);
            do
            {
                Console.WriteLine("Presione dos teclas para salir");
            } while (N == 6);
            Console.ReadKey();
        }

public void Man()
        {
            Console.WriteLine("Ingrese una de las siguientes opciones:");
            Console.WriteLine("Presione 1 para saber los numeros pares del 0 hasta 100");
            Console.WriteLine("Presione 2 si desea saber los multiplos de 4");
            Console.WriteLine("Presione 3 si desea saber la tabla del 10");
            Console.WriteLine("Presione 4 si desea salir del programa");
            int N = int.Parse(Console.ReadLine());
            do
            {
                for (int i = 2; i <= 100; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Presione enter para ver los numeros de uno en uno");
                        Console.WriteLine(i * 2);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    i++;
                }
            } while (N == 1);
            do
            {
                int i = 0;
                while (i == 4)
                {
                    Console.WriteLine("Presione enter para ver los numeros de uno en uno");
                    Console.WriteLine(i * 4);
                    Console.ReadKey();
                }
            } while (N == 2);

            do
            {
                for (int i = 0; i <= 10; i++)
                {
                    int Tablas = i * 10;
                    Console.WriteLine(i + " x 10 = " + Tablas);
                    i++;
                }
            } while (N == 3);
            do
            {
                Console.WriteLine("Presione 2 teclas para salir del programa");
                Console.ReadKey();
            } while (N == 4);
            Console.ReadKey();
        }


        public void Triii()
        {

            int[] edad = new int[10];

            for (int i = 0; i < edad.Length; i++)
            {
                Console.WriteLine("Ingrese la edad de la persona " + (i + 1));
                edad[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            for (int J = 1; J < edad.Length; J++)
            {
                Console.WriteLine(J + "- " + edad[J]);

            }
            Console.ReadKey();
        }

        public void Miin()
        {

            String[] nombre = new String[15];

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona " + (i + 1));
                nombre[i] = Console.ReadLine();
                Console.Clear();
            }

            for (int J = 0; J < nombre.Length; J++)
            {
                Console.WriteLine(nombre[J]);
                Console.ReadKey();
            }
        }
    }
}