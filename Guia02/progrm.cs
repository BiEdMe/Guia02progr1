using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            int Opcion = 0;
            Class1 obj = new Class1();
            Class2 obj2 = new Class2();
            Class3 obj3 = new Class3();
            Class4 obj4 = new Class4();
            Ejercicio62 obj5 = new Ejercicio62();
            Ejercicio63 obj6 = new Ejercicio63();
            Ejercicio64 obj7 = new Ejercicio64();
            Ejercicio65 obj8 = new Ejercicio65();
            Ejercicio66 obj9 = new Ejercicio66();
            Ejercicio67 obj10 = new Ejercicio67();
            Ejercicio68 obj11 = new Ejercicio68();
            Dev obj14 = new Dev();
            Progro obj13 = new Progro();
            Progra obj12 = new Progra();
            Programk obj15 = new Programk();
            Gro obj16 = new Gro();
            Class5 obj17 = new Class5();
            Class6 obj18 = new Class6();
            Class7 obj19 = new Class7();
            Class8 obj20 = new Class8();
            Class9 obj21 = new Class9();
            Class10 obj22 = new Class10();
            Class11 obj23 = new Class11();
            Class12 obj24 = new Class12();

            Console.WriteLine();
            Console.WriteLine("**********************************************");
            Console.WriteLine("**********************************************");
            Console.WriteLine("Ingrese un numero del 1 hasta el 78 para realizar un ejercicio" +
                "(CADA NUMERO ES UN EJERCICIO)");
            Opcion = int.Parse(Console.ReadLine());
            switch (Opcion)
            {
                case 1:
                    obj.Sum();
                    break;

                case 2:
                    obj.Mult();
                    break;

                case 3:
                    obj.Divi();
                    break;

                case 4:
                    obj.X();
                    break;

                case 5:
                    obj.Anio();
                    break;

                case 6:
                    obj.Cal();
                    break;

                case 7:
                    obj.Callo();
                    break;

                case 8:
                    obj.Cua();
                    break;

                case 9:
                    obj.Cinco();
                    break;

                case 10:
                    obj.Tienda();
                    break;

                case 11:
                    obj2.Suel();
                    break;

                case 12:
                    obj2.Cuad();
                    break;

                case 13:
                    obj2.O_5();
                    break;

                case 14:
                    obj2.Prom();
                    break;

                case 15:
                    obj2.Ing();
                    break;

                case 16:
                    obj2.Pig();
                    break;

                case 17:
                    obj2.Dig();
                    break;

                case 18:
                    obj2.Lig();
                    break;

                case 19:
                    obj2.Hig();
                    break;

                case 20:
                    obj2.Kig();
                    break;

                case 21:
                    obj3.Estudiante();
                    break;

                case 22:
                    obj3.Pers();
                    break;

                case 23:
                    obj3.Num();
                    break;

                case 24:
                    obj3.Plus();
                    break;

                case 25:
                    obj3.Gig();
                    break;

                case 26:
                    obj3.Plug();
                    break;

                case 27:
                    obj3.Doug();
                    break;

                case 28:
                    obj3.But();
                    break;

                case 29:
                    obj3.Cross();
                    break;

                case 30:
                    obj3.Bogo ();
                    break;

                case 31:
                    obj3.Voca();
                    break;

                case 32:
                    obj3.Duca();
                    break;

                case 33:
                    obj3.Numi();
                    break;

                case 34:
                    obj3.Edi_Eda_Edo_Edito();
                    break;

                case 35:
                    obj3.Debi();
                    break;

                case 36:
                    obj3.Cero();
                    break;

                case 37:
                    obj3.Impa();
                    break;

                case 38:
                    obj3.Dab();
                    break;

                case 39:
                    obj3.Esss();
                    break;

                case 40:
                    obj3.Dre();
                    break;

                case 41:
                    obj12.Main();
                    break;

                case 42:
                    obj13.Maini();
                    break;

                case 43:
                    obj14.Mapin();
                    break;

                case 44:
                    obj15.Main();
                    break;

                case 45:
                    obj16.Main();
                    break;

                case 46:
                    obj3.Dab();
                    break;

                case 47:
                    obj3.Esss();
                    break;

                case 48:
                    obj3.Dre();
                    break;

                case 49:
                    obj4.Elv();
                    break;

                case 50:
                    obj4.Rep();
                    break;

                case 51:
                    obj4.Deaf();
                    break;

                case 52:
                    obj4.CoL();
                    break;

                case 53:
                    obj4.Cluy();
                    break;

                case 54:
                    obj4.Cuz();
                    break;

                case 55:
                    obj4.Criss();
                    break;

                case 56:
                    obj4.Man();
                    break;

                case 57:
                    obj4.Triii();
                    break;

                case 58:
                    obj4.Miin();
                    break;

                case 59:
                    obj4.Main();
                    break;

                case 60:
                    obj4.Main();
                    break;

                case 61:
                    obj5.cargar();
                    obj5.imprimir();
                    break;

                case 62:
                    obj6.cargar();
                    obj6.mostrar();
                    break;

                case 63:
                    obj6.cargar();
                    obj6.mostrar();
                    break;

                case 64:
                    obj7.cargar();
                    obj7.mostrar();
                    break;

                case 65:
                    obj8.cargar();
                    obj8.mostrar();
                    break;

                case 66:
                    obj9.captura1();
                    obj9.captura2();
                    obj9.calcularcapt1();
                    obj9.calcularcapt2();
                    break;

                case 67:
                    obj10.captura1();
                    obj10.mostrarcuadrado();
                    obj10.mostrarcubo();
                    break;

                case 68:
                    obj11.capturar();
                    obj11.totalestudiantes();
                    obj11.imprimir();
                    break;

                case 69:
                    obj17.Nombres();
                    break;

                case 70:
                    obj18.Lol();
                    break;

                case 71:
                    obj19.Matriz();
                    break;

                case 72:
                    obj20.Matriz2();
                    break;

                case 73:
                    obj24.Plan();
                    break;

                case 74:
                    obj24.Plan();
                    break;

                case 75:
                    obj24.Plan();
                    break;

                case 76:
                    obj23.Matriz2();
                    break;

                case 77:
                    obj21.Matriz2();
                    break;

                case 78:
                    obj21.Matriz2();
                    break;

                default:
                    Console.WriteLine("Opcion erronea");
                    break;
            }
            Console.ReadKey();
        }
    }
}