using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.DataAccess.Entities;
using TimetableApp.DataAccess.Interfaces;

namespace TimetableApp.DataAccess.Repositories
{
    public class DisciplineRepository : IRepository<Discipline>
    {
        private TimetableContext db;

        public DisciplineRepository(TimetableContext context)
        {
            this.db = context;
        }

        public IEnumerable<Discipline> GetAll()
        {
            return db.Disciplines;
        }

        public Discipline Get(int id)
        {
            return db.Disciplines.Find(id);
        }

        public void Create(Discipline d)
        {
            db.Disciplines.Add(d);
        }
        public void Update(Discipline d)
        {
            db.Disciplines.Update(d);
        }
        public IEnumerable<Discipline> Find(Func<Discipline, Boolean> predicate)
        {
            return db.Disciplines.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Discipline d = db.Disciplines.Find(id);
            if (d != null)
                db.Disciplines.Remove(d);
            db.SaveChanges();
        }
    }
}
