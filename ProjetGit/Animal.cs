using System;

namespace ProjetGit
{
    public class Animal
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int NbrLeg { get; set; }
        public double Weight { get; set; }

        public bool CanSwing { get; set; }

        public bool Domestic { get; set; }
        public Animal(String name)
        {
            Name = name;
        }
    }
}
