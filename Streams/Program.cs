using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            FileCounter fc = new FileCounter();

            Console.WriteLine("Aantal meisjesnamen: " + fc.CountLines("meisjes_namen.txt"));
            Console.WriteLine("Aantal jongensnamen: " + fc.CountLines("jongens_namen.txt"));

            Console.WriteLine("Aantal keer dat de letter 'a' voorkomt in meisjesnamen: " + fc.Count("meisjes_namen.txt", 'a'));
            Console.WriteLine("Aantal keer dat de letter 'x' voorkomt in jongensnamen: " + fc.Count("jongens_namen.txt", 'x'));

            Console.ReadLine();
        }
    }
}
