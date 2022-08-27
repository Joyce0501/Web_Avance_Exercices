using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    internal class Country
    {
        [StringLength(50)]
        public String Name { get; set; }
    }
}
