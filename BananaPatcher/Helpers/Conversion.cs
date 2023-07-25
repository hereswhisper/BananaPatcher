using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaPatcher.Helpers
{
    internal class Conversion
    {
        public static void alert(int num, string name)
        {
            bool isSeaWolf = false;
            string convertTo = "";

            foreach(var pairs in Content.Cosmetics.__cosmeticsHex)
            {
                if(pairs.Item1 == null) continue;
                if(pairs.Item2 == null) continue;

                if(pairs.Item1 == name)
                {
                    if(pairs.Item3 == true)
                    {
                        isSeaWolf = true;
                    } else
                    {
                        convertTo = pairs.Item4;
                    }
                }
            }

            string toConvert = isSeaWolf ? "Sea Wolf Jonesy" : convertTo;

            Console.Clear();
            Console.WriteLine("You are about to modify your FrontendLoadout.sav file. Before you do it. PLEASE READ THE FOLLOWING INSTRUCTIONS");

            Console.WriteLine("1. Please open your FortniteGame.exe File that you have BananaRush installed to.");
            Console.WriteLine("2. When you are in lobby, Please press the 'C' key on your keyboard to access the Locker");
            Console.Write("3. Go to the skins part of the locker and Equip the following skin: ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(toConvert + "\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("4. After, Close your BananaRush game and press the 'ENTER' key to begin the conversion process.");
            Console.WriteLine("");
            Console.WriteLine("Press 'ENTER' to start");
            Console.ReadLine();

            // TODO: Start Conversion
        }
    }
}
