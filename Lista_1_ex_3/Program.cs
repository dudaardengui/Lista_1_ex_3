using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a;
            Console.WriteLine("Digite seu sexo utilizando F ou M:");
            a = char.Parse(Console.ReadLine());
            if (a == 'M' || a == 'F')
            {
                Console.WriteLine("O sexo digitado é válido.");
            }
            else
            {
                Console.WriteLine("O sexo digitado não é válido.");
            }
            Console.ReadKey();
        }
    }
}
