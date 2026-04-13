namespace HabitTracker;

internal class Menu
{
    internal static void MainMenu()
    {
        Controller controller = new Controller();
        
        while (true)
        {
            Console.Clear();
            Helpers.ShowMainMenu();
            int userInput = Helpers.ValidateUserInputMenu(1, 5);
            
            switch (userInput)
            {
                case 1:
                    break;
                case 2:
                    controller.PrintHabits();
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
}