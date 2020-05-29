using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Trail
{
    public class TrailCreate
    {
        [Required]
        public int ParkId { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Please Enter at least one character.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field")]
        public string TrailName { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Please Enter at least one character.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field")]
        public int TrailLength { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please Enter at least two character.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field")]
        public string TrailType { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please Enter at least two character.")]
        [MaxLength(1000, ErrorMessage = "There are too many characters in this field")]
        public string TrailDescription { get; set; }
    }
}
