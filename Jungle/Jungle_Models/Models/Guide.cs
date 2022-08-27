using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    internal class Guide
    {
        [StringLength(25)]
        public String LastName { get; set; }

        [StringLength(25)]
        public String FirstName { get; set; }

        [StringLength(50)]
        public String Speciality { get; set; }
    }
}
