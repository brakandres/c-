using System;

namespace IndiceDeMasaCorporal
{
    class IndiceDeMasaCorporal
    {
        static void Main(string[] args)
        {
            double imc, pk, est;
            string md;
            Console.WriteLine("digite su peso en kg:");
            pk = double.Parse(Console.ReadLine());
            Console.WriteLine("digite estatura en metros:");
            est = double.Parse(Console.ReadLine());
            imc = Math.Round(pk / (double)Math.Pow(est, 2), 2);

            md = imc >= 18 ? (imc < 24) ? "peso normal" :
                 (imc < 26) ? "sobre peso 1" :
                 (imc < 29) ? "sobre peso 2 (preobecidad)" :
                 (imc < 30) ? "obesidad tipo 1" :
                 (imc < 35) ? "obesidad tipo 2" :
                 (imc < 40) ? "obesidad tipo 3" : "(mórtida)" :
                 (imc < 50) ? "obesidad tipo 4" : "(extrema)";
            Console.WriteLine(md);
            Console.ReadKey();
        }
    }
}