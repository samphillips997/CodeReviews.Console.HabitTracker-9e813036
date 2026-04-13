namespace HabitTracker;

using Models;

public class Helpers
{
    internal static int ValidateUserInputMenu(int lower, int upper)
    {
        int userInput = 0;
        bool success = int.TryParse(Console.ReadLine(), out userInput);
        
        if ( (userInput < lower || userInput > upper) || !success)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid option");
                ShowMainMenu();
                
                // check if valid int and within bounds
                success = int.TryParse(Console.ReadLine(), out userInput) && (userInput >= lower && userInput <= upper);
                
            } while (!success);
        }

        return userInput;
    }
    
    internal static void ShowMainMenu()
    {
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
    }
}