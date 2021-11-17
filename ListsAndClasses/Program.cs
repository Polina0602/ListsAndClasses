using System;
using System.Collections.Generic;
using ListsAndClasses.Classes;

namespace ListsAndClasses
{


    class Program
    {
        static void Main(string[] args)
        {

            Animals PetOfTali = new Animals();
            PetOfTali.AnimalName = "Joy";
            PetOfTali.AnimalType = "Dog";
            PetOfTali.AnimalTail = true;
            Console.WriteLine($"Tali has a pet. Her name is {PetOfTali.AnimalName}. She is a { PetOfTali.AnimalType}. She has { PetOfTali.Paws} paws.");
            PetOfTali.RunByPaws();
            Console.WriteLine();

           

            List<Animals> animals = new List<Animals>();
            animals.Add(new Animals() { AnimalName = "Tom", AnimalType = "Dog", AnimalTail = true });
            animals.Add(new Animals() { AnimalName = "Bu", AnimalType = "Cat", AnimalTail = true });
            animals.Add(new Animals() { AnimalName = "Sharik", AnimalType = "Wolf", AnimalTail = false });
            animals.Add(new Animals() { AnimalName = "Jack", AnimalType = "Beast", AnimalTail = true });



            foreach (var animal in animals)
            {
                Console.Write(animal.AnimalName);
                Console.Write("---");
                Console.Write(animal.AnimalType);
                Console.Write("     ");
                Console.Write("Paws");
                Console.Write(" - ");
                Console.Write(animal.Paws);
                Console.Write("     ");
                IfTale(animal.AnimalTail);
                Console.WriteLine();
            }
        }
        static void IfTale(bool AnimalTail)
        {

            if (AnimalTail)
            {
                Console.WriteLine("There is a tail!");
            }
            else
            {
                Console.WriteLine("No tail((");
            }
        }
    }






}

