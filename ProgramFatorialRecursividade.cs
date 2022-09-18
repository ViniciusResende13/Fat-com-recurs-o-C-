using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial_com_função_recursiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Digite o número que você quer o fatorial: ");
            n= int.Parse(Console.ReadLine());


            Console.WriteLine("\nO fatorial é: ");
            Console.WriteLine(fat(n));


            Console.ReadKey();
        }
        static int fat (int n)
        {
            int res;
            if (n <= 1)
            {
                res = 1;
            }
            else
            {
                res = n*fat(n-1);
            }
            return res;
        }
    }
}
