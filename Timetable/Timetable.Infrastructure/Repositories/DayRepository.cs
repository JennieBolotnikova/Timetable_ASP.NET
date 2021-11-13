using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.DataAccess.Interfaces;
using TimetableApp.DataAccess.Entities;

namespace TimetableApp.DataAccess.Repositories
{
    public class DayRepository : IRepository<Day>
    {
        private TimetableContext db;

        public DayRepository(TimetableContext context)
        {
            this.db = context;
        }

        public IEnumerable<Day> GetAll()
        {
            return db.Days;
        }

        public Day Get(int id)
        {
            return db.Days.Find(id);
        }

        public void Create(Day day)
        {
            db.Days.Add(day);
        }
        public void Update(Day day)
        {
            db.Days.Update(day);
        }
        public IEnumerable<Day> Find(Func<Day, Boolean> predicate)
        {
            return db.Days.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Day day = db.Days.Find(id);
            if (day != null)
                db.Days.Remove(day);
        }
    }
}
