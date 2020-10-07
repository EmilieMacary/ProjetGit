using System;
using System.ComponentModel.DataAnnotations;

namespace DecouverteEntityFrameworkCodeFirst
{
    public class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public DateTime Date { get; set; }

        public virtual Customer Custumer { get; set; }
    }
}
