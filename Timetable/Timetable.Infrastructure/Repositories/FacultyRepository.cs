using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.DataAccess.Entities;
using TimetableApp.DataAccess.Interfaces;

namespace TimetableApp.DataAccess.Repositories
{
    public class FacultyRepository : IRepository<Faculty>
    {
        private TimetableContext db;

        public FacultyRepository(TimetableContext context)
        {
            this.db = context;
        }

        public IEnumerable<Faculty> GetAll()
        {
            return db.Faculties;
        }

        public Faculty Get(int id)
        {
            return db.Faculties.Find(id);
        }

        public void Create(Faculty faculty)
        {
            db.Faculties.Add(faculty);
        }
        public void Update(Faculty faculty)
        {
            db.Faculties.Update(faculty);
        }
        public IEnumerable<Faculty> Find(Func<Faculty, Boolean> predicate)
        {
            return db.Faculties.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Faculty faculty = db.Faculties.Find(id);
            if (faculty != null)
                db.Faculties.Remove(faculty);
        }
    }
}
