using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compiler will reflect CalculatorLib metadata
            CalculatorLib.Calculator obj = new CalculatorLib.Calculator();

            int result = obj.Add(10, 20);

            Console.WriteLine(result);
        }
    }
}
