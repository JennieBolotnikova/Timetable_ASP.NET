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
            return db.Timetables.Include(a => a.ActivityType).Include(b => b.Bell).Include(d => d.Discipline)
                .Include(d => d.Day).Include(g => g.Group).ThenInclude(f => f.Faculty).Include(t => t.Teacher)
                .Include(s => s.Semester).Include(c => c.Classroom).ThenInclude(t => t.ClassroomType).AsEnumerable();
        }

        public Timetable Get(int id)
        {
            return db.Timetables.Include(a => a.ActivityType).Include(b => b.Bell).Include(d => d.Discipline)
                .Include(d => d.Day).Include(g => g.Group).ThenInclude(f => f.Faculty).Include(t => t.Teacher)
                .Include(s => s.Semester).Include(c => c.Classroom).ThenInclude(t => t.ClassroomType).AsEnumerable()
                .First(t => t.ID == id);
        }

        public void Create(Timetable timetable)
        {
            db.Timetables.Add(timetable);
            db.SaveChanges();
        }
        public void Update(Timetable timetable)
        {
            db.Timetables.Update(timetable);
            db.SaveChanges();
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
