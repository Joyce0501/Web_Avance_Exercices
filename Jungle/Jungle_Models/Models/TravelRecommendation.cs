using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    internal class TravelRecommendation
    {
        [StringLength(10)]
        public String DangerLevel { get; set; }

        [StringLength(100)]
        public String Description { get; set; }
    }
}
