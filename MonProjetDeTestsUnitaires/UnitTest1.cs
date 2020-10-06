using Linq;
using System;
using Xunit;

namespace MonProjetDeTestsUnitaires
{
    public class IsMajorShould
    {
        [Fact]
        public void ReturnTrueWhen20()
        {
            Student student = new Student { Age = 20 };
            Assert.True(student.IsMajor());
        }

        [Fact]
        public void ReturnFalseWhen10()
        {
            Student student = new Student { Age = 10 };
            Assert.False(student.IsMajor());
        }
    }
}
