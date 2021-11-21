using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableApp.DataAccess.Entities;

namespace TimetableApp.DataAccess
{
    public class DbInitializer
    {
        public static void Initialize(TimetableContext db)
        {
            db.Database.EnsureCreated();
            Random randObj = new Random(1);

            //Заполнение таблицы аудитории
            if (!db.Classrooms.Any())
            {
                for (int i = 0; i < 20; i++)
                {
                    db.Classrooms.Add(new Classroom { ClassroomNumber = i + 1, BuildingID = 1, NumberOfSeats = 100, ClassroomTypeID = 1 });
                    db.SaveChanges();
                }

                for (int i = 0; i < 80; i++)
                {
                    db.Classrooms.Add(new Classroom { ClassroomNumber = i + 21, BuildingID = 1, NumberOfSeats = 30, ClassroomTypeID = 2 });
                    db.SaveChanges();
                }

                for (int i = 0; i < 15; i++)
                {
                    db.Classrooms.Add(new Classroom { ClassroomNumber = i + 1, BuildingID = 2, NumberOfSeats = 100, ClassroomTypeID = 1 });
                    db.SaveChanges();
                }

                for (int i = 0; i < 40; i++)
                {
                    db.Classrooms.Add(new Classroom { ClassroomNumber = i + 16, BuildingID = 2, NumberOfSeats = 30, ClassroomTypeID = 2 });
                    db.SaveChanges();
                }

            }
            //Заполнение таблицы семестр
            if (!db.Semesters.Any())
            {
                db.Semesters.Add(new Semester { SemesterNumber = 1, SemesterTitle = "Зимний семестр" });
                db.Semesters.Add(new Semester { SemesterNumber = 1, SemesterTitle = "Летний семестр" });
                db.SaveChanges();
            }
            //Заполнение таблицы расписание
            if (!db.Timetables.Any())
            {
                for (int moths = 9; moths <= 12; moths++)
                {
                    for (int i = 1; i <= 30; i++)
                    {
                        for (int lessonId = 1; lessonId <= 5; lessonId++)
                        {
                            db.Timetables.Add(new Timetable
                            {
                                Date = new DateTime(DateTime.Now.Year, moths, i),
                                DayID = i % 5 + 1,
                                LessonID = lessonId,
                                DisciplineID = randObj.Next(1, 1000),
                                ActivityTypeID = randObj.Next(4, 6),
                                GroupID = randObj.Next(1, 50),
                                TeacherID = randObj.Next(1, 200),
                                ClassroomID = randObj.Next(1, 155),
                                SemesterID = 1
                            });
                        }
                        db.SaveChanges();

                    }

                }
            }

        }

    }
}
