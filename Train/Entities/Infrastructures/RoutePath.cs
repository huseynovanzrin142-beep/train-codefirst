using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Train.Entities;

public class RoutePath
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("RouteId")]
    public int RouteId { get; set; }
    [ForeignKey("TrackSegmentId")]
    public int TrackSegmentId { get; set; }
    [Required]

    public virtual Route? Route { get; set; }
    [Required]
    public virtual TrackSegment? TrackSegment { get; set; }
}
