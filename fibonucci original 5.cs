using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_original
{
    internal class Program
    {
        static void Main(string[] args)
        {
             static void Fibonacci()
            {
                Console.Write("Ingrese el número de términos de la sucesión de Fibonacci a mostrar: ");
                int n = int.Parse(Console.ReadLine());

                int a = 0, b = 1;

                Console.WriteLine("Sucesión de Fibonacci:");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(a);
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
            }

        }
    }
}
