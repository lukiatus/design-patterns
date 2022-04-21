namespace BankingApp.State
{
    public class PremiumState : AccountState
    {
        public PremiumState(double balance, BankAccount bankAccount)
        {
            Balance = balance;
            BankAccount = bankAccount;
        }

        public override void Deposit(int amount)
        {
            Balance += amount * 1.05;
        }

        public override string ToString()
        {
            return "PREMIUM";
        }

        public override void Withdraw(int amount)
        {
            Balance -= amount;
            if (Balance < 0) BankAccount.AccountState = new OverdrawnState(Balance, BankAccount);
            if (Balance < 1000) BankAccount.AccountState = new NormalState(Balance, BankAccount);
        }
    }
}