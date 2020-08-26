using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducationService.Models {

    public class Student {

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int SAT { get; set; }
        public double GPA { get; set; }
        public int? MajorId { get; set; }

        public virtual Major Major { get; set; }

        public Student() { }
    }
}
