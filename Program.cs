using System;
using MyGuidGenerator;
using MyUtcNow;

namespace GuidAndUTCApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to guid generator and UTC ! ");
            Console.WriteLine("For new guid select \"1\" ");
            Console.WriteLine("For UTC now select \"2\" ");
            string userInput = Console.ReadLine();
            int value = Convert.ToInt32(userInput);

            switch (value)
            {
                case 1:
                    GuidGenerator guid = new GuidGenerator();
                    guid.GenerateGuid();
                    break;
                case 2:
                    DateFinder dateFinder = new DateFinder();
                    dateFinder.FindUtcNow();
                    break;


            }

        }
    }
}
