using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Train.Entities
{
    public class TrackSegment
    {
        [Key]
        public int Id { get; set; }
        public SwitchDirection SwitchDirection { get; set; }
        public bool IsOccupied { get; set; }
        [ForeignKey("WaitPointId")]
        public int WaitPointId { get; set; }
        [Required]
        public virtual WaitPoint? WaitPoint { get; set; }

        public virtual ICollection<RoutePath>? RoutePaths { get; set; }
    }

    public enum SwitchDirection
    {
        Straight, 
        Left,     
        Right
    }
}
