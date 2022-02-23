using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird1 = new Bird();
            bird1.NumberOfLegs = 2;
            bird1.Size = "small";
            bird1.SkinType = "feathers";
            bird1.DoesLayEggs = true;
            bird1.IsBirdOfPrey = false;
            bird1.CanFly = true;
            bird1.DoesMigrate = true;
            bird1.IsDomesticated = false;

            Console.WriteLine($"This bird has {bird1.NumberOfLegs} legs.");
            Console.WriteLine($"This bird is {bird1.Size}.");
            Console.WriteLine($"This bird has {bird1.SkinType}.");
            Console.WriteLine($"Does this animal lay eggs? {bird1.DoesLayEggs}.");
            Console.WriteLine($"Is this bird a bird of prey? {bird1.IsBirdOfPrey}.");
            Console.WriteLine($"Can this bird fly? {bird1.CanFly}.");
            Console.WriteLine($"Does this bird migrate? {bird1.DoesMigrate}.");
            Console.WriteLine($"Is this bird domesticated? {bird1.IsDomesticated}.");
            Console.WriteLine();

            Reptile reptile1 = new Reptile();
            reptile1.NumberOfLegs = 4;
            reptile1.Size = "Large";
            reptile1.SkinType = "Scales";
            reptile1.DoesLayEggs = true;
            reptile1.DoesHibernate = false;
            reptile1.IsAquatic = true;
            reptile1.IsCarnivore = true;
            reptile1.Region = "North America";

            Console.WriteLine($"This Reptile has {reptile1.NumberOfLegs} legs.");
            Console.WriteLine($"This Reptile is {reptile1.Size}.");
            Console.WriteLine($"This Reptile has {reptile1.SkinType}.");
            Console.WriteLine($"Does this animal lay eggs? {reptile1.DoesLayEggs}.");
            Console.WriteLine($"Does this reptile hibernate? {reptile1.DoesHibernate}.");
            Console.WriteLine($"Is this reptile aquatic? {reptile1.IsAquatic}.");
            Console.WriteLine($"Is this reptile a carnavore? {reptile1.IsCarnivore}.");
            Console.WriteLine($"What region does this reptile live in? {reptile1.Region}.");

            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
