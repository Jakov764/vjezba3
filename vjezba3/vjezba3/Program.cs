using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[3];
            Console.WriteLine("Upisi 1. string: ");
            a[0] = Console.ReadLine();

            Console.WriteLine("Upisi 2. string: ");
            a[1] = Console.ReadLine();

            Console.WriteLine("Upisi 3. string: ");
            a[2] = Console.ReadLine();

            Array.Sort(a);
            Array.Reverse(a);

            Console.WriteLine("Raznovrsni stringovi : ");
            for (int i= 0; i<3; i++)
            {
                Console.WriteLine(a[1]);

            }
            Console.ReadKey();
        }
    }
}
