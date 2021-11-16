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
    public class ActivityTypeRepository : IRepository<ActivityType>
    {
        private TimetableContext db;

        public ActivityTypeRepository (DbContextOptions<TimetableContext> options)
        {
            this.db = new TimetableContext(options);
        }

        public IEnumerable<ActivityType> GetAll()
        {
            return db.ActivityTypes;
        }

        public ActivityType Get(int id)
        {
            return db.ActivityTypes.Find(id);
        }

        public void Create(ActivityType newType)
        {
            db.ActivityTypes.Add(newType);
        }
        public void Update(ActivityType newType)
        {
            db.ActivityTypes.Update(newType);
        }
        public IEnumerable<ActivityType> Find(Func<ActivityType, Boolean> predicate)
        {
            return db.ActivityTypes.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            ActivityType activityType = db.ActivityTypes.Find(id);
            if (activityType != null)
                db.ActivityTypes.Remove(activityType);
        }
    }
}
