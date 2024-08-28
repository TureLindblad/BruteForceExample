using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForceExample
{
    public class Hacker
    {
        public static bool Hack(string password)
        {
            String current = "";

            int[] pos = { 0, 0, 0, 0, 0, 0 };

            String[] alphabet = { "", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "å", "ä", "ö" };

            int count = 0;

            while (current != password)
            {
                if (count >= 10)
                {
                    return false;
                }

                for (int i = 0; i < pos.Length; i++)
                {
                    if (pos[i] == alphabet.Length)
                    {
                        pos[i] = 0;
                        pos[i + 1]++;
                    }
                }

                current = (alphabet[pos[5]] + alphabet[pos[4]] + alphabet[pos[3]] + alphabet[pos[2]] + alphabet[pos[1]] + alphabet[pos[0]]).ToString();

                Console.WriteLine(current);
                pos[0]++;
                count++;
            }

            Console.WriteLine($"Hittat password: {current}");
            return true;
        }
    }
}
