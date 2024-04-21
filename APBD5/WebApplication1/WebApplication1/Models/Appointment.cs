namespace WebApplication1.Models;

public class Appointment
{
    public int Id { get; }
    
    public DateTime Date { get; set; }
    
    public Animal Animal { get; set; }
    
    public string? Description { get; set; }
    
    public double Price { get; set; }

    public Appointment(int id, DateTime date, Animal animal, double price)
    {
        Id = id;
        Date = date;
        Animal = animal;
        Price = price;
    }

    public void Deconstruct(out int id, out DateTime date, out Animal animal, out double price, out string? description)
    {
        id = Id;
        date = Date;
        animal = Animal;
        description = Description;
        price = Price;
    }
}