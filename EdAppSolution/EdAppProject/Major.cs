using System;
using System.Collections.Generic;
using System.Text;

namespace EdAppProject {
    class Major { // =====================================

        public int Id;
        public string Description;
        public int MinSat;

        public Major(int id, string description, int minsat) {
            Id = id;
            Description = description;
            MinSat = minsat;
        }

        public void Print() {
            Console.WriteLine($"Id={Id}, Desc={Description}, Min={MinSat}");
        }

    } // class ==============================================
} // namespace
