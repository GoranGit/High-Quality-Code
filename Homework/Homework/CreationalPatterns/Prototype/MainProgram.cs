namespace Prototype
{
    using System;

    public class MainProgram
    {
        static void Main(string[] args)
        {
            Developer dev = new Developer();
            dev.Name = "Bob";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Sue";

            Console.WriteLine(dev);
            Console.WriteLine(devCopy);
           
            Typist typist = new Typist();
            typist.Name = "John";
            typist.Role = "Doe";
            typist.WordsPerMinute = 120;

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Tim";
            typistCopy.WordsPerMinute = 115;

            Console.WriteLine(typist);
            Console.WriteLine(typistCopy);
            Console.ReadLine();
        }
    }
}
