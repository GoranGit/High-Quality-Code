namespace Sequences_of_Bits
{
    using System;

   public class Program
    {
        public static void Main()
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());

            int maxZero = 0;
            int maxOne = 0;
            string rezString = string.Empty;
            uint p = 0;

            for (int i = 0; i < numberOfNumbers; i++)
            {
                p = uint.Parse(Console.ReadLine());
                string l = Convert.ToString(p, 2).PadLeft(30, '0');
                rezString += l;
            }

            maxOne = CountZerowsOnes(rezString, '1');
            maxZero = CountZerowsOnes(rezString, '0');
            Console.WriteLine(maxZero);
            Console.WriteLine(maxOne);
        }

        public static int CountZerowsOnes(string p, char oneOrZero)
        {
            int count = 0;
            string[] subStrings = p.Split(oneOrZero);
            for (int i = 0; i < subStrings.Length; i++)
            {
                if (subStrings[i].Length > count)
                {
                    count = subStrings[i].Length;
                }
            }

            return count;
        }
    }
}