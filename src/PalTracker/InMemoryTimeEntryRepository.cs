using System;
using System.Collections.Generic;

namespace PalTracker
{
    public class InMemoryTimeEntryRepository : ITimeEntryRepository
    {
        private readonly IDictionary<long, TimeEntry> timeEntryList=new Dictionary<long, TimeEntry>();
        public TimeEntry Create(TimeEntry timeEntry)
        {
            long id = timeEntryList.Count+1;
            timeEntry.Id=id;
            timeEntryList.Add(id,timeEntry);
            return timeEntry;
            
        }

        public TimeEntry Find(long id)
        {
           return timeEntryList[id];
           
          
        }

        public bool Contains(long id)
        {
            return timeEntryList.ContainsKey(id);
        }

        public IEnumerable<TimeEntry> List()
        {
           return timeEntryList.Values;
        }

public TimeEntry Update(long id, TimeEntry timeEntry)
        {
            timeEntry.Id = id;

            timeEntryList[id] = timeEntry;

            return timeEntry;
        }
        public void Delete(long id)
        {
            timeEntryList.Remove(id);
        }
    }
}