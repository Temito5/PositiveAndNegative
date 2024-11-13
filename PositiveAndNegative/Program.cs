using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveAndNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();

            Console.Write("Въведи число: ");
            int num=int.Parse(Console.ReadLine());

            bool result= number.IsPositive(num);
            Console.WriteLine(result);
        }
    }
}
