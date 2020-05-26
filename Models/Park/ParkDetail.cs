using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ParkDetail
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [Display(Name="Park Description")]
        public string ParkDescription { get; set; }
    }
}
