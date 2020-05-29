using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Trail
{
    public class TrailDetail
    {
        [Display(Name ="Trail Id")]
        public int TrailId { get; set; }
        [Display(Name = "Park Id")]
        public int ParkId { get; set; }
        [Display(Name = "Trail Name")]
        public string TrailName { get; set; }
        [Display(Name = "Length")]
        public double TrailLength { get; set; }
        [Display(Name = "Type")]
        public string TrailType { get; set; }
        [Display(Name = "Trail Description")]
        public string TrailDescription { get; set; }
    }
}
