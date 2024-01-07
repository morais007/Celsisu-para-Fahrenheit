using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsisu_para_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Grau Celsius para Grau Fahrenheit

            double celsius, fahrenheit, resultado;

            Console.WriteLine("Formula F = 37 x 1,8 + 32");
            Console.Write("Digite uma Temperatura: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine($"Portanto,{celsius} graus Celsius equivalem a {fahrenheit} graus Fahrenheit.");

            Console.ReadKey();
        }
    }
}
