using DecouverteEntityFrameworkCodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecouverteAspNetCore
{
    public class MonSuperViewModel
    {
        public List<Item> ListItem { get; set; }
        public int itemsNumber { get; set; }

        public List<Customer> ListCustomer { get; set; }
        public int CustomerNumber { get; set; }
    }
}
