using System;

namespace Calculo_De_La_Edad
{
    class Calculo
    {
        static void Main(string[] args)
        {
            int anno_actual, anno_de_nacimiento, dia_actual, dia_de_nacimiento, edad;
            int mes_actual, mes_de_nacimiento;
            Console.Write("Ingresa el valor de anno actual: ");
            anno_actual = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de anno de nacimiento: ");
            anno_de_nacimiento = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de dia actual: ");
            dia_actual = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de dia de nacimiento: ");
            dia_de_nacimiento = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de mes actual: ");
            mes_actual = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de mes de nacimiento: ");
            mes_de_nacimiento = int.Parse(Console.ReadLine());
            edad = anno_actual - anno_de_nacimiento;
            if (mes_de_nacimiento > mes_actual || (mes_de_nacimiento == mes_actual && dia_de_nacimiento > dia_actual))
                edad = edad - 1;
            Console.WriteLine("Valor de edad: " + edad);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}