using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace Timetable.Models
{
    public class TimetableContext : DbContext
    {
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<Bell>  Bells { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Timetable> Timetables { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<ClassroomType> ClassroomTypes { get; set; }
        public TimetableContext()
        {
            //    Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-B9763I0\SQL_EXPRESS;Database=Timetable;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityType>().HasData(
                new ActivityType[]
                {
                new ActivityType { ActivityTypeID  = 1, ActivityTypeName = "Лекция", ActivityTypesShortName = "ЛК"},
                new ActivityType { ActivityTypeID  = 2, ActivityTypeName = "Лабораторное занятие", ActivityTypesShortName = "ЛЗ"},
                new ActivityType { ActivityTypeID  = 3, ActivityTypeName = "Практическое заняти", ActivityTypesShortName = "ПЗ"}
                });

            modelBuilder.Entity<Building>().HasData(
                new Building[]
                {
                new Building { BuildingID  = 1, BuildingName = "Первый корпус"},
                new Building { BuildingID  = 2, BuildingName = "Второй корпус"},
                });

            modelBuilder.Entity<ClassroomType>().HasData(
                new ClassroomType[]
                {
                new ClassroomType { ClassroomTypeID  = 1, СlassroomTypeName = "Лекционная аудитория"},
                new ClassroomType { ClassroomTypeID  = 2, СlassroomTypeName = "Аудиотрия для практических и лабораторных занятий"},
                });

            modelBuilder.Entity<Day>().HasData(
                new Day[]
                {
                new Day { DayID  = 1, DayName = "Понедельник", DayShortName = "ПН"},
                new Day { DayID  = 2, DayName = "Вторник", DayShortName = "ВТ"},
                new Day { DayID  = 3, DayName = "Среда", DayShortName = "СР"},
                new Day { DayID  = 4, DayName = "Четверг", DayShortName = "ЧТ"},
                new Day { DayID  = 5, DayName = "Пятница", DayShortName = "ПТ"},
                new Day { DayID  = 6, DayName = "Суббота", DayShortName = "СБ"}
                });

            Teacher[] teachers = new Teacher[1000];
            for(int i = 0; i < 1000; i++)
            {
                var teacher = new Teacher { TeacherID = i + 1, TeacherName = "TeacherName" + i + 1 };
                teachers.Append(teacher);
            }
            modelBuilder.Entity<Teacher>().HasData(teachers);

            Discipline[] disciplines = new Discipline[1000];
            for (int i = 0; i < 1000; i++)
            {
                var discipline = new Discipline { DisciplineID = i + 1, DisciplineNmae = "Discipline" + i + 1 };
                disciplines.Append(discipline);
            }
            modelBuilder.Entity<Discipline>().HasData(disciplines);

            Classroom[] classrooms = new Classroom[155];
            for(int i = 0; i < 20; i++)
            {
                var classroom1 = new Classroom { ClassroomID = i + 1, ClassroomNumber = i + 1, BuildingID = 1, NumberOfSeats = 100, ClassroomTypeID = 1 };
                classrooms.Append(classroom1);
            }

            for (int i = 0; i < 80; i++)
            {
                var classroom2 = new Classroom { ClassroomID = i + 21, ClassroomNumber = i + 21, BuildingID = 1, NumberOfSeats = 30, ClassroomTypeID = 2 };
                classrooms.Append(classroom2);
            }

            for (int i = 0; i < 15; i++)
            {
                var classroom3 = new Classroom { ClassroomID = i + 1, ClassroomNumber = i + 1, BuildingID = 2, NumberOfSeats = 100, ClassroomTypeID = 1 };
                classrooms.Append(classroom3);
            }

            for (int i = 0; i < 40; i++)
            {
                var classroom4 = new Classroom { ClassroomID = i + 16, ClassroomNumber = i + 16, BuildingID = 2, NumberOfSeats = 30, ClassroomTypeID = 2 };
                classrooms.Append(classroom4);
            }
            modelBuilder.Entity<Classroom>().HasData(classrooms);
        }
    }
}
