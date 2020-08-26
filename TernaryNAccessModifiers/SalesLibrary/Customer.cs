using System;
using System.Collections.Generic;
using System.Text;

namespace TernaryNAccessModifiers {
    
    public class Customer {

        private static int NextId = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        private bool IsNationalAccount { get; set; }

        public override string ToString() {
            return $"Id={this.Id}, Name={this.Name}, NAcct={this.IsNationalAccount}";
        }

        static Customer() {
            // read file to get the next id to be assigned
        }

        public void NationalAccount(string yesOrNo) {
            this.IsNationalAccount = yesOrNo.Equals("yes") ? true : false;
        }

        public static string PrintNextId() {
            return $"Next id is {NextId}";
        }

        public Customer(string Name) {
            this.Id = NextId;
            this.Name = Name;
            NextId++;
        }
    }
}
