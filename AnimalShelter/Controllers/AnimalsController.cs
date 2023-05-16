using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index ()
    {
      List<Animal> model = _db.Animals.ToList();
      List<Animal> sortedList = model.OrderBy(o=>o.Name).ToList();

      return View(sortedList);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create (Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
      return View(thisAnimal);
    }

    public ActionResult Type(string type)
    {
      List<Animal> animalType = _db.Animals.Where(animal => animal.Type == type).ToList();
      List<Animal> sortedList = animalType.OrderBy(o=>o.Name).ToList();
      return View(sortedList);
    }
  }
}