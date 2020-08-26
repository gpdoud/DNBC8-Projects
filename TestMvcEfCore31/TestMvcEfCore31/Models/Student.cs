using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMvcEfCore31.Models {
    
    public class Student {

        public int Id { get; set; }
        public string Code { get; set; } // unique
        public string Name { get; set; }
        public decimal Tuition { get; set; }

        public Student() { }
    }
}
