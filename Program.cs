using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            String usedChars = "";

            for(int i = 0;i < str.Length; i++)
            { 
                if (!usedChars.Contains(str[i]))
                {
                    Console.WriteLine(str[i] + ": " + count(str, str[i]));
                    usedChars += str[i];
                }
            }
        }

        static int count(String str, char ch)
        {
            int count = 0;
            for(int i = 0;i < str.Length; i++)
            {
                if(str[i] == ch)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
