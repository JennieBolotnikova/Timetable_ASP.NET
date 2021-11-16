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
    public class SemesterRepository : IRepository<Semester>
    {
        private TimetableContext db;

        public SemesterRepository(DbContextOptions<TimetableContext> options)
        {
            this.db = new TimetableContext(options);
        }

        public IEnumerable<Semester> GetAll()
        {
            return db.Semesters;
        }

        public Semester Get(int id)
        {
            return db.Semesters.Find(id);
        }

        public void Create(Semester semester)
        {
            db.Semesters.Add(semester);
        }
        public void Update(Semester semester)
        {
            db.Semesters.Update(semester);
        }
        public IEnumerable<Semester> Find(Func<Semester, Boolean> predicate)
        {
            return db.Semesters.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Semester semester = db.Semesters.Find(id);
            if (semester != null)
                db.Semesters.Remove(semester);
        }
    }
}
