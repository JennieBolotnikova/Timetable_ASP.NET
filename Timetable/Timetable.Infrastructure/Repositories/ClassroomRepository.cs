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
    public class ClassroomRepository : IRepository<Classroom>
    {
        private TimetableContext db;

        public ClassroomRepository(DbContextOptions<TimetableContext> options)
        {
            this.db = new TimetableContext(options);
        }

        public IEnumerable<Classroom> GetAll()
        {
            return db.Classrooms;
        }

        public Classroom Get(int id)
        {
            return db.Classrooms.Find(id);
        }

        public void Create(Classroom classroom)
        {
            db.Classrooms.Add(classroom);
            db.SaveChanges();
        }
        public void Update(Classroom classroom)
        {
            db.Classrooms.Update(classroom);
            db.SaveChanges();
        }
        public IEnumerable<Classroom> Find(Func<Classroom, Boolean> predicate)
        {
            return db.Classrooms.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Classroom classroom = db.Classrooms.Find(id);
            if (classroom != null)
                db.Classrooms.Remove(classroom);
            db.SaveChanges();
        }
    }
}
