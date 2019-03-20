using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int valorA, valorB, valorC, valorD, valorE, Result, Cantidad;
        public double FinFin1, FinFin2, valorAV, valorBT, valorAS, ResultV, Result1, Result2, Result3, Precio, ValorFinal;
        public void Sum()
        {
            Console.Clear();
            Console.WriteLine("****Este es un programa que suma dos valores ingresados****");
            Console.WriteLine("Ingrese el primer valor");
            valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor");
            valorB = int.Parse(Console.ReadLine());
            Result = valorA + valorB;
            Console.WriteLine("El resultado de la suma es: " +Result);
        }

        public void Mult()
        {
            Console.Clear();
            Console.WriteLine("****Este es un programa que multiplica tres valores ingresados****");
            Console.WriteLine("Ingrese el primer valor");
            valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor");
            valorB = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer valor");
            valorC = int.Parse(Console.ReadLine());
            Result = (valorA * valorB) * valorC;
            Console.WriteLine("El resultado de la multplicacion es: " + Result);
        }

        public void Divi()
        {
            Console.Clear();
            Console.WriteLine("****Este es un programa que divide dos valores ingresados****");
            Console.WriteLine("Ingrese el primer valor");
            valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor");
            valorB = int.Parse(Console.ReadLine());
            Result = valorA / valorB;
            Console.WriteLine("El resultado de la multplicacion es: " + Result);
        }

        public void X()
        {
            Console.Clear();
            Console.WriteLine("****Este es un Programa para calcular la distancia recorrida.****");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*********Sabiendo que la formula es: X = VxT*********");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Ingrese el valor de la velocidad");
            valorAV = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor");
            valorBT = double.Parse(Console.ReadLine());
            ResultV = valorAV * valorBT;
            Console.WriteLine("El resultado de X = "+ valorAV+" x " +valorBT+ " es : " +ResultV+" metros cuadrados");
        }

        public void Anio()
        {
            Console.Clear();
            Console.WriteLine("****Este es un Programa que permite calcular la edad de una persona en dias.****");
            Console.WriteLine("Ingrese su edad");
            valorA = int.Parse(Console.ReadLine());
            Result = valorA * 365;
            Console.WriteLine("Su edad en dias es: "+Result);
        }

        public void Cal()
        {
            Console.Clear();
            Console.WriteLine("****Este es un Programa que permite calcular el 20% de un numero.****");
            Console.WriteLine("Ingrese un numero");
            valorAS = int.Parse(Console.ReadLine());
            Result1 = (valorAS * 20)/100;
            Console.WriteLine("El 20% del numero es: " + Result1);
        }

        public void Callo()
        {
            Console.Clear();
            Console.WriteLine("****Este es un Programa que permite calcular el 30%, 80% y 90% de un numero.****");
            Console.WriteLine("Ingrese un numero");
            valorAS = double.Parse(Console.ReadLine());
            Result1 = (valorAS * 30)/100;
            Result2 = (valorAS * 80)/100;
            Result3 = (valorAS * 90)/100;
            Console.WriteLine("El 30% del numero es: " + Result1);
            Console.WriteLine("El 80% del numero es: " + Result2);
            Console.WriteLine("El 90% del numero es: " + Result3);
        }

        public void Cua()
        {
            Console.Clear();
            Console.WriteLine("****Este es un Programa que permite calcular el area de un cuadrado****");
            Console.WriteLine("Ingrese un lado");
            valorAV = double.Parse(Console.ReadLine());
            Result1 = Math.Pow(valorAV,2);
            Console.WriteLine("El area del cuadrado es: " + Result1);
        }

        public void Cinco()
        {
            Console.Clear();
            Console.WriteLine("****Este es un Programa que permite ingresar 5 numeros y obtener dicho promedio****");
            Console.WriteLine("Ingrese el primer numero");
            valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            valorB = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            valorC = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero");
            valorD = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el quinto numero");
            valorE = int.Parse(Console.ReadLine());
            Result = (valorA + valorB + valorC + valorD + valorE)/5;
            Console.WriteLine("El promedio de dichos numeros es: " + Result);
        }

        public void Tienda()
        {
            Console.Clear();
            Console.WriteLine("****Este es un Programa que permite a una tienda saber el valor que pagara un cliente por la compra de varios elementos \n de la misma referencia.****");
            Console.WriteLine("Ingrese el precio de productos que lleva");
            Precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de productos");
            Cantidad = int.Parse(Console.ReadLine());
            ValorFinal = (Precio * Cantidad);
            FinFin1 = ValorFinal * 0.13;
            FinFin2 = FinFin1 + ValorFinal;

            Console.WriteLine("El precio final (incluido con IVA) a pagar es: " +ValorFinal);
        }

    }
}