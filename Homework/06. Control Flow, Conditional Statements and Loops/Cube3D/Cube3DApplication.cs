namespace Cube3D
{
    using System;

    public class Cube3DApplication
    {
        public static void Main()
        {
            int dimensions = int.Parse(Console.ReadLine());

            for (int i = 0; i < dimensions; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(new string(':', dimensions));
                }
                else
                    if (i == dimensions - 1)
                    {
                        Console.WriteLine(
                            "{0}{1}{2}",
                            new string(':', dimensions), 
                            new string('|', dimensions - 2), 
                            ":");
                    }
                    else
                    {
                        Console.WriteLine(
                            "{0}{1}{0}{2}{0}", 
                            ":",
                            new string(' ', dimensions - 2), 
                            new string('|', i - 1));
                    }
            }
            for (int i = 0; i < dimensions - 1; i++)
            {
                if (i == dimensions - 2)
                {
                    Console.WriteLine(new string(' ', dimensions - 1) + new string(':', dimensions));
                }
                else
                {
                    Console.WriteLine(
                        "{0}{1}{2}{1}{3}{1}",
                        new string(' ', i + 1),
                        ":", 
                        new string('-', dimensions - 2), 
                        new string('|', dimensions - 2 - (i + 1)));
                }
            }
        }
    }
}
