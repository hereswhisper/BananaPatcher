using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaPatcher.Content
{
    internal class Cosmetics
    {
        public static List<(string, string, bool, string)> __cosmeticsHex = new List<(string, string, bool, string)>();

        public static void addAllCosmeticHex()
        {
            // Swap with Calamity
            __cosmeticsHex.Add(("Sled Ready Guff", "2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 43 68 61 72 61 63 74 65 72 73 2F 43 68 61 72 61 63 74 65 72 5F 43 6F 6D 65 74 44 65 65 72 2E 43 68 61 72 61 63 74 65 72 5F 43 6F 6D 65 74 44 65 65 72 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", false, "Calamity"));
           
            // Swap with Luxe
            __cosmeticsHex.Add(("BlackHeart", "2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 43 68 61 72 61 63 74 65 72 73 2F 43 68 61 72 61 63 74 65 72 5F 50 69 72 61 74 65 2E 43 68 61 72 61 63 74 65 72 5F 50 69 72 61 74 65 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", false, "Luxe"));
            
            // Swap with Sea Wolf Jonesy
            __cosmeticsHex.Add(("Recruit 001", "2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 43 68 61 72 61 63 74 65 72 73 2F 43 49 44 5F 30 30 31 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 44 65 66 61 75 6C 74 2E 43 49 44 5F 30 30 31 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 44 65 66 61 75 6C 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", true, ""));

            // Swap with Sea Wolf Jonesy
            __cosmeticsHex.Add(("Recruit 002", "2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 43 68 61 72 61 63 74 65 72 73 2F 43 49 44 5F 30 30 32 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 44 65 66 61 75 6C 74 2E 43 49 44 5F 30 30 32 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 44 65 66 61 75 6C 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", true, ""));

            // Swap with Sea Wolf Jonesy
            __cosmeticsHex.Add(("Recruit 003", "2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 43 68 61 72 61 63 74 65 72 73 2F 43 49 44 5F 30 30 33 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 44 65 66 61 75 6C 74 2E 43 49 44 5F 30 30 33 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 44 65 66 61 75 6C 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", true, ""));

            // Swap with Sea Wolf Jonesy
            __cosmeticsHex.Add(("Recruit 004", "2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 43 68 61 72 61 63 74 65 72 73 2F 43 49 44 5F 30 30 34 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 44 65 66 61 75 6C 74 2E 43 49 44 5F 30 30 34 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 44 65 66 61 75 6C 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", true, ""));

            // Swap with Sea Wolf Jonesy
            __cosmeticsHex.Add(("Recruit 005", "2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 43 68 61 72 61 63 74 65 72 73 2F 43 49 44 5F 30 30 35 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 4D 5F 44 65 66 61 75 6C 74 2E 43 49 44 5F 30 30 35 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 4D 5F 44 65 66 61 75 6C 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", true, ""));

            // Swap with Sea Wolf Jonesy
            __cosmeticsHex.Add(("Recruit 006", "2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 43 68 61 72 61 63 74 65 72 73 2F 43 49 44 5F 30 30 36 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 4D 5F 44 65 66 61 75 6C 74 2E 43 49 44 5F 30 30 36 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 4D 5F 44 65 66 61 75 6C 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", true, ""));

            // Swap with Sea Wolf Jonesy
            __cosmeticsHex.Add(("Recruit 007", "2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 43 68 61 72 61 63 74 65 72 73 2F 43 49 44 5F 30 30 37 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 4D 5F 44 65 66 61 75 6C 74 2E 43 49 44 5F 30 30 37 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 4D 5F 44 65 66 61 75 6C 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", true, ""));

            // Swap with Sea Wolf Jonesy
            __cosmeticsHex.Add(("Recruit 008", "2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 43 68 61 72 61 63 74 65 72 73 2F 43 49 44 5F 30 30 38 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 4D 5F 44 65 66 61 75 6C 74 2E 43 49 44 5F 30 30 38 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 4D 5F 44 65 66 61 75 6C 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", true, ""));

            // Swap with Sea Wolf Jonesy
            __cosmeticsHex.Add(("Commando", "2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 43 68 61 72 61 63 74 65 72 73 2F 43 49 44 5F 30 31 36 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 2E 43 49 44 5F 30 31 36 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", true, ""));

            // Swap with Sea Wolf Jonesy
            __cosmeticsHex.Add(("Survival Specialist", "2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 43 68 61 72 61 63 74 65 72 73 2F 43 49 44 5F 30 32 37 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 2E 43 49 44 5F 30 32 37 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", true, ""));

            // Swap with Sea Wolf Jonesy
            __cosmeticsHex.Add(("Renegade Raider", "2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 43 68 61 72 61 63 74 65 72 73 2F 43 49 44 5F 30 32 38 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 2E 43 49 44 5F 30 32 38 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", true, ""));

            // Swap with Sea Wolf Jonesy
            __cosmeticsHex.Add(("Ghoul Trooper", "2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 49 74 65 6D 73 2F 43 6F 73 6D 65 74 69 63 73 2F 43 68 61 72 61 63 74 65 72 73 2F 43 49 44 5F 30 32 39 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 48 61 6C 6C 6F 77 65 65 6E 2E 43 49 44 5F 30 32 39 5F 41 74 68 65 6E 61 5F 43 6F 6D 6D 61 6E 64 6F 5F 46 5F 48 61 6C 6C 6F 77 65 65 6E 00 00 00 00 00 00 00 00 00 00 00", true, ""));

            // Swap with Sea Wolf Jonesy
            //__cosmeticsHex.Add(("Captain Crackshot", "value3", true, ""));

            //
            //__cosmeticsHex.Add(("key3", "value3"));

            //
            //__cosmeticsHex.Add(("key3", "value3"));
        }
    }
}
