using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BananaPatcher.Helpers
{
    internal class ConversionEmote
    {
        /// <summary>
        /// Wowie, epic code Credits: https://stackoverflow.com/questions/5237666/adding-text-decorations-to-console-output
        /// </summary>
        const int STD_OUTPUT_HANDLE = -11;
        const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 4;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll")]
        static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        [DllImport("kernel32.dll")]
        static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);
        public static void alert(int num, string name)
        {
            string convertTo = getconvertTo(name);
            string hexToReplaceWith = gethexToReplaceWith(name);
            string toConvert = convertTo;
            string parentHex = getParentHex(convertTo);

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
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("FAILURE TO FOLLOW THIS TUTORIAL ABOVE ^ CAN CORRUPT YOUR FrontendLoadout.sav FILE. SO PLEASE FOLLOW IT.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.WriteLine("Please enter the path where you find your FrontendLoadout.sav file and press enter. Example: C:\\Users\\Whisper\\AppData\\Local\\FortniteGame\\Saved\\SaveGames\\FrontendLoadout.sav");
            string filePath = Console.ReadLine();

            // TODO: Start Conversion
            int successCode = HexEditor.FindAndReplace(filePath, parentHex, hexToReplaceWith);
            if (successCode == 0)
            {
                var handle = GetStdHandle(STD_OUTPUT_HANDLE);
                uint mode;
                GetConsoleMode(handle, out mode);
                mode |= ENABLE_VIRTUAL_TERMINAL_PROCESSING;
                SetConsoleMode(handle, mode);
                const string UNDERLINE = "\x1B[4m";
                const string RESET = "\x1B[0m";
                Console.Clear();
                Console.WriteLine("BananaPatcher - v1.0.1 by @whisperends on discord");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(UNDERLINE + "BananaRush was successfully patched!" + RESET);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" Please restart your game to see the results, Thank you for using the BananaPatcher\n");
                Console.WriteLine("Press any key to close");
                Console.ReadKey();
            }
        }

        public static string getParentHex(string convertTo)
        {
            return "2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 44 61 6E 63 65 73 2F 45 49 44 5F 44 61 6E 63 65 4D 6F 76 65 73 2E 45 49 44 5F 44 61 6E 63 65 4D 6F 76 65 73";
        }

        public static string getconvertTo(string name)
        {
            foreach (var pairs in Content.Cosmetics.__emotesHex)
            {
                if (pairs.Item1 == null) continue;
                if (pairs.Item2 == null) continue;

                if (pairs.Item1 == name)
                {
                    return pairs.Item4;
                }
            }

            return "";
        }

        public static string gethexToReplaceWith(string name)
        {
            foreach (var pairs in Content.Cosmetics.__emotesHex)
            {
                if (pairs.Item1 == null) continue;
                if (pairs.Item2 == null) continue;

                if (pairs.Item1 == name)
                {
                    return pairs.Item2;
                }
            }

            return "";
        }
    }
}
