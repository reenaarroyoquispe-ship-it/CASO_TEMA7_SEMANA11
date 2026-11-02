using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO_TEMA7_SEMANA11
{
    internal class Program
    {
        static public void numero_naturales()
        {
            Console.WriteLine("Ingresar numero de N: ");
            int N = int.Parse(Console.ReadLine());
            int S= 0;
            for (int c=1; c<=N;c++)
            {
                S = S + c;
            }
            Console.WriteLine("La suma es: " + S);
        }
        static public int sumaN_con_recursividad(int N)
        {
            if (N == 1)
            {
                return 1;
            }
            return N + sumaN_con_recursividad(N - 1);
        }
        static public int sumaNP_con_recursividad(int N)
        {
            if (N == 2)
            {
                return 2;
            }
            return N + sumaNP_con_recursividad(N - 2);
        }
        static public int factorial_con_recursividad(int N)
        {
            if (N == 1)
            {
                return 1; 
            }
            return N * factorial_con_recursividad(N - 1);
        }
        static public int potencia_con_recursividad(int B, int exponente)
        {
            if (exponente == 1)
            {
                return B;
            }
            return B * potencia_con_recursividad(B, exponente - 1);
        }
        static public void conteo_regresivo(int N)
        {
            if (N < 0)
            {
                return;
            }
            Console.WriteLine(N);
            conteo_regresivo(N - 1);
        }
        static public int suma_arreglos(int[] numeros, int indice)
        {
            if (indice >= numeros.Length)
            {
                return 0;
            }
            return numeros[indice] + suma_arreglos(numeros, indice + 1);
        }
        static void Main(string[] args)
        {
            int opc;
            bool valor = true;
            while (valor)
            {
                Console.Clear();
                Console.WriteLine("************************");
                Console.WriteLine("\t\tMenú de opciones");
                Console.WriteLine("************************");
                Console.WriteLine("[1] Suma de N numeros naturales");
                Console.WriteLine("[2] Suma de N numeros naturales con recusirva");
                Console.WriteLine("[3] Suma de N numeros pares con recusirva");
                Console.WriteLine("[4] Factoria");
                Console.WriteLine("[5] Potencia");
                Console.WriteLine("[6] Conteo regresivo");
                Console.WriteLine("[7] Arreglos");
                Console.WriteLine("[8] Salir");
                opc = int.Parse(Console.ReadLine());
                switch(opc)
                {
                    case 1:
                        numero_naturales();
                        break;
                    case 2:
                        Console.Write("Ingresar numero N:");
                        int N = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma es:" + sumaN_con_recursividad(N));
                        break;
                    case 3:
                        Console.Write("Ingresar numero N:");
                        int N1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma de pares es: " + sumaNP_con_recursividad(N1 * 2));
                        break;
                    case 4:
                        Console.Write("Ingresar Num:");
                        int N2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El factorial es :" + factorial_con_recursividad(N2));
                        break;
                    case 5:
                        Console.Write("Ingresar base:");
                        int B= int.Parse(Console.ReadLine());
                        Console.Write("Ingresar exponenete:");
                        int expo = int.Parse(Console.ReadLine());
                        Console.WriteLine(B + "^" + expo + "=" + potencia_con_recursividad(B,expo));
                        break;
                    case 6:
                        int N3;
                        N3 = int.Parse(Console.ReadLine());
                        conteo_regresivo(N3);
                        break;
                    case 7:
                        int[] numeros = { 10, 15, 20, 25, 30 };
                        Console.WriteLine("La suma del arreglo es" + suma_arreglos(numeros, 0));
                        break;
                    case 8:
                        valor = false;
                        break;
                    default:
                        Console.WriteLine("Opción no valida");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
