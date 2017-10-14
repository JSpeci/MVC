﻿namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize( AppContext context )
        {
            context.Database.EnsureCreated( );

            //// Look for any students.
            //if (context.People.Any())
            //{
            //    return;   // DB has been seeded
            //}

            //var students = new Person[]
            //{
            //new Person{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            //new Person{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //new Person{FirstMidName="Arturo",LastName="An;and",EnrollmentDate=DateTime.Parse("2003-09-01")},
            //new Person{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //new Person{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //new Person{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            //new Person{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            //new Person{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            //};
            //foreach (Person s in students)
            //{
            //    context.People.Add(s);
            //}
            //context.SaveChanges();

            //var courses = new Course[]
            //{
            //new Course{CourseID=1050,Title="Chemistry",Credits=3},
            //new Course{CourseID=4022,Title="Microeconomics",Credits=3},
            //new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
            //new Course{CourseID=1045,Title="Calculus",Credits=4},
            //new Course{CourseID=3141,Title="Trigonometry",Credits=4},
            //new Course{CourseID=2021,Title="Composition",Credits=3},
            //new Course{CourseID=2042,Title="Literature",Credits=4}
            //};
            //foreach (Course c in courses)
            //{
            //    context.Courses.Add(c);
            //}
            //context.SaveChanges();

            //var enrollments = new Group[]
            //{
            //new Group{StudentID=1,CourseID=1050,Grade=Grade.A},
            //new Group{StudentID=1,CourseID=4022,Grade=Grade.C},
            //new Group{StudentID=1,CourseID=4041,Grade=Grade.B},
            //new Group{StudentID=2,CourseID=1045,Grade=Grade.B},
            //new Group{StudentID=2,CourseID=3141,Grade=Grade.F},
            //new Group{StudentID=2,CourseID=2021,Grade=Grade.F},
            //new Group{StudentID=3,CourseID=1050},
            //new Group{StudentID=4,CourseID=1050},
            //new Group{StudentID=4,CourseID=4022,Grade=Grade.F},
            //new Group{StudentID=5,CourseID=4041,Grade=Grade.C},
            //new Group{StudentID=6,CourseID=1045},
            //new Group{StudentID=7,CourseID=3141,Grade=Grade.A},
            //};
            //foreach (Group e in enrollments)
            //{
            //    context.Groups.Add(e);
            //}
            //context.SaveChanges();
        }
    }
}