namespace HabitTracker.Models;

internal class Habit
{
    internal DateTime Date { get; set; }
    internal int Quantity { get; set; }
    internal string Name { get; set; }
    
    internal Habit(string name, DateTime date, int quantity)
    {
        Date = date;
        Quantity = quantity;
        Name = name;
    }

    internal Habit()
    {
        Console.Clear();
        Console.Write("Enter Habit name: ");
        Name = Console.ReadLine();
        
        Console.Clear();
        Console.Write("Enter quantity: ");
        Quantity = int.Parse(Console.ReadLine());
        
        Console.Clear();
        Console.Write("Enter date: ");
        Date = Helpers.ParseDate(Console.ReadLine());
    }

    public override string ToString()
    {
        return $"{Date}: {Quantity} {Name}";
    }

}