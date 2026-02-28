using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Train.Entities
{
    public class WaitPoint
    {
        [Key]
        public int Id { get; set; }
        public double Distance { get; set; }
        public bool IsRed { get; set; }

        public virtual ICollection<TrackSegment>? TrackSegments { get; set; }
    }
}
