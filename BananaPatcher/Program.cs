using BananaPatcher.Content;
using BananaPatcher.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BananaPatcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(int, string)> values = new List<(int, string)> ();

            Task.Run(async () => await Content.Cosmetics.addAllCosmeticHex()).Wait(); // whoopy

            Console.WriteLine("BananaPatcher - v1.0.0 by @whisperends on discord");

            int wow = 0;

            foreach(var pair in Cosmetics.__cosmeticsHex)
            {
                wow++;
                Console.WriteLine(wow + ". " + pair.Item1);
                values.Add((wow, pair.Item1));
            }

            Console.Write("Selection: ");
            string aaaaa = Console.ReadLine();

            if(aaaaa.Length <= 0) return;

            foreach(var pair in values)
            {
                int anum = Int32.Parse(aaaaa);

                Console.WriteLine(anum);

                if(anum == pair.Item1)
                {
                    Conversion.alert(pair.Item1, pair.Item2); // wowie
                    break;
                }
            }
        }
    }
}
