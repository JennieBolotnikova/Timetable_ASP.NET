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
            //Заполнение таблицы тип занятия
            if (!db.ActivityTypes.Any())
            {
                db.ActivityTypes.Add(new ActivityType { ActivityTypeName = "Лекция", ActivityTypesShortName = "ЛК" });
                db.ActivityTypes.Add(new ActivityType { ActivityTypeName = "Лабораторное занятие", ActivityTypesShortName = "ЛЗ" });
                db.ActivityTypes.Add(new ActivityType { ActivityTypeName = "Практическое заняти", ActivityTypesShortName = "ПЗ" });
                db.SaveChanges();
            }
            //Заполнение таблицы расписание звонков
            if (!db.Bells.Any())
            {
                db.Bells.Add(new Bell { LessonStartTime = new TimeSpan(15, 5, 0), LessonEndTime = new TimeSpan(16, 30, 0) });
                db.Bells.Add(new Bell { LessonStartTime = new TimeSpan(13, 30, 0), LessonEndTime = new TimeSpan(14, 55, 0) });
                db.Bells.Add(new Bell { LessonStartTime = new TimeSpan(11, 35, 0), LessonEndTime = new TimeSpan(13, 0, 0) });
                db.Bells.Add(new Bell { LessonStartTime = new TimeSpan(10, 0, 0), LessonEndTime = new TimeSpan(11, 25, 0) });
                db.Bells.Add(new Bell { LessonStartTime = new TimeSpan(8, 20, 0), LessonEndTime = new TimeSpan(9, 45, 0) });
                db.SaveChanges();
            }
            //Заполнение таблицы корпуса
            if (!db.Buildings.Any())
            {
               
                db.Buildings.Add(new Building { BuildingName = "Второй корпус" });
                db.Buildings.Add(new Building { BuildingName = "Первый корпус" });
                db.SaveChanges();
            }
            //Заполнение таблицы типы аудиторий
            if (!db.ClassroomTypes.Any())
            {
                db.ClassroomTypes.Add(new ClassroomType { ClassroomTypeName = "Лекционная аудитория" });
                db.ClassroomTypes.Add(new ClassroomType { ClassroomTypeName = "Аудиотрия для практических и лабораторных занятий" });
                db.SaveChanges();
            }
            //Заполнение таблицы дни неддели
            if (!db.Days.Any())
            {
                db.Days.Add(new Day { DayName = "Пятница", DayShortName = "ПТ" });
                db.Days.Add(new Day { DayName = "Четверг", DayShortName = "ЧТ" });
                db.Days.Add(new Day { DayName = "Среда", DayShortName = "СР" });
                db.Days.Add(new Day { DayName = "Вторник", DayShortName = "ВТ" });
                db.Days.Add(new Day { DayName = "Понедельник", DayShortName = "ПН" });
                db.SaveChanges();
            }
            //Заполнение таблицы преподаватели
            if (!db.Teachers.Any())
            {
                for (int i = 0; i < 200; i++)
                {
                    db.Teachers.Add(new Teacher { TeacherName = $"TeacherName{i + 1}" });
                    db.SaveChanges();
                }

            }
            //Заполнение таблицы дисциплины
            if (!db.Disciplines.Any())
            {
                for (int i = 0; i < 1000; i++)
                {
                    db.Disciplines.Add(new Discipline { DisciplineNmae = $"Discipline{i + 1}" });
                    db.SaveChanges();
                }

            }
            //Заполнение таблицы факультеты
            if (!db.Faculties.Any())
            {
                for (int i = 0; i < 10; i++)
                {
                    db.Faculties.Add(new Faculty { FacultyName = $"Faculty{i + 1}" });
                    db.SaveChanges();
                }

            }
            //Заолнение таблиц группы
            if (!db.Groups.Any())
            {
                for (int i = 0; i < 50; i++)
                {
                    db.Groups.Add(new Group { GroupName = $"GroupName{i + 1}", GroupNumber = i + 1, FacultyID = randObj.Next(1, 10), NumberOfStudents = randObj.Next(15, 30) });
                    db.SaveChanges();
                }

            }
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
                
                db.Semesters.Add(new Semester { SemesterNumber = 1, SemesterTitle = "Летний семестр" });
                db.Semesters.Add(new Semester { SemesterNumber = 1, SemesterTitle = "Зимний семестр" });
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
                                BellID = lessonId,
                                DisciplineID = randObj.Next(1, 1000),
                                ActivityTypeID = randObj.Next(1, 3),
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
