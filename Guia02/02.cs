using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Código creado por P41N Andrés
 */
namespace ClassLibrary1
{
    public class Class2
    {
        double SalDia, SalTota, Sal1, SalDis, Val1, Val2, Val3, Val4, Val5, Resu1, Resu2, Resu3, Resu4, Resu5;
        int DiasTrab;
        public void Suel()
        {
            Console.Clear();
            Console.WriteLine("****Programa que permita determinar el salario a pagar a un empleado.****");
            Console.WriteLine("Ingrese lo que se devenga por dia");
            SalDia = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los dias que que ha trabajado");
            DiasTrab = int.Parse(Console.ReadLine());
            Sal1 = SalDia * DiasTrab;

            SalTota = Sal1 * 0.25;

            Console.WriteLine("Su sueldo total es de: " + SalTota);

        }

        public void Cuad()
        {
            Console.Clear();
            Console.WriteLine("****Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo****");
            Console.WriteLine("Ingrese el valor de un lado del cuadrado");
            Val1 = double.Parse(Console.ReadLine());
            Resu1 = Math.Pow(Val1, 2);
            Console.WriteLine("===============================================");
            Console.WriteLine("El area del cuadrado es: " + Resu1);
            Resu2 = Val1 * 4;
            Console.WriteLine("El perimetro del cuadrado es: " + Resu2);

        }

        public void O_5()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un programa en el cual se ingresen cinco números, calcular e informar \n la suma de los dos primeros y el producto del tercero con el cuarto los resultados multiplicarlos y dividirlos \n por el quinto número.****");
            Console.WriteLine("Ingrese el primer numero");
            Val1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            Val2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercero numero");
            Val3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero");
            Val4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el quinto numero");
            Val5 = double.Parse(Console.ReadLine());

            Resu1 = Val1 + Val2;
            Resu2 = Val3 % 10;
            Resu3 = Val4 * Val1 * Val2 * Val3 * Val5;
            Resu4 = (Val4 + Val1 + Val2 + Val3) / Val5;

            Console.WriteLine("La suma de los dos primeros es: "+Resu1);
            Console.WriteLine("El producto del tercero es: "+Resu2);
            Console.WriteLine("La multiplicacion de todos los numeros es: "+Resu3);
            Console.WriteLine("La suma de todos los numeros y divididos por el quinto es:"+Resu4);
            Console.ReadKey();

        }

        public void Prom()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un programa en el cual se ingresen cinco números, calcular e informar \n la suma de los dos primeros y el producto del tercero con el cuarto los resultados multiplicarlos y dividirlos \n por el quinto número.****");
            Console.WriteLine("Ingrese el primer numero");
            Val1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            Val2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercero numero");
            Val3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero");
            Val4 = double.Parse(Console.ReadLine());

            Resu1 = Val4 + Val1 + Val2 + Val3;
            Resu2 = (Val4 + Val1 + Val2 + Val3)/4;

            Console.WriteLine("La suma de los numeros es: " + Resu1);
            Console.WriteLine("El promedio de los numeros es: "+Resu2);
            Console.ReadKey();

        }

        public void Ing()
        {
            Console.Clear();
            Console.WriteLine("****Programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente.****");
            Console.WriteLine("Ingrese la cantidad de productos que lleva");
            Val1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto");
            Val2 = double.Parse(Console.ReadLine());

            Resu1 = Val1 * Val2;

            Console.WriteLine("Debe abonar: $" + Resu1);
            Console.ReadKey();

        }

        public void Pig()
        {
            Console.Clear();
            Console.WriteLine("****Programa que determine si una persona es mayor de edad o no.****");
            Console.WriteLine("Ingrese el año en el que nacio");
            Val1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año actual");
            Val2 = double.Parse(Console.ReadLine());

            Resu1 = Val2 - Val1;

            Console.WriteLine("Usted tiene: " + Resu1+" años de edad");
            if (Resu1 >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            Console.ReadKey();

        }

        public void Dig()
        {
            Console.Clear();
            Console.WriteLine("****Programa para determinar si un número cualquiera ingresado por el usuario es o no positivo****");
            Console.WriteLine("Ingrese un numero");
            Val1 = double.Parse(Console.ReadLine());

            Console.WriteLine("El numero ingresado es: **" +Val1+"**");
            if (Val1 <= -1)
            {
                Console.WriteLine("El numero es negativo");
            }
            else
            {
                Console.WriteLine("El numero es positivo");
            }
            Console.ReadKey();

        }

        public void Lig()
        {
            Console.Clear();
            Console.WriteLine("****Programa para determinar cuál es mayor entre 2 números cualquiera ingresados por el usuario****");
            Console.WriteLine("Ingrese un numero");
            Val1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            Val2 = double.Parse(Console.ReadLine());

            Console.WriteLine("El primer numero ingresado es: **" + Val1 + "**");
            Console.WriteLine("El segundo numero ingresado es: **" + Val2 + "**");
            if (Val1 < Val2)
            {
                Console.WriteLine(Val1+" es mayor que "+Val2);
            }
            else
            {
                Console.WriteLine(Val1 + " es menor que " + Val2);
            }
            Console.ReadKey();

        }

        public void Hig()
        {
            Console.Clear();
            Console.WriteLine("****Programa para saber si un estudiante del Enrique Olaya Herrera requiere refrigerio. ****");
            Console.WriteLine("Ingrese su grado");
            Val1 = double.Parse(Console.ReadLine());

            Console.WriteLine("El grado ingresado es: **" + Val1 + "**");
            if (Val1 <= 6)
            {
                Console.WriteLine("Tiene derecho a refrigerio");
            }
            else
            {
                Console.WriteLine("No tiene derecho a refrigerio");
            }
            Console.ReadKey();

        }

        public void Kig()
        {
            Console.Clear();
            Console.WriteLine("****Programa para determinar la mitad de un número ingresado por el usuario es mayor o menor de 100.****");
            Console.WriteLine("Ingrese un numero");
            Val1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Numero ingresado es: **" + Val1 + "**");
            if (Val1 < 100 && Val1 > 0)
            {
                Console.WriteLine("El numero es mayor que 0 menor que 100");
            }
            if(Val1 > 100)
            {
                Console.WriteLine("El numero es mayor que 100");
            }
            if (Val1 < 0)
            {
                Console.WriteLine("El numero es menor que 0");
            }
            Console.ReadKey();

        }

    }
}