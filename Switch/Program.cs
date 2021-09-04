using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int monat = 0;

            switch(monat)
            {
                case 1:
                    Console.WriteLine("Januar");
                break;

                case 2:
                    Console.WriteLine("Februar");
                break;

                case 3:
                    Console.WriteLine("März");
                break;

                default:
                    Console.WriteLine("Fehlrhafter Monat");
                break;
            }

            Console.ReadKey();
        }
    }
}
