using coding_tracker;

public static class UserInput
{
    public static void GetInput()
    {

        bool closeApp = false;
        while (closeApp == false)
        {
            bool invalid;
            int ChosenOption;
            do
            {
                invalid = true;
                string menuInput = Console.ReadLine();
                if (int.TryParse(menuInput, out ChosenOption))
                {
                    invalid = false;
                }
                else
                {
                    Console.WriteLine("Invalid command. Please, enter number from 0 to 5.\n");
                }
            } while (invalid);

            switch (ChosenOption)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\n\n");
                    Menu.FigletMessage("Bye-Bye!");
                    Thread.Sleep(1000);
                    closeApp = true;
                    break;

                case 1:
                    Console.WriteLine("Under Construction Case1");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Under Construction Case2");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Under Construction Case3");
                    break;

                case 4:
                    Console.WriteLine("Under Construction Case4");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("Under Construction Case5");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("\nInvalid command. Please, enter number from 0 to 5\n");
                    Thread.Sleep(1500);
                    break;
            }

        }
    }
    public static int GetNumberInput(string message, int numberMinLimit, int numberMaxLimit)
    {
        Console.WriteLine(message);
        string? numberInput = Console.ReadLine();
        if (numberInput == "0") GetInput();
        while (!Int32.TryParse(numberInput, out _) || Convert.ToInt32(numberInput) <= numberMinLimit || Convert.ToInt32(numberInput) > numberMaxLimit)
        {
            Console.WriteLine("\n**Enter 0 to go to main menu**\nInvalid number. Number must be integer and no decimals allowed. Enter correct number:");
            numberInput = Console.ReadLine();
        }
        int numberInputConverted = int.Parse(numberInput);
        return numberInputConverted;
    }

}