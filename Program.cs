using System;

namespace grausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            double celsius= 97;

            Console.WriteLine("digite sua temperatura fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) / 1.8;
            Console.WriteLine("fahrenheit para celsius = {0}" , celsius);
            Console.Write("\n");

            Console.WriteLine("pressione Enter para sair! ");
            Console.ReadLine();
        }
    }
}
