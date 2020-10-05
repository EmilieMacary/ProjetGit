using System;
using System.Threading;

namespace ProjetGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal("Chat");
            Dog myDog = new Dog("chien") { BirthDate = new DateTime(2020, 02, 06) };
            myDog.Masters.Add("Jeremy Richard");
            myDog.Masters.Remove("Famille Dupont");
            myDog.Masters.RemoveAt(0);

            DateTime first = DateTime.Now;
            Thread.Sleep(500);
            DateTime second = DateTime.Now;
            var difference = second - first;

            DateTime? maDateNullable = null;
            if (maDateNullable == null)
            {
                Console.WriteLine("La valeur de la date est nulle");
            }

            var variable = myDog.MonExtension();
            double pi = Math.PI;
            var nombreArrondi = pi.Round();
            Math.Round(pi);

            double otherNumber = Math.E;
            double tata = pi.SumAndRound(otherNumber);
            double tata2 = pi.Sum(otherNumber).Round();


        }
    }
}
