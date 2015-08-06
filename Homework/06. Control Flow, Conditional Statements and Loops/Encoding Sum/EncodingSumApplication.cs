namespace Encoding_Sum
{
    using System;

    public class EncodingSumApplication
    {
        public static void Main()
        {
            decimal moduleByM = decimal.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            decimal result = 0m;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '@')
                    break;
                if (char.IsDigit(text[i]))
                {    
                    int parsedCharToInt = 0;
                    if (int.TryParse(text[i].ToString(), out parsedCharToInt))
                    {
                        result *= parsedCharToInt;
                    }
                }
                else
                    if (char.IsLetter(text[i]))
                    {
                        int k = (int)(text[i].ToString().ToUpper())[0];
                        int rez = k - 65;
                        result += rez;
                    }
                    else
                    {
                        result %= moduleByM;

                    }
            }
            Console.WriteLine(result);

        }
    }
}
