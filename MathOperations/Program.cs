using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ввидите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine($"сумма: {sum}");
            Console.ReadKey();

        }
    }
}
