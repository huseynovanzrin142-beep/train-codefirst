using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace Train.Entities
{
    public class Station
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string StationName { get; set; }
        [Required]
        [MaxLength(200)]
        public string LocationName { get; set; }
        [Required]
        public int StationCode { get; set; }
        [InverseProperty("FromStation")]
        public virtual ICollection<Route>? StartingRoutes { get; set; }

        [InverseProperty("ToStation")]
        public virtual ICollection<Route>? EndingRoutes { get; set; }
      
    }
}
