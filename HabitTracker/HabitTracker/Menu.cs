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
            int userInput = Helpers.GetValidNumber(1, 5);
            
            switch (userInput)
            {
                case 1:
                    controller.TrackHabit();
                    break;
                case 2:
                    Console.Clear();
                    controller.PrintHabits();
                    break;
                case 3:
                    controller.UpdateHabit();
                    break;
                case 4:
                    controller.DeleteHabit();
                    break;
                case 5:
                    return;
            }
        }
    }
}