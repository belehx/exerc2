using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Digite um número: ");
            a = int.Parse(Console.ReadLine());  

            if (a >= 20 && a <= 100) 
            {
                Console.WriteLine(a);
            } else
            {
                Console.WriteLine("O número não poderá ser exibido");
            }

            Console.ReadKey();
        }
    }
}
