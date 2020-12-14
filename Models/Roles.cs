using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crm4.Models
{
    public class Roles
    {
        public int Id { get; set; }
        [RegularExpression(@"^[A-Z]+[a-z]*$"), Required]
        public string Name { get; set; }
    }
}
