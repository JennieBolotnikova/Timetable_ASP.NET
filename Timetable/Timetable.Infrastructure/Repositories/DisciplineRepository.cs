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
    public class DisciplineRepository : IRepository<Discipline>
    {
        private TimetableContext db;

        public DisciplineRepository(DbContextOptions<TimetableContext> options)
        {
            this.db = new TimetableContext(options);
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
            db.SaveChanges();
        }
        public void Update(Discipline d)
        {
            db.Disciplines.Update(d);
            db.SaveChanges();
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
