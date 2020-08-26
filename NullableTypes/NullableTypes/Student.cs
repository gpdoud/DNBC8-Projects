using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes {
    
    public class Student {

        public int Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }
        public int? SAT { get; set; }

        public int? MajorId { get; set; }
        public Major? Major { get; set;  }


    }
}
