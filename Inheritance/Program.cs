using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
        Birds Birds = new Birds(); 
            Birds.Wings = true;
            Birds.hasFeather = true;
            Birds.layEggs = true;
            Birds.beak = true;
            
            Console.WriteLine($"All Birds have Wings: {Birds.Wings}\nAll Birds have Feathers: {Birds.hasFeather}\nAll Birds have a Beak: {Birds.beak}\nAll Birds lay Eggs: {Birds.layEggs}");
            Console.WriteLine("------------------------------------------------------");

        Reptiles reptiles = new Reptiles();
            reptiles.hasVertebrates = true;
            reptiles.haveAtLeastOneLung = true;
            reptiles.hasScales = true;
            reptiles.isColdBlooded = true;

            Console.WriteLine($"All reptiles have vertebrates: {reptiles.hasVertebrates}\nAll reptiles have at least one lung: {reptiles.haveAtLeastOneLung}\nAll reptiles have scales: {reptiles.hasScales}\nAll reptiles are cold blooded: {reptiles.isColdBlooded}");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Have a sssssplendid day!!!");
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
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
