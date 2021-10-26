using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentLabRound2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names =
            {
                "Justin",
                "Matt",
                "Logan",
                "Raston",
                "Yousif",
                "Yash",
                "Chris",
                "Radeen",
                "Josh",
                "Aron",
                "Kasean",
                "Scott",
                "Delmar",
                "Brandon"
            };

            string[] hometown =
            {
                "Wyoming,MI",
                "Flint,MI",
                "Plymouth,MI",
                "Zeeland, MI",
                "Oak Park, MI",
                "Detroit,MI",
                "Novi",
                "Warren, MI",
                "Northville",
                "Berea, KY",
                "Detroit, MI",
                "Lansing, MI",
                "Detroit,Mi",
                "Novi"
            };

            string[] foods =
            {
                "Baja Blast",
                 "Hot Wings",
                 "Fuyuns",
                 "Vanilla Instant Pudding",
                 "Deep Dish Pizza",
                 "Hot Cheeto Puffs",
                 "Tacos",
                 "Mexican",
                 "Naleśniki",
                 "sushi",
                 "steak",
                 "Nashville Chicken",
                 "vietnamese food",
                 "Sushi"

            };
            bool runProgram = true;
            while (runProgram)
            {
                StudentContext context = new StudentContext();
                List<Student> StudentList = new List<Student>();
                //StudentList = GetList(names, hometown, foods);
                //CreateDB(StudentList, context);
                DisplayAllDB(context);
                DisplayStudentDB();
                runProgram = Validator.Validator.getContinue();
            }
        }
        

        public static List<Student> GetList(string[] name, string[] hometown, string[] food)
        {
            List<Student> StudentList = new List<Student>();
            for(int i = 0; i < name.Length; i++)
            {
                StudentList.Add(new Student(name[i], hometown[i], food[i]));


            }

            return StudentList;


        }

        public static void CreateDB(List<Student> students, StudentContext context)
        {   using (context)
            {
                foreach (Student s in students)
                {

                    context.Add(s);

                }
                context.SaveChanges();

            }

        }
        //context.students.Add(student13)


        public static void DisplayAllDB(StudentContext context)
        {       foreach(Student s in context.students)
                 {
                Console.WriteLine($"{s.StudentId} {s.Name}");

                   }
            
        }

        public static void DisplayStudentDB()
        {
            StudentContext context = new StudentContext();
            Student s = new Student("", "", "");
            Console.WriteLine("Please enter a student's ID number: ");
            double response = Validator.Validator.GetNumber(1, 14);
            s = context.students.Where(Student => Student.StudentId == response).First();
            Console.WriteLine($"{s.Food} {s.Hometown}");


        }

    }
}
