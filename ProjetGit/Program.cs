using System;

namespace ProjetGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal("Chat");
            Dog myDog = new Dog("chien")
            {
                BirthDate = DateTime.Now
            };

            Console.WriteLine("Hello World!");
        }
    }
}
