using WebApplication1.Enums;

namespace WebApplication1.DTO;

public record AnimalDTO(int Id, string Name, AnimalCategory Category, double Weight, string Color);