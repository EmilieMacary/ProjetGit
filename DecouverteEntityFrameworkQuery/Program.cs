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

            var customersOrders = (from customer in myDbContext.Customers
                                   join order in myDbContext.Orders on customer.Id equals order.CustomerId
                                   select new { customer, order }).ToList();

            foreach (var co in customersOrders)
            {
                Console.WriteLine($"Le client {co.customer.FirstName} {co.customer.Name} a fait la commande numéro {co.order.Id} à la date du {co.order.Date}");
            }

            var ReferenceDate = new DateTime(2020, 02, 01);
            var customersDateOrders = (from customer in myDbContext.Customers
                                       join order in myDbContext.Orders on customer.Id equals order.CustomerId
                                       where order.Date > ReferenceDate
                                       select new { customer, order }).ToList();

            Console.WriteLine($"Commande passée après le {ReferenceDate}");
            foreach (var co in customersDateOrders)
            {
                Console.WriteLine($"Le client {co.customer.FirstName} {co.customer.Name} a fait la commande numéro {co.order.Id} à la date du {co.order.Date}");
            }

            var customersDateOrders2 = from co in customersOrders
                                       where co.order.Date > ReferenceDate
                                       select co;

            Console.WriteLine($"Nouvelle methode : Commande passée après le {ReferenceDate}");
            foreach (var coDate in customersDateOrders2)
            {
                Console.WriteLine($"Le client {coDate.customer.FirstName} {coDate.customer.Name} a fait la commande numéro {coDate.order.Id} à la date du {coDate.order.Date}");
            }

        }
    }
}
