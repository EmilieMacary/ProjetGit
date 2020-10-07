using System;
using System.ComponentModel.DataAnnotations;

namespace DecouverteEntityFrameworkCodeFirst
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ItemId { get; set; }

        public int ItemNumber { get; set; }

        public float ItemUnitPrice { get; set; }


        public virtual Order Order { get; set; }
        public virtual Item Item { get; set; }
    }
}
