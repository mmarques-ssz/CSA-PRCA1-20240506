using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.Write("Digite o valor do lado 1: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor do lado 2: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor do lado 3: ");
            c = int.Parse(Console.ReadLine());

            if (a + b > c)
                if (a + c > b)
                    if (b + c > a)
                        if (a == b)
                            if (a == c)
                                Console.WriteLine("Equilátero");
                            else
                                Console.WriteLine("Isósceles");
                        else
                            if (b == c)
                                Console.WriteLine("Isósceles");
                            else
                               if (a == c)
                                  Console.WriteLine("Isósceles");
                               else
                                  Console.WriteLine("Escaleno");
                        else
                           Console.WriteLine("Não forma triângulo");
                     else
                        Console.WriteLine("Não forma triângulo");
                else
                   Console.WriteLine("Não forma triângulo");

        }
    }
}
