using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Train.Entities
{
    public class TimeTable
    {
        [Key]
        public int Id { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DeptureTime { get; set; }
        public DateTime DwellTime { get; set; }
        public virtual ICollection<Trip>? Trips { get; set; }

        public virtual ICollection<Route>? Routes { get; set; }

    }
}
