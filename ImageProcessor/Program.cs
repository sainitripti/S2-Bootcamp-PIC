using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            GraySeparatorImageAnalyzer.ImageAnalyzer imageAnalyser = new GraySeparatorImageAnalyzer.ImageAnalyzer();
            Console.WriteLine("Enter text in lowercase: ");
            string lowercaseText = Console.ReadLine();
            string uppercaseText = imageAnalyser.Analyse(lowercaseText);
            Console.WriteLine($"Uppercase Text: {uppercaseText}");
            Console.ReadLine();
        }
    }
}
