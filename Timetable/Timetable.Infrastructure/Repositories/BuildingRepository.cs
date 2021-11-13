using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.DataAccess.Interfaces;
using TimetableApp.DataAccess.Entities;

namespace TimetableApp.DataAccess.Repositories
{
    public class BuildingRepository : IRepository<Building>
    {
        private TimetableContext db;

        public BuildingRepository(TimetableContext context)
        {
            this.db = context;
        }

        public IEnumerable<Building> GetAll()
        {
            return db.Buildings;
        }

        public Building Get(int id)
        {
            return db.Buildings.Find(id);
        }

        public void Create(Building building)
        {
            db.Buildings.Add(building);
        }
        public void Update(Building building)
        {
            db.Buildings.Update(building);
        }
        public IEnumerable<Building> Find(Func<Building, Boolean> predicate)
        {
            return db.Buildings.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Building building = db.Buildings.Find(id);
            if (building != null)
                db.Buildings.Remove(building);
        }
    }
}
