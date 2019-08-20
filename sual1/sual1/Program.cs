using System;

namespace Ciclo_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Imprime los nùmeros del x hasta y de -1");
            Console.WriteLine("De donde arrancamos el ciclo (Mayor):  ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De donde terminamos el ciclo (Menor):  ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De cuanto en cuanto:  ");
            z = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i > y; i -= z)
            {
                Console.WriteLine("i = " + i);
            }
        }
    }
}
