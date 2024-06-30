using System;
using TextCopy;

namespace MyUtcNow
{
    public class DateFinder
    {
        public void FindUtcNow()
        {
            ShowWelcomeMessage();

            string yesOrNo = "";
            do
            {
                DateTime utcNow = DateTime.UtcNow;
                string utcNowString = utcNow.ToString("yyyy-MM-dd HH:mm:ss");

                Console.WriteLine("UTC now : " + utcNowString);

                try
                {
                    ClipboardService.SetText(utcNowString);
                    Console.WriteLine("UTC copied in your clipboard ! ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error copying to clipboard: " + ex.Message);
                }

                Console.WriteLine("Type 'yes' or 'y' to continue, otherwise the program will exit:");
                yesOrNo = Console.ReadLine();

            } while (yesOrNo.ToLower() == "yes" || yesOrNo.ToLower() == "y");

            Console.WriteLine("Thank you for using our program");
            Console.ReadKey();
        }

        static void ShowWelcomeMessage()
        {
            Console.WriteLine("Welcome to the project finder UTC !!!");
            Console.WriteLine("Each time you type 'yes' or 'y', a new UTC will be copied to your clipboard\n");
        }
    }
}
