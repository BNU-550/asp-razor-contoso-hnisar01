using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_razor_contoso.models;

namespace asp_razor_contoso.Data
{
    public class DBInitialiser
    {
        public static class DbInitialiser
        {
            public static void Initialise(ApplicationDbContext context)
            {
                // Look for any students.
                if (context.Students.Any())
                {
                    return;   // DB has been seeded
                }

                var students = new Student[]
                {
                new Student{FirstName="Bob",LastName="Builder",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="Will",LastName="Smith",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Post",LastName="Pat",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Dwayne",LastName="Johnson",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Kevin",LastName="Hart",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Tony",LastName="Stark",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Student{FirstName="Bruce",LastName="Wayne",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Norman",LastName="Osborn",EnrollmentDate=DateTime.Parse("2019-09-01")}
                };

                context.Students.AddRange(students);
                context.SaveChanges();

                var courses = new Course[]
                {
                new Course{CourseID=1050,Title="Computing",Credits=3},
                new Course{CourseID=4022,Title="Accounting",Credits=3},
                new Course{CourseID=4041,Title="Finance",Credits=3},
                new Course{CourseID=1045,Title="Web Development",Credits=4},
                new Course{CourseID=3141,Title="Law",Credits=4},
                new Course{CourseID=2021,Title="Sociology",Credits=3},
                new Course{CourseID=2042,Title="Art",Credits=4}
                };

                context.Courses.AddRange(courses);
                context.SaveChanges();

                var enrollments = new Enrollment[]
                {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grades.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grades.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grades.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grades.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grades.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grades.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grades.A},
                };

                context.Enrollments.AddRange(enrollments);
                context.SaveChanges();
            }
        }
    }
}
