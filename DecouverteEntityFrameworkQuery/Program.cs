using DecouverteEntityFrameworkCodeFirst;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DecouverteEntityFrameworkQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionsBuilder.UseSqlServer(@"Server=51.178.46.82,1533;Initial Catalog=FormationCSharpSQL;Persist Security Info=False;User ID=FormationCSharpSQL;Password=FormationCSharp&SQL;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Connection Timeout=30;");
            //optionsBuilder.UseSqlServer(@"Server=.\sqlexpress;Database=DecouverteEntityFrameworkCodeFirst;Trusted_Connection=True;");
            MyDbContext myDbContext = new MyDbContext(optionsBuilder.Options);

            var items = (from i in myDbContext.Items
                         select i).ToList();

            var customers = (from c in myDbContext.Customers
                             select c).ToList();


        }
    }
}
