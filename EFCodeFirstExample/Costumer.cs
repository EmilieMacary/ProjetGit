using System;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstExample
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        [MaxLength(30)]
        public string City { get; set; }

        public DateTime? BirthDay { get; set; }
    }
}
