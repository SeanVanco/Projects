using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentManagement
{
    internal class CountingGradesInText
    {
        public static int CountofCharacters(string filePath, char targetChar)
        {
            int count = 0;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string content = reader.ReadToEnd();
                    count = CountChars(content, targetChar);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }

            return count;
        }

        private static int CountChars(string input, char targetChar)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == targetChar)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
