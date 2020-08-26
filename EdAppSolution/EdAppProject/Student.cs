using System;
using System.Collections.Generic;
using System.Text;

namespace EdAppProject {
    class Student {

        public int Id;
        public string Firstname;
        public string Lastname;
        public int SAT;
        public double GPA;
        public Major Major;

        public Student(int id, string firstname, string lastname, 
            int sat, double gpa, Major major) {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            SAT = sat;
            GPA = gpa;
            Major = major;
        }

        public void Print() {
            Console.WriteLine($"Id={Id}, Name={Firstname} {Lastname}, " +
                $"SAT={SAT}, GPA={GPA}, Major={Major.Description}" +
                $", MinSat Required={Major.MinSat}");
        }
    }
}
