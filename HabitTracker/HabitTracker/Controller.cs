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
    

    internal void TrackHabit()
    {
        Habit h = new();
        
        AddToHabits(h);
        Console.WriteLine($"Habit added:\n\t{h}");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    
    internal void PrintHabits()
    {
        Console.Clear();
        foreach (Habit h in Habits)
        {
            Console.WriteLine(h);
        }
        
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    internal void AddToHabits(Habit habit)
    {
        Habits.Add(habit);
    }
}