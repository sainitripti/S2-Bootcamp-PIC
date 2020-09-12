using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray numbers = new DynamicArray();
            for (int i = 0; i < 15; i++)
            {
                numbers.Set_Item(i, i + 10);

            }
            int value = numbers.Get_Item(12);
            Console.WriteLine(value);
            Console.WriteLine(numbers.Length);//error
            Console.WriteLine(numbers.ItemCount);//error

        }
    }
}
