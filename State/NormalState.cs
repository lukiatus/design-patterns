namespace BankingApp.State
{
    public class NormalState : AccountState
    {
        public NormalState(double balance, BankAccount bankAccount)
        {
            Balance = balance;
            BankAccount = bankAccount;
        }

        public override void Deposit(int amount)
        {
            Balance += amount;
            if (Balance >= 1000) BankAccount.AccountState = new PremiumState(Balance, BankAccount);
        }

        public override string ToString()
        {
            return "NORMAL";
        }

        public override void Withdraw(int amount)
        {
            Balance -= amount;
            if (Balance <= 0) BankAccount.AccountState = new OverdrawnState(Balance, BankAccount);
        }
    }
}