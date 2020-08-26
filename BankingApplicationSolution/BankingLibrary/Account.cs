using System;

namespace BankingLibrary {

    public abstract class Account {

        private static int NextAcctNbr = 1;
        private const int AcctNbrInc = 9;

        public int AcctNbr { get; private set; }
        public string Description { get; set; } = "Account";
        public decimal Balance { get; set; }

        private int AttemptsToOverdraw = 0;

        private bool CheckAmountGTZero(decimal amount) {
            return (amount <= 0) ? false : true;
        }

        public void Deposit(decimal amount) {
            if(CheckAmountGTZero(amount)) {
                Balance += amount;
            }
        }

        private bool IsSufficientFunds(decimal amount) {
            if(Balance >= amount) {
                return true;
            }
            AttemptsToOverdraw++;
            return false;
        }
        public bool Withdraw(decimal amount) {
            if(CheckAmountGTZero(amount) && IsSufficientFunds(amount)) {
                Balance -= amount;
                return true;
            }
            return false;
        }
        public void Transfer(decimal amount, Account toAccount) {
            if(this.Withdraw(amount)) {
                toAccount.Deposit(amount);
            }
        }

        public override string ToString() {
            return $"AcctNbr={AcctNbr}, Desc={Description}, Bal={Balance}";
        }

        public void Debug() {
            Console.WriteLine(this);
        }

        public Account() {
            this.AcctNbr = NextAcctNbr;
            NextAcctNbr += AcctNbrInc;
        }
    }
}
