using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.DataAccess.Interfaces;
using TimetableApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace TimetableApp.DataAccess.Repositories
{
    public class DayRepository : IRepository<Day>
    {
        private TimetableContext db;

        public DayRepository(DbContextOptions<TimetableContext> options)
        {
            this.db = new TimetableContext(options);
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
            db.SaveChanges();
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
