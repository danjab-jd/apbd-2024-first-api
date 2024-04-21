using WebApplication1.DTO;
using WebApplication1.Models;

namespace WebApplication1.Services.Interfaces;

public interface IAnimalsService
{
    IList<Animal> GetAnimals();

    Animal GetAnimal(int id);

    Animal AddAnimal(AnimalDTO animalDTO);

    void DeleteAnimal(int id);
}