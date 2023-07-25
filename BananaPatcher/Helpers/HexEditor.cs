using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaPatcher.Helpers
{
    internal class HexEditor
    {
        public static int FindAndReplace(string filePath, string searchString, string replaceString)
        {
            try
            {
                byte[] searchBytes = StringToByteArray(searchString);
                byte[] replaceBytes = StringToByteArray(replaceString);

                // Read the binary data from the file
                byte[] fileData = File.ReadAllBytes(filePath);

                // Perform the find and replace operation
                int lastIndex = 0;
                while ((lastIndex = FindNextOccurrence(fileData, searchBytes, lastIndex)) != -1)
                {
                    ReplaceBytes(ref fileData, lastIndex, searchBytes.Length, replaceBytes);
                    lastIndex += replaceBytes.Length;
                }

                // Write the modified data back to the file
                File.WriteAllBytes(filePath, fileData);

                Console.WriteLine("Find and replace completed successfully.");
                return 0;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while editing the file.", ex);
            }
        }

        private static int FindNextOccurrence(byte[] source, byte[] search, int startIndex)
        {
            for (int i = startIndex; i < source.Length - search.Length + 1; i++)
            {
                bool found = true;
                for (int j = 0; j < search.Length; j++)
                {
                    if (source[i + j] != search[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                    return i;
            }
            return -1;
        }

        private static void ReplaceBytes(ref byte[] source, int startIndex, int length, byte[] replaceBytes)
        {
            for (int i = 0; i < length; i++)
            {
                source[startIndex + i] = replaceBytes[i];
            }
        }

        private static byte[] StringToByteArray(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            int len = hexString.Length;
            byte[] byteArray = new byte[len / 2];
            for (int i = 0; i < len; i += 2)
            {
                byteArray[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }
            return byteArray;
        }
    }
}
