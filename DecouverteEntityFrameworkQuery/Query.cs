using DecouverteEntityFrameworkCodeFirst;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DecouverteEntityFrameworkQuery
{
    public class Query
    {
        private MyDbContext Context { get; set; }
        public Query(MyDbContext context)
        {
            Context = context;
        }

        public List<Item> ItemsFromStore()
        {
            return (from it in Context.Items
                    select it).ToList();
        }

        public Item ItemByIdQuery(int ReadId)
        {
            return (from it in Context.Items
                    where it.Id == ReadId
                    select it).Single();
        }

        public void RemoveItemStore(Item item)
        {
            Context.Items.Remove(item);
            Context.SaveChanges();
        }
        public void AddItemInStore(Item item)
        {
            Context.Items.Add(item);
            Context.SaveChanges();
        }

        public void UpdateItemInStore(Item item)
        {
            //Context.Items.Update(item);
            Context.SaveChanges();
        }

    }
}
