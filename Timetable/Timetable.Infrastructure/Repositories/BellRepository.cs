﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.DataAccess.Interfaces;
using TimetableApp.DataAccess.Entities;

namespace TimetableApp.DataAccess.Repositories
{
    public class BellRepository : IRepository<Bell>
    {
        private TimetableContext db;

        public BellRepository(TimetableContext context)
        {
            this.db = context;
        }

        public IEnumerable<Bell> GetAll()
        {
            return db.Bells;
        }

        public Bell Get(int id)
        {
            return db.Bells.Find(id);
        }

        public void Create(Bell bell)
        {
            db.Bells.Add(bell);
        }
        public void Update(Bell bell)
        {
            db.Bells.Update(bell);
        }
        public IEnumerable<Bell> Find(Func<Bell, Boolean> predicate)
        {
            return db.Bells.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Bell bell = db.Bells.Find(id);
            if (bell != null)
                db.Bells.Remove(bell);
        }
    }
}