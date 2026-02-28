using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Train.Entities
{
    public class Route
    {
        [Key]
        public int Id { get; set; }

        public bool IsBackward { get; set; }

        [ForeignKey("FromStationId")]
        public int FromStationId { get; set; }
        [Required]

        public virtual Station? FromStation { get; set; }

        [ForeignKey("ToStationId")]
        public int ToStationId { get; set; }
        [Required]

        public virtual Station? ToStation { get; set; }


        [ForeignKey("TimeTableId")]
        public int TimeTableId { get; set; }
        [Required]
        public virtual TimeTable? TimeTable { get; set; }


        public virtual ICollection<Trip>? Trips { get; set; }

        public virtual ICollection<RoutePath>? RoutePaths { get; set; }
    }
}
