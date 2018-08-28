using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalTracker
{
    public class InMemoryTimeEntryRepository : ITimeEntryRepository
    {
        private List<TimeEntry> repo;

        public InMemoryTimeEntryRepository()
        {
            repo = new List<TimeEntry>();
            repo.Add(new TimeEntry(1, 1001, 301, DateTime.Today.ToUniversalTime(), 40));
            repo.Add(new TimeEntry(2, 1002, 302, DateTime.Today.ToUniversalTime(), 50));
            repo.Add(new TimeEntry(3, 1003, 303, DateTime.Today.ToUniversalTime(), 60));
            repo.Add(new TimeEntry(4, 1004, 304, DateTime.Today.ToUniversalTime(), 70));

        }

        public bool Contains(long id)
        {
            var item = repo.AsQueryable<TimeEntry>().Select(x => x.Id == id);
            return (item != null);

        }

        public TimeEntry Create(TimeEntry timeEntry)
        {
            timeEntry.Id = repo.Count + 1;
            repo.Add(timeEntry);
            return timeEntry;
        }

        public void Delete(long id)
        {
            var item = repo.AsQueryable<TimeEntry>().Where(x => x.Id == id).SingleOrDefault();

            if(item != null)
            {
                repo.Remove(item);
            }
        }

        public TimeEntry Find(long id)
        {
            return repo.AsQueryable<TimeEntry>().Where(x => x.Id == id).SingleOrDefault();
        }

        public IEnumerable<TimeEntry> List()
        {
            return repo.ToList();
        }

        public TimeEntry Update(long id, TimeEntry timeEntry)
        {
            var item = repo.AsQueryable<TimeEntry>().Where(x => x.Id == id).SingleOrDefault();

            if (item != null)
            {
                timeEntry.Id = id;
                repo.Remove(item);
                repo.Add(timeEntry);
                return timeEntry;
            }
            else
                return null;
        }
    }
}
