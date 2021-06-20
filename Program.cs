using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static string[] arr = { "Matthew", "Mark", "Luke", "John" };
        static List<string> project = new List<string>(){
          "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C++",
            "MVC Tutorials" ,
            "Java"
        };

        static List<Student> studentList = new List<Student>() { // adding  elements
        // to custom class using collection - initializer syntax
            new Student() { StudentID = 1, StudentName = "John", age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  age = 18 },
            new Student() { StudentID = 4, StudentName = "Ram" , age = 20  },
            new Student() { StudentID = 5, StudentName = "Ron" , age = 21 }
        };
        static string[] getName()
        {
            // if you set the arr inside the method every time we call the 
            // getName method it will create new reference in the memory.
            // string[] arr = { "Matthew", "Mark", "Luke", "John" };
            return arr;
        }
        static void printName()
        {
            var name = getName();// create a reference array of string
            var name1 = getName(); // create  same reference array of string

            if (name == name1)
            {
                Console.WriteLine("same");
                Console.WriteLine($"same :{project.Count}");
            }
            else
            {
                Console.WriteLine("Different");
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            printName();


            // Linq query syntax

            var result = from str in project
                         where str.Contains("Tutorials")
                         select str;

            // Linq lambda method 
            var result1 = project.Where(str => str.Contains("C++"));

            foreach (var list in result1)
            {
                Console.WriteLine(list);
            }

            var students = from stud in studentList
                           where stud.StudentID == 1
                           select new { stud.StudentID, stud.StudentName, stud.age };

            var students1 = studentList.Where(stud => stud.age > 12 && stud.age < 21);

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            foreach (var student in students1)
            {
                Console.WriteLine(student);
            }
        }

    }
}


