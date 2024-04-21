using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO;
using WebApplication1.Enums;
using WebApplication1.Models;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/animals")]
public class AnimalsController : ControllerBase
{
    private static List<Animal> _animals = new()
    {
        new Animal(1, "Aaron", AnimalCategory.Dog, 21.37, "Grey")
    };

    private readonly IAnimalsService _animalsService;

    public AnimalsController(IAnimalsService animalsService)
    {
        _animalsService = animalsService;
    }

    [HttpGet]
    public IActionResult GetAnimals()
    {
        IList<Animal> animals = _animalsService.GetAnimals();

        return Ok(animals);
        // return Ok(_animals);
    }

    [HttpPost]
    public IActionResult AddAnimal(AnimalDTO  animalDTO)
    {
        // (int id, string name, AnimalCategory category, double weight, string color) = animalDTO;
        //
        // Animal newAnimal = new(id, name, category, weight, color);
        //
        // _animals.Add(newAnimal);

        Animal newAnimal = _animalsService.AddAnimal(animalDTO);

        return Ok(newAnimal);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        // Animal animalToDelete = null;
        //
        // foreach (Animal animal in _animals)
        // {
        //     if (animal.Id == id)
        //     {
        //         animalToDelete = animal;
        //     }
        // }
        //
        // if (animalToDelete == null)
        // {
        //     return BadRequest();
        // }
        //
        // _animals.Remove(animalToDelete);
        
        _animalsService.DeleteAnimal(id);

        return NoContent();
    }
}