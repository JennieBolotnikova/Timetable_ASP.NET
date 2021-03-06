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
    public class TeacherRepository : IRepository<Teacher>
    {
        private TimetableContext db;

        public TeacherRepository(DbContextOptions<TimetableContext> options)
        {
            this.db = new TimetableContext(options);
        }

        public IEnumerable<Teacher> GetAll()
        {
            return db.Teachers;
        }

        public Teacher Get(int id)
        {
            return db.Teachers.Find(id);
        }

        public void Create(Teacher teacher)
        {
            db.Teachers.Add(teacher);
            db.SaveChanges();
        }
        public void Update(Teacher teacher)
        {
            db.Teachers.Update(teacher);
            db.SaveChanges();
        }
        public IEnumerable<Teacher> Find(Func<Teacher, Boolean> predicate)
        {
            return db.Teachers.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Teacher teacher = db.Teachers.Find(id);
            if (teacher != null)
                db.Teachers.Remove(teacher);
            db.SaveChanges();
        }
    }
}
