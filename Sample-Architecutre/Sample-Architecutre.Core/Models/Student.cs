using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Architecutre.Core.Models
{
    //[Table("Student")]
    public class Student : BaseEntity
    {
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(12)]
        public string PhoneNumber { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [NotMapped]
        public string Email { get; set; }
    }
}
