using WebApplication1.Enums;
using WebApplication1.Models;

namespace WebApplication1.Services.Data;

public static class MockedDb
{
    public static IList<Animal> Animals = new List<Animal>
    {
        new (1, "Aaron", AnimalCategory.Dog, 21.37, "Grey")
    };

    public static IList<Appointment> Appointments = new List<Appointment>
    {
        new(1, DateTime.Now, Animals[0], 420)
    };
}