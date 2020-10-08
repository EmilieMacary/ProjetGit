using System.Collections.Generic;

namespace Linq
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Scores;

        public int Age { get; set; }


        //Tuple
        public (int, bool) IsMajorWithTuple()
        {
            if (Age > 18)
                return (ID, true);
            else
                return (ID, false);
        }

        public bool IsMajorOldSchool()
        {
            if (Age > 18)
                return true;
            else
                return false;
        }

        public bool IsMajor() => Age > 18;


        public string TestTernaire()
        {
            var monTest = Age > 18 ? "est majeur" : "est mineur";
            return monTest;
        }
    }
}
