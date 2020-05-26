using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Trail
    {
        [Key]
        public int TrailId { get; set; }

        [ForeignKey(nameof(Park))]
        public int ParkId { get; set; }
        public virtual Park Park { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public double Length { get; set; }
        [Required]
        public string TrailType { get; set; }
        public bool IsDeleted { get; set; }
    }
}
