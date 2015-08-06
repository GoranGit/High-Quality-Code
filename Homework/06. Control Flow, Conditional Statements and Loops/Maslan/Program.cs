namespace Maslan
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            long[] sums = new long[1000000];
            BigInteger product = 1;
            int numberOfTransformations = 0;
            int pointer = 0;
            bool tenTransformationsDone = false;
            while (number.Length > 1)
            {
                while (number.Length > 0)
                {
                    number = number.Remove(number.Length - 1);
                    //// ignore the  calculation if no digts
                    if (number.Length != 0) 
                    {
                        sums[pointer] = CalcOddSum(number);
                        pointer++;
                    }
                }

                for (int i = 0; i < pointer; i++)
                {
                    if (sums[i] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        product *= (ulong)sums[i];
                    }
                }

                for (int i = 0; i < 30; i++)
                {
                    sums[i] = 0;
                }

                pointer = 0;
                numberOfTransformations++;
                number = product.ToString();
                product = 1;

                if (numberOfTransformations == 10)
                {
                    tenTransformationsDone = true;
                    break;
                }
            }

            if (!tenTransformationsDone)
            {
                Console.WriteLine(numberOfTransformations);
            }

            if (number.Length > 0)
            {
                Console.WriteLine(number);
            }
        }

        public static int CalcOddSum(string n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += int.Parse(n[i].ToString());
                }
            }

            return sum;
        }
    }
}
