using System;
using System.Threading;

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
            myDog.Masters.Add("Jeremy Richard");
            myDog.Masters.Remove("Famille Dupont");
            myDog.Masters.RemoveAt(0);

            DateTime first = DateTime.Now;
            Thread.Sleep(500);
            DateTime second = DateTime.Now;
            var difference = second - first;

            DateTime? maDateNullable = null;
            if(maDateNullable == null)
            {
                Console.WriteLine("La valeur de la date est nulle");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
