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
        public (int,bool) IsMajor()
        {
            if (Age > 18)
                return (ID, true);
            else
                return (ID, false);
        }
    }
}
