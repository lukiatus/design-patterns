namespace BankingApp.State
{
    public class OverdrawnState : AccountState
    {
        public OverdrawnState(double balance, BankAccount bankAccount)
        {
            Balance = balance;
            BankAccount = bankAccount;
        }

        public override void Deposit(int amount)
        {
            Balance += amount;
            if (Balance > 0) BankAccount.AccountState = new NormalState(Balance, BankAccount);
        }

        public override string ToString()
        {
            return "OVERDRAWN";
        }

        public override void Withdraw(int amount)
        {
            // This is not possible in this state
        }
    }
}