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

}