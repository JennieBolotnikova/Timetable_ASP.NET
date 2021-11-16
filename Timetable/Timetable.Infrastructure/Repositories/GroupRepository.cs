﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.DataAccess.Entities;
using TimetableApp.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TimetableApp.DataAccess.Repositories
{
    public class GroupRepository : IRepository<Group>
    {
        private TimetableContext db;

        public GroupRepository(DbContextOptions<TimetableContext> options)
        {
            this.db = new TimetableContext(options);
        }

        public IEnumerable<Group> GetAll()
        {
            return db.Groups;
        }

        public Group Get(int id)
        {
            return db.Groups.Find(id);
        }

        public void Create(Group group)
        {
            db.Groups.Add(group);
        }
        public void Update(Group group)
        {
            db.Groups.Update(group);
        }
        public IEnumerable<Group> Find(Func<Group, Boolean> predicate)
        {
            return db.Groups.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Group group = db.Groups.Find(id);
            if (group != null)
                db.Groups.Remove(group);
        }
    }
}
