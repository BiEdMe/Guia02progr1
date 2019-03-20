using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class3
    {
        int i, val12, val13, val14, val15, val16, val17;
        int J = 0, val11;
        int x = 0;
        int y = 100;
        double val1, val2, val3, val4, val5;
        String Nombre1, Nombre2, Nombre3, Nombre4;
        public void Estudiante()
        {
            
            Console.Clear();
            Console.WriteLine("****Programa en el cual reciba como entradas la siguiente información:\n Código del Estudiante, Nombre del Estudiante, Nombre de la Materia Tres Notas de 1.0 a 5.0.****");
            Console.WriteLine("Ingrese el numero de estudiantes que se calificaran");
            i = int.Parse(Console.ReadLine());


            for(J = 0;J <= i; J++)
            {
                Console.Clear();
                Console.WriteLine("Ingrese el código del estdiante");
                Nombre4 = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre de la primera Materia");
                Nombre1 = Console.ReadLine();
                Console.WriteLine("Ingrese la nota de la primera Materia");
                val1 = double.Parse(Console.ReadLine());
                if (val1 <= 3.9)
                {
                    Console.WriteLine("El estudiante "+Nombre4);
                    Console.WriteLine("Ha dejado la materia "+Nombre1+" con la nota de: " +val1);
                   
                }
                else
                {
                    Console.WriteLine("El estudiante " + Nombre4 );
                    Console.WriteLine("Ha pasado la materia " + Nombre1 + " con la nota de: " + val1);
                    
                }
                

                Console.WriteLine("Ingrese el nombre de la segunda Materia");
                Nombre2 = Console.ReadLine();
                Console.WriteLine("Ingrese la nota de la segunda Materia");
                val2 = double.Parse(Console.ReadLine());
                if (val1 <= 3.9)
                {
                    Console.WriteLine("El estudiante " + Nombre4);
                    Console.WriteLine("Ha dejado la materia " + Nombre2 + " con la nota de: " + val2);
                   
                }
                else
                {
                    Console.WriteLine("El estudiante " + Nombre4);
                    Console.WriteLine("Ha pasado la materia " + Nombre2 + " con la nota de: " + val2);
                    
                }
                
                
                Console.WriteLine("Ingrese el nombre de la tercera Materia");
                Nombre3 = Console.ReadLine();
                Console.WriteLine("Ingrese la nota de la tercera Materia");
                val3 = double.Parse(Console.ReadLine());
                if (val1 <= 3.9)
                {
                    Console.WriteLine("El estudiante " + Nombre4);
                    Console.WriteLine("Ha dejado la materia " + Nombre3 + " con la nota de: " + val3);
                    
                }
                else
                {
                    Console.WriteLine("El estudiante " + Nombre4);
                    Console.WriteLine("Ha pasado la materia " + Nombre3 + " con la nota de: " + val3);
                    
                }
                val4 = (val1 + val2 + val3)/3;
                Console.WriteLine("El promedio final es: "+val4);
                Console.ReadKey();
            }


            
        }

        public void Pers()
        {
            Console.Clear();
            Console.WriteLine("****Programa para determinar cuánto pagara una persona por  una  compra****");
            Console.WriteLine("Ingrese la cantidad de articaulos que lleva");
            val11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio unitario");
            val1 = double.Parse(Console.ReadLine());
            val5 = (val1 * val11);
            val3 = (val5 * 0.20);

            if(val5 <= 99999)
            {
                Console.WriteLine("No aplica a descuento.");
                Console.WriteLine("Cancele el precio de: $"+val5);
            }

            if (val5 >= 100000)
            {
                Console.WriteLine("Aplica a descuento.");
                Console.WriteLine("Cancele el precio de: $" + val5);
            }

        }

        public void Num()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un programa que lea por teclado dos números****");
            Console.WriteLine("Ingrese el primer numero");
            val11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            val12 = int.Parse(Console.ReadLine());
            if (val11 > val12)
            {
                Console.WriteLine("La suma de los dos números es: " + (val11 + val12));
                Console.WriteLine("La diferencia de los numeros es de: "+(val12 - val11));
            }

            if (val11 < val12)
            {
                Console.WriteLine("El producto de los numeros es: "+(val11 + val12) % 10);
                Console.WriteLine("La dvición del primero con respecto al segundo es: "+(val11 / val12));
            }

        }

        public void Plus()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un programa se ingresan tres notas de un alumno****");
            Console.WriteLine("Ingrese la primera nota del alumno");
            val1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota del alumno");
            val2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tercera nota del alumno");
            val3 = double.Parse(Console.ReadLine());
            val4 = (val1 + val2 + val3)/ 3;
            if (val4 >= 7)
            {
                Console.WriteLine("Usted ha sido promocionado por la nota de: "+val4);
            }
            else
            {
                Console.WriteLine("Usted no aplica a la promocion por la nota de: " + val4);
            }
        }

        public void Gig()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un programa que cuando se ingresa por teclado un número positivo de uno o dos dígitos****");
            Console.WriteLine("Ingrese un numero positivo");
            val11 = int.Parse(Console.ReadLine());
            
            if (val11 >= 0 && val11 <= 9)
            {
                Console.WriteLine("El numero es de una cifra");
            }
            else
            {
                Console.WriteLine("El numero es de dos cifras");
            }
        }

        public void Plug()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un programa que permita determinar el total a pagar por una compra****");
            Console.WriteLine("Ingrese la cantidad de productos que lleva");
            val11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto");
            val2 = double.Parse(Console.ReadLine());

            val3 = val11 * val2;

            if (val3 >= 20000)
            {
                Console.WriteLine("Aplica a un descuento del 35% su total es de: $"+(val3 / 0.35));
            }
            else
            {
                Console.WriteLine("Aplica a un descuento del 15% su total es de: $" + (val3 / 0.15));
            }
        }

        public void Doug()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un programa para determinar si un número cualquiera ingresado por el usuario es par o impar****");
            Console.WriteLine("Ingrese la cantidad de productos que lleva");
            val11 = int.Parse(Console.ReadLine());

            val12 = val11 % 10;

            if (val12 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }

        public void But()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un programa el cual permita ingresar los valores de temperatura de cada día durante una semana****");
            Console.WriteLine("Ingrese la Temperatura del dia lunes");
            val11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Temperatura del dia martes");
            val12 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Temperatura del dia miercoles");
            val13 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Temperatura del dia jueves");
            val14 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Temperatura del dia viernes");
            val15 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Temperatura del dia sabado");
            val16 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Temperatura del dia domingo");
            val17 = int.Parse(Console.ReadLine());

            J = (val11 + val12 + val13 + val14 + val15 + val16 + val17) /7;

            if(J >= 35)
            {
                Console.WriteLine("Esta semana estuvo calurosa, con una temperatura promedio de: "+J+"°");
            }

            if (J < 35 && J >=15)
            {
                Console.WriteLine("Esta semana estuvo deliciosa, con una temperatura promedio de: " + J + "°");
            }

            if (J < 15)
            {
                Console.WriteLine("Esta semana estuvo muy fría, con una temperatura promedio de: " + J + "°");
            }

        }

        public void Cross()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un programa que permita calcular el valor final  a  pagar en una súper tienda****");
            Console.WriteLine("Ingrese el numero de productos que lleva");
            val11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio de productos que lleva");
            val2 = double.Parse(Console.ReadLine());
            val3 = val11 * val2;

            if (val3 >= 10000 && val3 <= 20000)
            {
                Console.WriteLine("Aplica a un descuento del 10% su total es de: $" + (val3 / 0.10));
            }
            if(val3 >= 20001 && val3 < 50000)
            {
                Console.WriteLine("Aplica a un descuento del 30% su total es de: $" + (val3 / 0.30));
            }
            if (val3 >=50000)
            {
                Console.WriteLine("Aplica a un descuento del 50% su total es de: $" + (val3 / 0.50));
            }
        }

        public void Bogo()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un programa para determinar si un deportista es aceptado en el quipo de baloncesto de Bogotá.****");
            Console.WriteLine("Ingrese su edad");
            val11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su estatura");
            val2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su peso en kg.");
            val3 = double.Parse(Console.ReadLine());

            if (val11 <= 18 && val2 >= 1.80 && val3 <= 80)
            {
                Console.WriteLine("Bienvenido al equipo de baloncesto.");
            }
            else
            {
                Console.WriteLine("Ha sido rechazado en el equipo");
            }
        }

        public void Voca()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un programa que permita determinar si una letra es o no vocal****");
            Console.WriteLine("Ingrese una letra");
            Nombre1 = Console.ReadLine();

            switch (Nombre1)
            {
                case "a":
                    Console.WriteLine("Ha ingresado una vocal");
                    break;

                case "e":
                    Console.WriteLine("Ha ingresado una vocal");
                    break;

                case "i":
                    Console.WriteLine("Ha ingresado una vocal");
                    break;

                case "o":
                    Console.WriteLine("Ha ingresado una vocal");
                    break;
                    
                case "u":
                    Console.WriteLine("Ha ingresado una vocal");
                    break;

                default:
                    Console.WriteLine("Ha ingresado una consonante");
                    break;
            }
        }

        public void Duca()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un programa que permita calcular la velocidad, tiempo y distancia recorridos****");
            Console.WriteLine("Si desea calcular la distancia presione 1");
            Console.WriteLine("Si desea calcular la velocidad que posee un cuerpo presione 2");
            Console.WriteLine("Si desea calcular el tiempo del recorrido presione 3");
            val11 = int.Parse(Console.ReadLine());

            switch (val11)
            {
                case 1:
                    Console.WriteLine("Formula: X= v.t/2");
                    Console.WriteLine("ingrese el valor de la velocidad");
                    val1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del tiempo");
                    val2 = double.Parse(Console.ReadLine());
                    val3 = (val1 * val2)/2;
                    Console.WriteLine("El resultado es: "+val3);
                    break;

                case 2:
                    Console.WriteLine("Formula: X= d/t");
                    Console.WriteLine("ingrese el valor de la distancia");
                    val1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del tiempo");
                    val2 = double.Parse(Console.ReadLine());
                    val3 = (val1 / val2);
                    Console.WriteLine("El resultado es: " + val3);
                    break;

                case 3:
                    Console.WriteLine("Formula: X= d/t");
                    Console.WriteLine("ingrese el valor de la distancia");
                    val1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del tiempo");
                    val2 = double.Parse(Console.ReadLine());
                    val3 = (val1 / val2);
                    Console.WriteLine("El resultado es: " + val3);
                    break;

                default:
                    Console.WriteLine("Ha ingresado una opcion incorrecta");
                    break;
            }
        }

        public void Numi()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un Programa que permita ingresar un número cualquiera****");
            Console.WriteLine("Ingrese un numero");
            val11 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Si desea determinar que "+val11+" es par o impar presione 1");
            Console.WriteLine("Si desea determinar que " + val11 + " es positivo o negativo presione 2");
            val12 = int.Parse(Console.ReadLine());
            switch (val12)
            {
                case 1:
                    Console.WriteLine("El numero ingresado es: **" + val11 + "**");
                    if (val11 == 0)
                    {
                        Console.WriteLine("El numero par");
                    }
                    else
                    {
                        Console.WriteLine("El numero es impar");
                    }
                    break;

                case 2:
                    Console.WriteLine("El numero ingresado es: **" + val11 + "**");
                    if (val11 <= -1)
                    {
                        Console.WriteLine("El numero es negativo");
                    }
                    else
                    {
                        Console.WriteLine("El numero es positivo");
                    }
                    break;

                default:
                    Console.WriteLine("Ha ingresado una opcion incorrecta");
                    break;
            }
        }

        public void Edi_Eda_Edo_Edito()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un Programa que determine las siguientes opciones****");
            Console.WriteLine("Paso o no??? Presione 1 para saber");
            Console.WriteLine("Soy mayor de edad o no???");
            val11 = int.Parse(Console.ReadLine());
            
            switch (val11)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("La opcion: **" + val11 + "** ha sido ingresada");
                    Console.WriteLine("Ingrese su primer nota");
                    val2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese su segunda nota");
                    val3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese su tercera nota");
                    val4 = double.Parse(Console.ReadLine());
                    val5 = (val2 + val3 + val4)/3;
                    if (val5 <= 2.9)
                    {
                        Console.WriteLine("Ha dejado la materia");
                    }
                    else
                    {
                        Console.WriteLine("Ha pasado la materia");
                    }
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Ha seleccionada la opcion: **" + val11 + "**");
                    Console.WriteLine("Ingrese su edad");
                    val12 = int.Parse(Console.ReadLine());
                    if (val12 >=18)
                    {
                        Console.WriteLine("Usted es mayor de edad");
                    }
                    else
                    {
                        Console.WriteLine("Usted es menor de edad");
                    }
                    break;

                default:
                    Console.WriteLine("Ha ingresado una opcion incorrecta");
                    break;
            }
        }

        public void Debi()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un Programa que permita ver los números naturales comprendidos entre 0 y 1000****");
            for (int x = 0; x <= 1000; x++)
            {
                Console.WriteLine(x);
            }
        }

        public void Cero()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un Programa que permita ver los números pares comprendidos entre 0 y 200****");
            for (x = 0; x <= 200; x++)
            {
                if (x == 0)
                {
                    Console.WriteLine(x);
                }
            }
        }

        public void Impa()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un Programa que permita ver los números impares comprendidos entre 1 y 499****");
            for (x = 1; x <= 499; x++)
            {
                if (x == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(x);
                }
            }
        }

        public void Dab()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un Programa que determine cuantos estudiantes son mayores de edad en un grupo de 20 estudiantes.****");

            for (x = 1; x <= 20; x++)
            {
                Console.WriteLine("Ingrese la edad del estudiante " +x);
                val11 = int.Parse(Console.ReadLine());
                if (val11 <= 18)
                {
                    Console.WriteLine("El estudiante es MENOR de EDAD");
                }
                else
                {
                    Console.WriteLine("El estudiante es MAYOR de EDAD");
                }
            }
        }

        public void Esss()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un Programa que determine cuantos estudiantes son mayores de edad en un grupo de 20 estudiantes.****");

            for (x = 1; x <= 25; x++)
            {
                Console.WriteLine("Ingrese M si usted es muejer o H si usted es hombre");
                Nombre1 = Console.ReadLine();
                switch (Nombre1)
                {
                    case "H":
                        i = i + 1;
                        break;

                    case "Hombre":
                        i = i + 1;
                        break;

                    case "hombre":
                        i = i + 1;
                        break;

                    case "M":
                        J = J + 1;
                        break;

                    case "Mujer":
                        J = J + 1;
                        break;

                    case "mujer":
                        J = J + 1;
                        break;

                    default:
                        Console.WriteLine();
                        break;
                }
                Console.WriteLine("Hay "+i+" de hombres");
                Console.WriteLine("Hay " + J + " de mujeres");
            }
        }

        public void Dre()
        {
            Console.Clear();
            for(x = 1; x <= 15; x++)
            {
                Console.WriteLine("Ingrese su edad");
                val11 = int.Parse(Console.ReadLine());
                val12 = val11 / x;
                Console.WriteLine("La edad promedio en este momento es: "+val12);
            }
        }

    }
}