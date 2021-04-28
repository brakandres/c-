using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolares, pesos;
            Console.Write("dolares:");
            dolares = double.Parse(Console.ReadLine());
            pesos = dolares * 3714.25;
            Console.WriteLine("dolares={0} equivale a {1} pesos", dolares, pesos);
            Console.ReadKey();
        }
    }
}
