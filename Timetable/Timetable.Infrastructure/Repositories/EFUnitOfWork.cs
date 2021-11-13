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
    public class EFUnitOfWork : IUnitOfWork
    {
        private TimetableContext db;

        private ActivityTypeRepository activityTypeRepository;
        private BellRepository bellRepository;
        private BuildingRepository buildingRepository;
        private ClassroomRepository classroomRepository;
        private ClassroomTypeRepository classroomTypeRepository;
        private DayRepository dayRepository;
        private DisciplineRepository disciplineRepository;
        private FacultyRepository facultyRepository;
        private GroupRepository groupRepository;
        private SemesterRepository semesterRepository;
        private TeacherRepository teacherRepository;
        private TimetableRepository timetableRepository;
        public EFUnitOfWork(DbContextOptions<TimetableContext> options)
        {
            db = new TimetableContext(options);
        }

        public IRepository<ActivityType> ActivityTypes
        {
            get
            {
                if (activityTypeRepository == null)
                    activityTypeRepository = new ActivityTypeRepository(db);
                return activityTypeRepository;
            }
        }
        public IRepository<Bell> Bells
        {
            get
            {
                if (bellRepository == null)
                    bellRepository = new BellRepository(db);
                return bellRepository;
            }
        }

        public IRepository<Building> Buildings
        {
            get
            {
                if (buildingRepository == null)
                    buildingRepository = new BuildingRepository(db);
                return buildingRepository;
            }
        }
        public IRepository<Classroom> Classrooms
        {
            get
            {
                if (classroomRepository == null)
                    classroomRepository = new ClassroomRepository(db);
                return classroomRepository;
            }
        }
        public IRepository<ClassroomType> ClassroomTypes
        {
            get
            {
                if (classroomTypeRepository == null)
                    classroomTypeRepository = new ClassroomTypeRepository(db);
                return classroomTypeRepository;
            }
        }
        public IRepository<Day> Days
        {
            get
            {
                if (dayRepository == null)
                    dayRepository = new DayRepository(db);
                return dayRepository;
            }
        }
        public IRepository<Discipline> Disciplines
        {
            get
            {
                if (disciplineRepository == null)
                    disciplineRepository = new DisciplineRepository(db);
                return disciplineRepository;
            }
        }
        public IRepository<Faculty> Faculties
        {
            get
            {
                if (facultyRepository == null)
                    facultyRepository = new FacultyRepository(db);
                return facultyRepository;
            }
        }
        public IRepository<Group> Groups
        {
            get
            {
                if (groupRepository == null)
                    groupRepository = new GroupRepository(db);
                return groupRepository;
            }
        }
        public IRepository<Semester> Semesters
        {
            get
            {
                if (semesterRepository == null)
                    semesterRepository = new SemesterRepository(db);
                return semesterRepository;
            }
        }
        public IRepository<Teacher> Teachers
        {
            get
            {
                if (teacherRepository == null)
                    teacherRepository = new TeacherRepository(db);
                return teacherRepository;
            }
        }
        public IRepository<Timetable> Timetables
        {
            get
            {
                if (timetableRepository == null)
                    timetableRepository = new TimetableRepository(db);
                return timetableRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
