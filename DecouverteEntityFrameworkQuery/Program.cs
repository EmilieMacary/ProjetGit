using DecouverteEntityFrameworkCodeFirst;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DecouverteEntityFrameworkQuery
{
    class Program
    {
        public static MyDbContext MyDbContext;
        public static Query Query;

        static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionsBuilder.UseSqlServer(@"Server=51.178.46.82,1533;Initial Catalog=FormationCSharpSQL;Persist Security Info=False;User ID=FormationCSharpSQL;Password=FormationCSharp&SQL;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Connection Timeout=30;");
            //optionsBuilder.UseSqlServer(@"Server=.\sqlexpress;Database=DecouverteEntityFrameworkCodeFirst;Trusted_Connection=True;");
            MyDbContext = new MyDbContext(optionsBuilder.Options);
            Query = new Query(MyDbContext);

            #region code commenté
            //var items = (from i in MyDbContext.Items
            //             select i).ToList();

            //var customers = (from c in MyDbContext.Customers
            //                 select c).ToList();

            //var customersOrders = (from customer in MyDbContext.Customers
            //                       join order in MyDbContext.Orders on customer.Id equals order.CustomerId
            //                       select new { customer, order }).ToList();

            //foreach (var co in customersOrders)
            //{
            //    Console.WriteLine($"Le client {co.customer.FirstName} {co.customer.Name} a fait la commande numéro {co.order.Id} à la date du {co.order.Date}");
            //}

            //var ReferenceDate = new DateTime(2020, 02, 01);
            //var customersDateOrders = (from customer in MyDbContext.Customers
            //                           join order in MyDbContext.Orders on customer.Id equals order.CustomerId
            //                           where order.Date > ReferenceDate
            //                           select new { customer, order }).ToList();

            //Console.WriteLine($"Commande passée après le {ReferenceDate}");
            //foreach (var co in customersDateOrders)
            //{
            //    Console.WriteLine($"Le client {co.customer.FirstName} {co.customer.Name} a fait la commande numéro {co.order.Id} à la date du {co.order.Date}");
            //}

            //var customersDateOrders2 = from co in customersOrders
            //                           where co.order.Date > ReferenceDate
            //                           select co;

            //Console.WriteLine($"Nouvelle methode : Commande passée après le {ReferenceDate}");
            //foreach (var coDate in customersDateOrders2)
            //{
            //    Console.WriteLine($"Le client {coDate.customer.FirstName} {coDate.customer.Name} a fait la commande numéro {coDate.order.Id} à la date du {coDate.order.Date}");
            //}

            //Item monItem = new Item { Name = "Scrabble", Description = "Jeu de lettres", Price = 27.90M };
            //Item monItem2 = new Item { Name = "Domino", Price = 15.90M };
            //Item monItem3 = new Item { Name = "Jeu de 32 cartes", Price = 27.90M };
            //List<Item> listItems = new List<Item> { monItem, monItem2, monItem3 };
            //MyDbContext.Items.AddRange(listItems);
            //MyDbContext.SaveChanges();
            #endregion

            var choix = 0;
            while (choix < 5)
            {
                Console.WriteLine("");
                Console.WriteLine("Entrez votre choix (1)créer - (2)Modifier - (3)Supprimer - (4)-Liste (Autre)Sortir");
                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        var item = AskItemToAddInStore();
                        Query.AddItemInStore(item);
                        break;

                    case 2:
                        var updateItem = AskItemToUpdateInStore();
                        Query.UpdateItemInStore(updateItem);
                        break;

                    case 3:
                        var removeItem = AskItemToRemoveFromStore();
                        Query.RemoveItemStore(removeItem);
                        break;
                    case 4:
                        var listItems = Query.ItemsFromStore();
                        ShowItems(listItems);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void ShowItems(List<Item> listItems)
        {
            foreach (var item in listItems)
            {
                Console.WriteLine($"Article : Id = {item.Id} Name = {item.Name} , Price = {item.Price}, Description = {item.Description}");
            }
        }

        private static Item AskItemToRemoveFromStore()
        {
            Console.WriteLine("Entrer l'id de l'article a supprimer:");
            int ReadId = int.Parse(Console.ReadLine());

            //Item removeItem = ItemByIdQuery(context, ReadId);
            return Query.ItemByIdQuery(ReadId);
        }





        public static Item AskItemToAddInStore()
        {
            Console.WriteLine("Rentrez le nom de votre article");
            var nomArticle = Console.ReadLine().Trim();
            Console.WriteLine("Rentrez la descrition de votre article");
            var descriptionArticle = Console.ReadLine().Trim();
            Console.WriteLine("Rentrez le prix de votre article");
            var prixArticle = decimal.Parse(Console.ReadLine().Trim());
            Item item = new Item { Name = nomArticle, Description = descriptionArticle, Price = prixArticle };
            return item;
        }



        public static Item AskItemToUpdateInStore()
        {
            Console.WriteLine("Rentrez l'ID de votre article à modifier");
            var idDeArticle = int.Parse(Console.ReadLine().Trim());

            var item = Query.ItemByIdQuery(idDeArticle);
            Console.WriteLine($"Article a modifier : Name = {item.Name} , Price = {item.Price}, Description = {item.Description}");

            Console.WriteLine("Rentrez le nouveu nom de votre article");
            item.Name = Console.ReadLine().Trim();
            Console.WriteLine("Rentrez la nouvelle descrition de votre article");
            item.Description = Console.ReadLine().Trim();
            Console.WriteLine("Rentrez le nouveu prix de votre article");
            item.Price = decimal.Parse(Console.ReadLine().Trim());
            return item;
        }
    }
}
