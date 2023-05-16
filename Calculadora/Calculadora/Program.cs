using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriu un numero");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriu un altre numero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int suma = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, suma);

            int restar = num1 - num2;
            Console.WriteLine("{0} - {1} = {2}", num1, num2, restar);

        }
    }
}
