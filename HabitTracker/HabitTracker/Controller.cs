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

        for (int i = 0; i < Habits.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Habits[i]}");
        }
        
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    internal void AddToHabits(Habit habit)
    {
        Habits.Add(habit);
    }

    internal void DeleteHabit()
    {
        Console.Clear();
        
        Console.WriteLine("Which habit do you want to update?");
        PrintHabits();
        Console.Write($"Please enter an which habit you want to delete (1 - {Habits.Count}): ");
        
        int indexToDelete = Helpers.GetValidNumber(1, Habits.Count);
        indexToDelete--;
        
        Habits.RemoveAt(indexToDelete);
        
        Console.Clear();
        Console.WriteLine($"Habit {++indexToDelete} deleted\n");
        Console.WriteLine("All habits:");
        PrintHabits();
    }

    internal void UpdateHabit()
    {
        Console.Clear();
        
        Console.WriteLine("Which habit do you want to update?");
        PrintHabits();
        Console.Write($"Please enter an which habit you want to update (1 - {Habits.Count}): ");
        
        int indexToUpdate = Helpers.GetValidNumber(1, Habits.Count);

        // Convert to 0 based index
        indexToUpdate--;
        
        Habit h = new();
        
        Habits[indexToUpdate].Name = h.Name;
        Habits[indexToUpdate].Date = h.Date;
        Habits[indexToUpdate].Quantity = h.Quantity;
        
        Console.Clear();
        Console.WriteLine($"Habit {++indexToUpdate} updated: {h}\n");
        Console.WriteLine("All habits:");
        PrintHabits();
        
    }
}