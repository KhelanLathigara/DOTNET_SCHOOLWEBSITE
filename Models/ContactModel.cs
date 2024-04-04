using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mayur_education.Models
{
    public class ContactModel
    {

        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string Message { get; set; }

    }
}
