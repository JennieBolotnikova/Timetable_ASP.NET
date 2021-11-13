using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.DataAccess.Interfaces;
using TimetableApp.DataAccess.Entities;

namespace TimetableApp.DataAccess.Repositories
{
    public class ClassroomTypeRepository : IRepository<ClassroomType>
    {
        private TimetableContext db;

        public ClassroomTypeRepository(TimetableContext context)
        {
            this.db = context;
        }

        public IEnumerable<ClassroomType> GetAll()
        {
            return db.ClassroomTypes;
        }

        public ClassroomType Get(int id)
        {
            return db.ClassroomTypes.Find(id);
        }

        public void Create(ClassroomType classroomType)
        {
            db.ClassroomTypes.Add(classroomType);
        }
        public void Update(ClassroomType classroomType)
        {
            db.ClassroomTypes.Update(classroomType);
        }
        public IEnumerable<ClassroomType> Find(Func<ClassroomType, Boolean> predicate)
        {
            return db.ClassroomTypes.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            ClassroomType classroomType = db.ClassroomTypes.Find(id);
            if (classroomType != null)
                db.ClassroomTypes.Remove(classroomType);
        }
    }
}
