using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary {
    
    public class InterestAccount : Account {

        public decimal InterestRate { get; private set; }

        public void CalculateInterest(int Months) {
            var interest = this.Balance * (this.InterestRate / 12) * Months;
            Deposit(interest);
            Console.WriteLine($"Calculated interest is {interest}");
        }

        public override string ToString() {
            return $"{base.ToString()}, IntRate={InterestRate}";
        }
        public InterestAccount(double interestRate) : this() {
            InterestRate = Convert.ToDecimal(interestRate);
        }
        public InterestAccount() : base() {
            this.Description = "Interest Account";
        }
    }
}
