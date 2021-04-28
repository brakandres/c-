using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leer_valor_entero_y_calcular_el_cubo_de_valor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;


            Console.WriteLine("favor ingresar el numero: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write("el cubo del numero " + numero + "es:" + numero * numero * numero);
            Console.ReadKey();
        }
    }
}
