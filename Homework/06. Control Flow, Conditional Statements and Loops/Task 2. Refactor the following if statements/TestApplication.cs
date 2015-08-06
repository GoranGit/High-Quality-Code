namespace Task_2.Refactor_the_following_if_statements
{
    using System;
    using Task_1.Class_Chef_in_CSharp;

    public class TestApplication
    {
        public const int MIN_X = 50;
        public const int MAX_X = 150;
        public const int MIN_Y = 40;
        public const int MAX_Y = 200;

        public static void Main(string[] args)
        {
            Potato potato = new Potato();
            potato.IsPilled = true;
            CookPotato(potato);


            if (CheckCellVisitable(60, 100, true))
            {
                VisitCell();
            }
            else
            {
                Console.WriteLine("Cell can't be  visited!");
            }
        }

        public static bool CheckCellVisitable(int x, int y, bool shouldVisitCell)
        {
            if (
                (MIN_X <= x && x <= MAX_X) &&
                (MIN_Y <= y && y <= MAX_Y) &&
                shouldVisitCell)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void VisitCell()
        {
            Console.WriteLine("Cell visited!");
        }

        public static void CookPotato(Potato potato)
        {
            if (potato != null)
            {
                if (potato.IsPilled && !potato.IsRotten)
                {
                    Cook(potato);
                }
                else
                {
                    Console.WriteLine("Potato can't be  cooked!");
                }
            }
            else
            {
                Console.WriteLine("Potato is null!");
            }
        }

        public static void Cook(Potato potato)
        {
            Console.WriteLine("Potato has been cooked!");
        }
    }
}
