using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sample_Architecutre.Models
{
    public class StudentModel
    {
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(12)]
        public string PhoneNumber { get; set; }

        [StringLength(200)]
        public string Address { get; set; }
        
        public string Email { get; set; }
    }
}