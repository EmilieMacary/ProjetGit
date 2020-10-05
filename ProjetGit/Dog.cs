using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetGit
{
    class Dog: Animal
    {
        public List<string> Masters;
        public DateTime[] tableauVacinations;

        public Dog (string name):base(name)
        {
            Domestic = true;
            Masters = new List<string>()
            {
                "Famille Dupont", "Monsieur Gerard", "Carole Henry"
            };
            tableauVacinations = new DateTime[10];
            tableauVacinations[0] = new DateTime(2018, 10, 24, 13, 15, 0);

        }
    }
}
