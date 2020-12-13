using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestValidation
{
    public class Customer
    {
        [Required]
        [Range(1, 10000)]
        public int CustomerId { get; set; }
        [Required, RegularExpression(@"^.*[a-zA-Z]", ErrorMessage = "Please enter a valid First Name.")]
        public string FirstName { get; set; }
        [Required, RegularExpression(@"^.*[a-zA-Z]", ErrorMessage = "Please enter a valid Last Name.")]
        public string LastName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
