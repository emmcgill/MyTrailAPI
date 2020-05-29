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
        [Display(Name ="Park Id")]
        public int ParkId { get; set; }

        [Display(Name ="Park Name")]
        public string ParkName { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public int YearEstablished { get; set; }

        [Display(Name="Park Description")]
        public string ParkDescription { get; set; }
    }
}
