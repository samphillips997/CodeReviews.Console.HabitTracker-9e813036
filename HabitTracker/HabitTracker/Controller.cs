namespace HabitTracker;

using Models;

internal class Controller
{
    internal List<Habit> Habits = new()
    {
        new Habit("Glasses of water", DateTime.Now, 5),
        new Habit("Glasses of water", DateTime.Now.AddDays(1), 5),
        new Habit("Glasses of water", DateTime.Now.AddDays(2), 5),
        new Habit("Glasses of water", DateTime.Now.AddDays(3), 5),
        new Habit("Glasses of water", DateTime.Now.AddDays(4), 5),
    };
    

    internal void TrackHabit(string name, DateTime date, int quantity)
    {
        Habits.Add(new Habit(name, date, quantity));
    }
    
    internal void PrintHabits()
    {
        Console.Clear();
        foreach (Habit h in Habits)
        {
            Console.WriteLine($"{h.Date}: {h.Quantity} {h.Name}");
        }
        
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}