namespace WebApplication1.DTO;

public record AppointmentDTO(int Id, DateTime Date, int AnimalId, double Price)
{
    public string? Description { get; init; }

    public void Deconstruct(out int id, out DateTime date, out int animalId, out double price, out string? description)
    {
        id = Id;
        date = Date;
        animalId = AnimalId;
        price = Price;
        description = Description;
    }
}