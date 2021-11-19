using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.DataAccess.Entities;
using TimetableApp.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TimetableApp.DataAccess.Repositories
{
    public class TimetableRepository : IRepository<Timetable>
    {
        private TimetableContext db;

        public TimetableRepository(DbContextOptions<TimetableContext> options)
        {
            this.db = new TimetableContext(options);
        }

        public IEnumerable<Timetable> GetAll()
        {
            return db.Timetables;
        }

        public Timetable Get(int id)
        {
            return db.Timetables.Find(id);
        }

        public void Create(Timetable timetable)
        {
            db.Timetables.Add(timetable);
            db.SaveChanges();
        }
        public void Update(Timetable timetable)
        {
            db.Timetables.Update(timetable);
        }
        public IEnumerable<Timetable> Find(Func<Timetable, Boolean> predicate)
        {
            return db.Timetables.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Timetable timetable = db.Timetables.Find(id);
            if (timetable != null)
                db.Timetables.Remove(timetable);
        }
    }
}
