using WebApplication1.DTO;
using WebApplication1.Enums;
using WebApplication1.Models;
using WebApplication1.Services.Data;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Services.Implementations;

internal class AnimalsService : IAnimalsService
{
    public IList<Animal> GetAnimals()
    {
        return MockedDb.Animals;
    }

    public Animal GetAnimal(int id)
    {
        Animal foundAnimal = null;

        foreach (Animal animal in MockedDb.Animals)
        {
            if (animal.Id == id)
            {
                foundAnimal = animal;
            }
        }

        if (foundAnimal == null)
        {
            throw new Exception("Animal with given ID not found.");
        }

        return foundAnimal;
    }

    public Animal AddAnimal(AnimalDTO animalDTO)
    {
        (int id, string name, AnimalCategory category, double weight, string color) = animalDTO;
        
        Animal newAnimal = new(id, name, category, weight, color);
        
        MockedDb.Animals.Add(newAnimal);

        return newAnimal;
    }

    public void DeleteAnimal(int id)
    {
        Animal animalToDelete = GetAnimal(id);
        
        MockedDb.Animals.Remove(animalToDelete);
    }
}