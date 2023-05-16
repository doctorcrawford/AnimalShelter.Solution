using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public DateOnly DOA { get; set; }
    public string Breed { get; set; }
    public string BreedSub { get; set; }

    public Animal(int animalId, string name, DateOnly doa, string breed)
    {
      AnimalId = animalId;
      Name = name;
      DOA = doa;
      Breed = breed;
    }
    public Animal(int animalId, string name, DateOnly doa, string breed, string breedSub)
    {
      AnimalId = animalId;
      Name = name;
      DOA = doa;
      Breed = breed;
      BreedSub = breedSub;
    }
  }
}