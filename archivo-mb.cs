using System;

namespace CantidadDeArchivosEnMb
{
    class CantidadDeArchivosEnMb
    {
        static void Main(string[] args)
        {
            int GB, MB;
            Console.Write("Ingresa el valor de GB: ");
            GB = int.Parse(Console.ReadLine());
            MB = GB * 1024;
            Console.WriteLine("Valor de MB: " + MB);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
