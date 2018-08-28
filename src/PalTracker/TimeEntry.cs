using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalTracker
{
    public class TimeEntry
    {
        public long? Id { get; set; }
        public long ProjectId { get; set; }
        public long UserId { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }

        public TimeEntry(long id, long projectId, long userid, DateTime d, int hours)
        {
            Id = id;
            ProjectId = projectId;
            UserId = userid;
            Date = d;
            Hours = hours;
        }

        public TimeEntry(long projectId, long userid, DateTime d, int hours)
        {
            Id = null;
            ProjectId = projectId;
            UserId = userid;
            Date = d;
            Hours = hours;
        }
    }
}
