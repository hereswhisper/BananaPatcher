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
        private static List<(int, string)> cosmeticPairs;

        static async Task Main(string[] args)
        {
            await Content.Cosmetics.addAllCosmeticHex();

            Console.WriteLine("BananaPatcher - v1.0.1 by @whisperends on discord");

            cosmeticPairs = GetCosmeticPairs();

            if (cosmeticPairs.Count == 0)
                return;

            int selection = GetSelection();

            if (selection <= 0)
                return;

            (int, string) selectedPair = GetSelectedPair(selection);

            Conversion.alert(selectedPair.Item1, selectedPair.Item2);
        }

        private static List<(int, string)> GetCosmeticPairs()
        {
            List<(int, string)> values = new List<(int, string)>();
            int wow = 0;

            foreach (var pair in Content.Cosmetics.__cosmeticsHex)
            {
                wow++;
                Console.WriteLine(wow + ". " + pair.Item1);
                values.Add((wow, pair.Item1));
            }

            return values;
        }

        private static int GetSelection()
        {
            Console.Write("Selection: ");
            string input = Console.ReadLine();

            return int.TryParse(input, out int selection) ? selection : -1;
        }

        private static (int, string) GetSelectedPair(int selection)
        {
            foreach (var pair in cosmeticPairs)
            {
                if (pair.Item1 == selection)
                {
                    return pair;
                }
            }

            return (-1, string.Empty);
        }
    }
}