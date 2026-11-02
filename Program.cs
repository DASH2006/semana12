using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana12
{
    internal class Program
    {
        public static void factorial_sinrecursividad()
        {
            Console.WriteLine("Ingrese un número para calcular su factorial: ");
            int N= int.Parse(Console.ReadLine());
            long fact = 1;
            for (int i = 1; i <= N ; i++)
            {
                fact *= i;
            }
            Console.WriteLine("El factorial de " + N + " es: " + fact);
        }
        public static long factorialRecursivo(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorialRecursivo(n - 1);
            }
        }
        public static void potencia_sinrecursiva()
        {
            int B, exp;
            Console.WriteLine("Ingrese la base: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el exponente: ");
            exp = int.Parse(Console.ReadLine());
            long P = 1;
            for (int i = 1; i <= exp; i++)
            {
                P = P * B;
            }
            Console.WriteLine("Potencia: "+P);
        }
        static public double potencia_recursiva(double B, int exp)
        {
            if (exp == 0)
            {
                return 1;
            }
            else
            {
                return B * potencia_recursiva(B, exp - 1);
            }
        }
        static public int sumatoria(int N)
        {
            if (N == 1)
            {
                return 1;
            }
            else
            {
                return N + sumatoria(N - 1);
            }
        }
        static public int conteo_regresivo(int N)
        {
            if (N == 0)
            {
                return 0;
            }
            Console.WriteLine(N);
            return conteo_regresivo(N - 1);
        }
        static public int suma_arreglo(int[] numeros, int indice)
        {
            if(indice >= numeros.Length)
            {
                return 0;
            }
            return numeros[indice] + suma_arreglo(numeros, indice + 1);
        }
        static void Main(string[] args)
        {
            int opc;
            bool S = true;
            while (S)
            {
                Console.WriteLine("*************************: ");
                Console.WriteLine("\t\tMenu");
                Console.WriteLine("*************************: ");
                Console.WriteLine("[1] Factorial sin recursividad");
                Console.WriteLine("[2] Factorial con recursividad");
                Console.WriteLine("[3] Potencia sin recursividad");
                Console.WriteLine("[4] Potencia con recursividad");
                Console.WriteLine("5] Sumatoria de primeros N numeros natursles");
                Console.WriteLine("6]Conteo regresivo de N a 1: ");
                Console.WriteLine("7]Arreglos: ");
                Console.WriteLine("8] Salir");
                Console.WriteLine("*************************: ");
                Console.WriteLine("Ingrese una opción:");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        factorial_sinrecursividad();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese un número para calcular su factorial: ");
                        int num = int.Parse(Console.ReadLine());
                        long resultado = factorialRecursivo(num);
                        Console.WriteLine("El factorial de " + num + " es: " + resultado);
                        break;
                    case 3:
                        potencia_sinrecursiva();
                        break;
                    case 4:
                        Console.WriteLine("Ingrese la base: ");
                        int B = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el exponente: ");
                        int exponente = int.Parse(Console.ReadLine());
                        Console.WriteLine(B + "" + exponente + "=" + potencia_recursiva(B, exponente));
                        break;
                    case 5:
                        Console.WriteLine("Ingrese un número para calcular la sumatoria: ");
                        int N1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La sumatoria de los numeros naturales es: " + sumatoria(N1));
                        break;
                    case 6:
                        Console.Write("Ingrese el valor de N: ");
                        int N2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Conteo regresivo de N a 1: " + conteo_regresivo(N2));
                        conteo_regresivo(N2);
                        break;
                    case 7:
                        Console.WriteLine("suma de arreglo:");
                        int[] numeros = { 10, 20, 30, 40, 50 };
                        Console.WriteLine("Suma de arreglo: " + suma_arreglo(numeros, 0));
                        break;
                    case 8:
                        S = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, ingrese una opción válida.");
                        break;
                }
                Console.ReadKey();
            }

            
        }
    }
}
