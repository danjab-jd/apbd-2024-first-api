using WebApplication1.Enums;

namespace WebApplication1.Models;

public class Animal
{
    public int Id { get; }
    
    public string Name { get; }
    
    public AnimalCategory Category { get; }
    
    public double Weight { get; }
    
    public string Color { get; }

    public Animal(
        int id,
        string name,
        AnimalCategory category,
        double weight,
        string color)
    {
        Id = id;
        Name = name;
        Category = category;
        Weight = weight;
        Color = color;
    }
}