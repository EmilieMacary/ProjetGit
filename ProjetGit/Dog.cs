using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetGit
{
    class Dog: Animal
    {
        
        public Dog (string name):base(name)
        {
            Domestic = true;
        }
    }
}
