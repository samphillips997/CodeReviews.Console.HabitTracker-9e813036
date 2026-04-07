namespace HabitTracker;

internal class Menu
{
    internal static void ShowMainMenu()
    {
        while (true)
        {
            switch (MainMenu())
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    return;
            }
        }
    }
    
    internal static int MainMenu()
    {
        Console.Clear();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("-- Habit Tracker: Glasses of Water --");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Track glass(es) of water!");
        Console.WriteLine("2. View recent water intake");
        Console.WriteLine("3. Update recent water intake");
        Console.WriteLine("4. Delete recent water intake");
        Console.WriteLine("5. Exit");
        return ValidateUserInputMenu(1, 5);
    }
    
    internal static int ValidateUserInputMenu(int lower, int upper)
    {
        int userInput = 0;
        bool success = int.TryParse(Console.ReadLine(), out userInput);
        if (!success || (userInput < lower || userInput > upper))
        {
            do
            {
                Console.WriteLine("Please enter a valid option");
                success = int.TryParse(Console.ReadLine(), out userInput);
            } while (!success);
        }

        return userInput;
    }
}