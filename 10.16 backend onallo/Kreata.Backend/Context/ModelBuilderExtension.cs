using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Enums;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    BirthsDay=new DateTime(2022,10,10),
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Stréber",
                    BirthsDay=new DateTime(2021,4,4),
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel="érettségi"
                }
            };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Mery",
                    LastName="Matek",
                    BirthsDay=new DateTime(2020,2,2),
                    IsHeadTeacher=true,
                    IsWoomen=true,
                },
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Feri",
                    LastName="Föci",
                    BirthsDay=new DateTime(2010,10,10),
                    IsHeadTeacher=false,
                    IsWoomen=false,
                }
            };

            List<Parent> parents = new List<Parent>
            {
                new Parent
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Pacek",
                    LastName = "Matek",
                    BirthsDay = new DateTime(2020, 2, 2),
                    residency = "Ulánbátor",
                },
                new Parent
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Geri",
                    LastName = "Feci",
                    BirthsDay = new DateTime(2020, 2, 2),
                    residency = "Szeged",
                }
            };

            List<Pizzeriak> pizzeriak = new List<Pizzeriak>
            {
                new Pizzeriak
                {
                    Id = Guid.NewGuid(),
                    Name = "Pacek Pizza",
                    address = "Ulánbátor",
                },
                new Pizzeriak
                {
                    Name = "Bella Ciao",
                    address = "Szeged",
                }
            };

            // Students
            modelBuilder.Entity<Student>().HasData(students);
            modelBuilder.Entity<Teacher>().HasData(teachers);
            modelBuilder.Entity<Parent>().HasData(parents);
            modelBuilder.Entity<Pizzeriak>().HasData(pizzeriak);
        }
    }
}
