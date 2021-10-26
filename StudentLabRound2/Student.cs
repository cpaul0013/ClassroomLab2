using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentLabRound2
{
    class Student
    {   [Key]
        public int StudentId { get; set; }



        public string Name { get; set; }
        public string Food { get; set; }
        public string Hometown { get; set; }

        public Student(string name, string food, string hometown)
        {

            Name = name;
            Food = food;
            Hometown = hometown;


        }





    }
}
