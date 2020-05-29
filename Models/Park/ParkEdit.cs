using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Park
{
    public class ParkEdit
    {
        public int ParkId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please Enter at least two characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field")]
        public string ParkName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please Enter at least two characters.")]
        [MaxLength(50, ErrorMessage = "There are too many characters in this field")]
        public string City { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please Enter at least two characters.")]
        [MaxLength(25, ErrorMessage = "There are too many characters in this field")]
        public string State { get; set; }

        [Required]
        [Range(1776, 2020,
        ErrorMessage = "Year established must be between 1776 and 2020.")]
        public int YearEstablished { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please Enter at least two characters.")]
        [MaxLength(2000, ErrorMessage = "There are too many characters in this field")]
        public string ParkDescription { get; set; }
    }
}
