using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.DataAccess.Entities;

namespace TimetableApp.DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<ActivityType> ActivityTypes { get; }
        IRepository<Bell> Bells { get; }
        IRepository<Building> Buildings { get; }
        IRepository<Classroom> Classrooms { get; }
        IRepository<ClassroomType> ClassroomTypes { get; }
        IRepository<Day> Days { get; }
        IRepository<Discipline> Disciplines { get; }
        IRepository<Faculty> Faculties { get; }
        IRepository<Group> Groups { get; }
        IRepository<Semester> Semesters { get; }
        IRepository<Teacher> Teachers { get; }
        IRepository<Timetable> Timetables { get; }
        void Save();
    }
}
