using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Crm4.Models
{
    public class Users
    {
        public int Id { get; set; }
        [RegularExpression(@"^[A-Z]+[a-z]*$"), Display(Name = "First Name"), Required]
        public string FirstName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-z]*$"), Display(Name = "Surame"), Required]
        public string LastName { get; set; }
        [Display(Name = "Birth Date"), DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9]+[a-zA-Z0-9]*$"), StringLength(25, MinimumLength = 3), Required]
        public string Login { get; set; }

    }
}
