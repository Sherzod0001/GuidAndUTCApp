using System;

namespace MyGuidGenerator
{
    public class GuidGenerator
    {
        public void GenerateGuid()
        {

            ShowWelcomeMessage();

            string yesOrNo = "";
            do
            {
                string StringGenerationGuid = Guid.NewGuid().ToString();

                Console.WriteLine($"New Guid: {StringGenerationGuid}");
                TextCopy.ClipboardService.SetText(StringGenerationGuid);
                Console.WriteLine("Copied....\n");

                
                Console.WriteLine("Do you want to continue? (yes / no)");
                yesOrNo = Console.ReadLine();
                Console.WriteLine();

            } while (yesOrNo.ToLower() == "yes" | yesOrNo.ToLower() == "y");

            Console.WriteLine("Thank you for using our program");
            
        }

        static void ShowWelcomeMessage()
        {
            Console.WriteLine("Welcome to the project GUID Generator!!!");
            Console.WriteLine("Each time you type 'yes' or 'y', a new GUID is generated and copied to your clipboard\n");
        }
    }

    }

