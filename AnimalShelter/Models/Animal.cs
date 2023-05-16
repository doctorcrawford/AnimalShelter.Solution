using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public DateTime DOA { get; set; }
    public string Type { get; set; }
    public string Breed { get; set; }

    // public Animal(int animalId, string name, DateTime doa, string breed)
    // {
    //   AnimalId = animalId;
    //   Name = name;
    //   DOA = doa;
    //   Breed = breed;
    // }
    // public Animal(int animalId, string name, DateTime doa, string breed, string breedSub)
    // {
    //   AnimalId = animalId;
    //   Name = name;
    //   DOA = doa;
    //   Breed = breed;
    //   BreedSub = breedSub;
    // }
  }
}