using System;
using System.Collections.Generic;
using System.Linq;

namespace LabAboutCollection03
{
    class Program
    {
        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"ID: {this.ID} - Name: {this.Name} - Age: {this.Age} ";
            }
        }

        public static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>() {
                new Student() { ID = 1, Name = "Huong", Age = 18 } ,
                new Student() { ID = 2, Name = "Cao",  Age = 22  } ,
                new Student() { ID = 3, Name = "Binh",  Age = 18  } ,
                new Student() { ID = 4, Name = "An" , Age = 20  } ,
                new Student() { ID = 5, Name = "Dung" , Age = 21  }
            };




            var listAlphabetically = studentList.OrderBy(x => x.Name);

            // iterate students and print them to the console
            foreach (var student in listAlphabetically)
                Console.WriteLine(student);



            // keep console open
            Console.ReadKey();
        }
    }
}

