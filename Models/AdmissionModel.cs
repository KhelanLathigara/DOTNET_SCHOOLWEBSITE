using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mayur_education.Models
{
    public class AdmissionModel
    {

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string MotherName { get; set; }
        public required string FatherName { get; set; }
        public required string Address { get; set; }
        public required string PinCode { get; set; }
        public required string Gender { get; set; }
        public required string DOB { get; set; }
        public required string Course { get; set; }
        public required string Email { get; set; }

    }
}
