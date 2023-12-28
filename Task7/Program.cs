using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{

    public class Program
    {
        public static bool q(int n, int a, int b, int c)
        {
            if (n > 2 && Math.Pow(a, n) + Math.Pow(b, n) == Math.Pow(c, n))
            {
                return false;
            }
            else { return true; };
        }
        static void Main(string[] args)
        {
            int n, a, b, c;

            Console.WriteLine("Введите значение n в теореме a^n + b^n = c^n :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение c:");
            c = Convert.ToInt32(Console.ReadLine());


            if (q(n,a,b,c))
            {
                Console.WriteLine($"Теорема Ферма доказана для n={n}.");
            }
            else
            {
                Console.WriteLine($"Теорема Ферма не выполняется для n={n}.");
            }

            Console.ReadLine();
        }
    }
}
